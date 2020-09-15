using IView.Core.Models;
using IView.Core.Utilities;
using IViewNet.Pipes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IView.Core.Pipe
{
    public class PipeServerDriver
    {
        #region "Fields"
        private IViewLogger Logger;
        private IViewPipeServer ServerPipe;
        private PipeConfig ServerPipeConfig;
        #endregion

        public PipeServerDriver(IViewLogger Logger)
        {
            this.Logger = Logger;
            InitializePipeServer();
        }

        private void InitializePipeServer()
        {
            ServerPipeConfig = new PipeConfig();
            ServerPipe = new IViewPipeServer(ServerPipeConfig);
            ServerPipe.ClientConnectedEvent += ServerPipe_ClientConnectedEvent;
            ServerPipe.ClientShutdownEvent += ServerPipe_ClientShutdownEvent;
            ServerPipe.ClientReceiveEvent += ServerPipe_ClientReceiveEvent;
            ServerPipe.ClientSendEvent += ServerPipe_ClientSendEvent;
            ServerPipe.ClientExceptionEvent += ServerPipe_ClientExceptionEvent;
        }

        private void ServerPipe_ClientConnectedEvent()
        {
            Logger.Log(new LogModel("Server Pipe Connected Successfully", "Server Pipe", DateTime.Now, Color.Green));
        }
        private void ServerPipe_ClientShutdownEvent()
        {
            Logger.Log(new LogModel("Server Pipe Disconnected", "Server Pipe", DateTime.Now, Color.Black));
        }
        private void ServerPipe_ClientReceiveEvent(byte[] Message)
        {
            Logger.Log(new LogModel("Server Pipe Received: " + Message.Length + " Bytes", "Server Pipe", DateTime.Now, Color.Purple));
        }
        private void ServerPipe_ClientSendEvent(byte[] Message)
        {
            Logger.Log(new LogModel("Server Pipe Send: " + Message.Length + " Bytes", "Server Pipe", DateTime.Now, Color.Purple));
        }
        private void ServerPipe_ClientExceptionEvent(Exception Error)
        {
            Logger.Log(new LogModel("Server Pipe Exception: " + Error.Message, "Server Pipe", DateTime.Now, Color.Red));
        }

        public void StartPipeServer()
        {
            ServerPipe.StartPipeServer();
        }

        public void ShutdownPipeServer()
        {
            if (ServerPipe.IsPipeShutdown == false)
            {
                ServerPipe.ShutdownServer();
            }
        }

        public void SendMessage(byte[] Message)
        {
            if (ServerPipe.IsPipeConnected)
            {
                ServerPipe.SendMessage(Message);
            }
        }
    }
}