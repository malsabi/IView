using IView.Core.Controllers;
using IView.Core.Globals;
using IView.Core.Models;
using IViewNet.Common;
using IViewNet.Common.Models;
using IViewNet.Server;
using System;
using System.Net;

namespace IView.Core.Networking
{
    public class ServerManager
    {
        private readonly IViewController Controller;
        #region "Properties"
        public Server MyServer { get; set; }
        public PacketRegister MyPacketRegister { get; set; }
        #endregion

        public ServerManager(IViewController Controller)
        {
            this.Controller = Controller;
        }

        public bool StartServer()
        {
            MyServer = new Server(Controller.GetDefaultServerSettings());

            StartListenerResult ListenerResult = MyServer.StartListener();

            if (ListenerResult.IsOperationSuccess)
            {
                Controller.Update(new LogModel(ListenerResult.Message, "Networking", DateTime.Now, LogColors.OnNews));
                StartAcceptorResult AcceptorResult = MyServer.StartAcceptor();
                if (AcceptorResult.IsOperationSuccess)
                {
                    Controller.Update(new LogModel(AcceptorResult.Message, "Networking", DateTime.Now, LogColors.OnNews));
                    MyPacketRegister = new PacketRegister(MyServer.PacketManager);
                    MyPacketRegister.RegisterUserPackets();
                    MyServer.LoadBlackListedIPS();
                    MyServer.OnClientConnect += MyServer_OnClientConnect;
                    MyServer.OnClientDisconnect += Server_OnClientDisconnect;
                    MyServer.OnClientAuthenticated += Server_OnClientVerified;
                    MyServer.OnClientReceive += Server_OnClientReceive;
                    MyServer.OnClientSend += Server_OnClientSend;
                    MyServer.OnClientBlackList += Server_OnConnectionBlackList;
                    MyServer.OnException += Server_OnException;
                    return true;
                }
                else
                {
                    Controller.Update(new LogModel(AcceptorResult.Message, "Networking", DateTime.Now, LogColors.OnError));
                    return false;
                }
            }
            else
            {
                Controller.Update(new LogModel(ListenerResult.Message, "Networking", DateTime.Now, LogColors.OnError));
            }
            return false;
        }
        public bool StopServer()
        {
            if (MyServer != null)
            {
                if (MyServer.IsListening)
                {
                    ShutdownResult Result = MyServer.Shutdown();
                    if (Result.IsOperationSuccess)
                    {
                        Controller.Update(new LogModel(Result.Message, "Networking", DateTime.Now, LogColors.OnNews));
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        private void Server_OnException(Exception Ex)
        {
            Controller.Update(new LogModel(Ex.Message, "Networking", DateTime.Now, LogColors.OnError));
        }
        private void Server_OnConnectionBlackList(IPAddress IP, string Reason)
        {
            Controller.Update(new LogModel(string.Format("Connection[{0}] BlackListed: {1}", IP, Reason), "Networking", DateTime.Now, LogColors.OnBlacklist));
        }
        private void Server_OnClientSend(Operation Client, Packet Message)
        {
            //Controller.Update(new LogModel(string.Format("Client[{0}] Sent: {1}", Client.EndPoint, Message.Name), "Networking", DateTime.Now, LogColors.OnSend));
        }
        private void Server_OnClientReceive(Operation Client, Packet Message)
        {
            if (Message.Code == 3)
            {
                Controller.Update(new LogModel(string.Format("Client[{0}] Received: {1}", Client.EndPoint, Message.Name), "Networking", DateTime.Now, LogColors.OnReceive));
            }
        }
        private void Server_OnClientVerified(Operation Client, bool Success)
        {
            if (Success)
            {
                Controller.Update(new LogModel(string.Format("Client[{0}] Verified Successfully", Client.EndPoint), "Networking", DateTime.Now, LogColors.OnAuthenticated));
            }
            else
            {
                Controller.Update(new LogModel(string.Format("Client[{0}] Verified Unsuccessfully", Client.EndPoint), "Networking", DateTime.Now, LogColors.OnError));
            }
        }
        private void Server_OnClientDisconnect(Operation Client, string Reason)
        {
            Controller.Update(new LogModel(string.Format("Client[{0}] Disconnected: {1}", Client.EndPoint, Reason), "Networking", DateTime.Now, LogColors.OnError));
        }
        private void MyServer_OnClientConnect(Operation Client)
        {
            Controller.Update(new LogModel(string.Format("Client[{0}] Connected", Client.EndPoint), "Networking", DateTime.Now, LogColors.OnConnected));
        }
    }
}