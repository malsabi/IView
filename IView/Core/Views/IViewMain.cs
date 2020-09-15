using IView.Core.Controllers;
using IView.Core.Utilities;
using IView.Core.Interfaces;
using IView.Core.Models;
using IViewNet.Common;
using System.Windows.Forms;
using System.Linq;
using System;
using IView.Core.Pipe;
using System.Threading;

namespace IView.Core.Views
{
    public partial class IViewMain : Form, IUpdate
    {
        #region "Private Feilds"
        private readonly PipeServerDriver ServerPipe;
        private readonly IViewController Controller;
        private readonly IViewLogger Logger;
        #endregion

        public IViewMain()
        {
            InitializeComponent();
            Controller = new IViewController(this);
            Logger = new IViewLogger(100);
            Logger.OnAllLogs += Log_OnAllLogs;
            ServerPipe = new PipeServerDriver(Logger);
            ServerPipe.StartPipeServer();
        }

        private void Log_OnAllLogs(LogModel[] AllLogs)
        {
            AddItems(AllLogs);
        }

        public NetConfig GetDefaultServerSettings()
        {
            return new NetConfig((int)MaximumKeepAliveNumeric.Value, (int)MaximumPendingConNumeric.Value, (int)MaximumConNumeric.Value, (int)MaximumConSameIPNumeric.Value, EnableDupIPAddressCheckBox.Checked, (int)MaximumMessageSizeNumeric.Value, (int)PortNumeric.Value, (int)BufferSizeNumeric.Value, (int)HeaderSizeNumeric.Value, BlackListTextBox.Text);
        }
        public void UpdateDefaultServerSettings(NetConfig ServerConfig, NetConfig ClientConfig)
        {
            //Port And IP Settings
            PortNumeric.Value = ServerConfig.GetPort();
            IPAddressBox.Text = "0.0.0.0";
            //Server Configuration
            MaximumKeepAliveNumeric.Value = ServerConfig.GetMaxTimeOut();
            MaximumPendingConNumeric.Value = ServerConfig.GetMaxBackLogConnections();
            MaximumConNumeric.Value = ServerConfig.GetMaxConnections();
            MaximumConSameIPNumeric.Value = ServerConfig.GetMaxSameIPConnections();
            MaximumMessageSizeNumeric.Value = 10000;
            BufferSizeNumeric.Value = ServerConfig.GetBufferSize();
            HeaderSizeNumeric.Value = ServerConfig.GetHeaderSize();
            EnableDupIPAddressCheckBox.Checked = ServerConfig.GetEnableDuplicateIPS();
            BlackListTextBox.Text = ServerConfig.GetBlackListPath();
            //Client Configuration
            ClientMaximumMessageSizeNumeric.Value = ClientConfig.GetMaxMessageSize();
            ClientBufferSizeNumeric.Value = ClientConfig.GetBufferSize();
            ClientHeaderSizeNumeric.Value = ClientConfig.GetHeaderSize();
        }

        private delegate void AddItemsDelegate(LogModel[] Items);
        private void AddItems(LogModel[] Items)
        {
            if (InvokeRequired == true)
            {
                if (this.IsDisposed == false)
                {
                    Invoke(new AddItemsDelegate(AddItems), new object[] { Items });
                }
            }
            else
            {
                ListViewItem[] e = Items.Select(listElement => new ListViewItem(new string[] { listElement.MessageType, listElement.Message, listElement.TimeStamp.ToString() }) { ForeColor = listElement.Color }).ToArray();
                ServerLogView.Items.AddRange(e);
                ServerLogView.ResizeColumns();
            }
        }

        public void UpdateFormLog(LogModel Log)
        {
            Logger.Log(Log);
        }
        public void UpdateFormListview()
        {
            throw new NotImplementedException();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            GeneralTabControl.SelectedIndex = 1;
            LayoutPanel.HorizontalScroll.Maximum = 0;
            LayoutPanel.AutoScroll = true;
            Controller.Update();
        }
        private void IViewMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ServerPipe.ShutdownPipeServer();
            Controller.StopServer();
            Logger.Dispose();
            Application.Exit();
        }
        private void StartServerButton_Click(object sender, EventArgs e)
        {
            if (StartServerButton.Text.Equals("Start Server"))
            {
                if (Controller.StartServer() == true)
                {
                    StartServerButton.Text = "Stop Server";
                }
            }
            else
            {
                if (Controller.StopServer() == true)
                {
                    StartServerButton.Text = "Start Server";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}