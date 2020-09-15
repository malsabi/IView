using System.Drawing;
namespace IView.Core.Globals
{
    public static class LogColors
    {
        #region "Global"
        public static Color OnNews = Color.FromArgb(70, 142, 192);
        public static Color OnError = Color.FromArgb(189, 11, 20);
        #endregion

        #region "Networking Colors"
        public static Color OnConnected = Color.FromArgb(22, 145, 35);
        public static Color OnAuthenticated = Color.FromArgb(93, 68, 201);
        public static Color OnSend = Color.FromArgb(35, 14, 71);
        public static Color OnReceive = Color.FromArgb(35, 14, 71);
        public static Color OnBlacklist = Color.FromArgb(39, 49, 61);
        public static Color OnDisconnect = Color.Black;
        #endregion
    }
}