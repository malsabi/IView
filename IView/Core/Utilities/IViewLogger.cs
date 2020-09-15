using IView.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading;

namespace IView.Core.Utilities
{
    public class IViewLogger : IDisposable
    {
        #region "Feilds"
        private Queue<LogModel> Logs;
        private object LogsLocker;
        private bool IsProcessing;
        private object IsProcessingLock;
        #endregion

        #region "Properties"
        public int PulseLogInterval { get; private set; }
        #endregion

        public delegate void OnAllLogsDelegate(LogModel[] AllLogs);
        public event OnAllLogsDelegate OnAllLogs;

        public IViewLogger(int PulseLogInterval)
        {
            this.PulseLogInterval = PulseLogInterval;
            InitializeLogger();
        }

        private void InitializeLogger()
        {
            Logs = new Queue<LogModel>();
            LogsLocker = new object();
            IsProcessing = false;
            IsProcessingLock = new object();
        }

        public void Log(LogModel Log)
        {
            lock (LogsLocker)
            {
                Logs.Enqueue(Log);
                lock (IsProcessingLock)
                {
                    if (IsProcessing == false)
                    {
                        IsProcessing = true;
                        ThreadPool.QueueUserWorkItem(new WaitCallback(Worker), null);
                    }
                }
            }
        }

        private void Worker(object o)
        {
            while (true)
            {
                LogModel[] AllLogs = null;
                lock (LogsLocker)
                {
                    if (Logs.Count == 0)
                    {
                        lock (IsProcessingLock)
                        {
                            IsProcessing = false;
                            break;
                        }
                    }
                    AllLogs = Logs.ToArray();
                    Logs.Clear();
                }
                if (AllLogs != null)
                {
                    OnAllLogs?.Invoke(AllLogs);
                }
                Thread.Sleep(PulseLogInterval);
            }
        }

        public void Dispose()
        {
            lock (LogsLocker)
            {
                Logs.Clear();
                OnAllLogs = null;
                lock (IsProcessingLock)
                {
                    IsProcessing = false;
                }
            }
        }
    }
}