using IView.Core.Interfaces;
using System;
using System.Drawing;

namespace IView.Core.Models
{
    public class LogModel : ILog
    {
        #region "Properties"
        public string Message { get; set; }
        public string MessageType { get; set; }
        public DateTime TimeStamp { get; set; }
        public Color Color { get; set; }
        public bool IsServer { get; set; }
        #endregion


        public LogModel(string Message, string TypeMessage, DateTime TimeStamp, Color Color, bool IsServer = true)
        {
            this.Message = Message;
            this.MessageType = TypeMessage;
            this.TimeStamp = TimeStamp;
            this.Color = Color;
            this.IsServer = IsServer;
        }

        public void OnWarning(string Message, string TypeMessage, DateTime TimeStamp, Color Color, bool IsServer = true)
        {
            this.Message = Message;
            this.MessageType = TypeMessage;
            this.TimeStamp = TimeStamp;
            this.Color = Color;
            this.IsServer = IsServer;
        }

        public void OnInformation(string Message, string TypeMessage, DateTime TimeStamp, Color Color, bool IsServer = true)
        {
            this.Message = Message;
            this.MessageType = TypeMessage;
            this.TimeStamp = TimeStamp;
            this.Color = Color;
            this.IsServer = IsServer;
        }

        public void OnError(string Message, string TypeMessage, DateTime TimeStamp, Color Color, bool IsServer = true)
        {
            this.Message = Message;
            this.MessageType = TypeMessage;
            this.TimeStamp = TimeStamp;
            this.Color = Color;
            this.IsServer = IsServer;
        }
    }
}