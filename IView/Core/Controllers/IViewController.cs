using IView.Core.Interfaces;
using IView.Core.Models;
using IView.Core.Networking;
using IViewNet.Common;


namespace IView.Core.Controllers
{
    public class IViewController
    {
        private ServerManager ServerManager;

        #region "Properties"
        #endregion

        private readonly IUpdate ViewInstance;
        public IViewController(IUpdate ViewInstance)
        {
            this.ViewInstance = ViewInstance;
            Initialize();
        }
        private void Initialize()
        {
            ServerManager = new ServerManager(this);
        }

        /// <summary>
        /// Updates the view networking settings
        /// </summary>
        public void Update()
        {
            ViewInstance.UpdateDefaultServerSettings(NetConfig.CreateDefaultServerConfig(), NetConfig.CreateDefaultClientConfig());
        }

        /// <summary>
        /// Update the Logs
        /// </summary>
        /// <param name="Log"></param>
        public void Update(LogModel Log)
        {
            ViewInstance.UpdateFormLog(Log);
        }

        /// <summary>
        /// //Will return the default if the user didn't edit any values on the view
        /// </summary>
        /// <returns>Server Settings</returns>
        public NetConfig GetDefaultServerSettings()
        {
            return ViewInstance.GetDefaultServerSettings();
        }

        /// <summary>
        /// Starts the server
        /// </summary>
        /// <returns></returns>
        public bool StartServer()
        {
            return ServerManager.StartServer();
        }

        /// <summary>
        /// Stops the server
        /// </summary>
        /// <returns></returns>
        public bool StopServer()
        {
            return ServerManager.StopServer();
        }
    }
}