using System.Drawing;
using System;

namespace IView.Core.Interfaces
{
    /// <summary>
    /// Warning
    /// Information
    /// Error
    /// </summary>
    public interface ILog
    {
        void OnWarning(string Message, string TypeMessage, DateTime TimeStamp, Color Color, bool IsServer);
        void OnInformation(string Message, string TypeMessage, DateTime TimeStamp, Color Color, bool IsServer);
        void OnError(string Message, string TypeMessage, DateTime TimeStamp, Color Color, bool IsServer);
    }
}
