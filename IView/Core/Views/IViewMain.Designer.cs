namespace IView.Core.Views
{
    partial class IViewMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.GeneralTabControl = new IViewCustomControls.IViewTabControl();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.ServerSettingsTabPage = new System.Windows.Forms.TabPage();
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.IPPortSettingsBox = new IViewCustomControls.IViewGroupBox();
            this.IPAddressBox = new System.Windows.Forms.TextBox();
            this.IPAddressLabel = new System.Windows.Forms.Label();
            this.PortNumeric = new System.Windows.Forms.NumericUpDown();
            this.PortLabel = new System.Windows.Forms.Label();
            this.ServerConfigBox = new IViewCustomControls.IViewGroupBox();
            this.BrowserBlackListButton = new IViewCustomControls.IViewNormalButton();
            this.BlackListTextBox = new System.Windows.Forms.TextBox();
            this.BlacklistLabel = new System.Windows.Forms.Label();
            this.HeaderSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.HeaderSizeLabel = new System.Windows.Forms.Label();
            this.BufferSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.BufferSizeLabel = new System.Windows.Forms.Label();
            this.MaximumMessageSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaximumMessageSizeLabel = new System.Windows.Forms.Label();
            this.EnableDupIPAddressCheckBox = new System.Windows.Forms.CheckBox();
            this.MaximumConSameIPNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaximumConSameIPLabel = new System.Windows.Forms.Label();
            this.MaximumConNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaximumConLabel = new System.Windows.Forms.Label();
            this.MaximumPendingConNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaximumPendingConLabel = new System.Windows.Forms.Label();
            this.MaximumKeepAliveNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaximumKeepAliveLabel = new System.Windows.Forms.Label();
            this.ClientConfigBox = new IViewCustomControls.IViewGroupBox();
            this.ClientHeaderSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.ClientHeaderSizeLabel = new System.Windows.Forms.Label();
            this.ClientBufferSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.ClientBufferSizeLabel = new System.Windows.Forms.Label();
            this.ClientMaximumMessageSizeNumeric = new System.Windows.Forms.NumericUpDown();
            this.ClientMaximumMessageSizeLabel = new System.Windows.Forms.Label();
            this.HolderPanel = new System.Windows.Forms.Panel();
            this.StartServerButton = new IViewCustomControls.IViewAnimatedButton();
            this.ClientSettingsTabPage = new System.Windows.Forms.TabPage();
            this.ClientTabPage = new System.Windows.Forms.TabPage();
            this.ClientManagerTabPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.ClientStatisticsTabPage = new System.Windows.Forms.TabPage();
            this.ClientMapTabPage = new System.Windows.Forms.TabPage();
            this.BuilderTabPage = new System.Windows.Forms.TabPage();
            this.ClientBuilderTabPage = new System.Windows.Forms.TabPage();
            this.LogsTabPage = new System.Windows.Forms.TabPage();
            this.ServerLoggerTabPage = new System.Windows.Forms.TabPage();
            this.ServerLogView = new IViewCustomControls.IViewListview();
            this.MessageTypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MessageHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeStampHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientLoggerTabPage = new System.Windows.Forms.TabPage();
            this.ClientLogView = new IViewCustomControls.IViewListview();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeaderPanel.SuspendLayout();
            this.GeneralTabControl.SuspendLayout();
            this.ServerSettingsTabPage.SuspendLayout();
            this.LayoutPanel.SuspendLayout();
            this.IPPortSettingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumeric)).BeginInit();
            this.ServerConfigBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BufferSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumMessageSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumConSameIPNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumConNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumPendingConNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumKeepAliveNumeric)).BeginInit();
            this.ClientConfigBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientHeaderSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBufferSizeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientMaximumMessageSizeNumeric)).BeginInit();
            this.HolderPanel.SuspendLayout();
            this.ClientManagerTabPage.SuspendLayout();
            this.ServerLoggerTabPage.SuspendLayout();
            this.ClientLoggerTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1053, 84);
            this.HeaderPanel.TabIndex = 1;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderLabel.Font = new System.Drawing.Font("Verdana", 48F);
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.HeaderLabel.Location = new System.Drawing.Point(104, 3);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(232, 78);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "IVIEW";
            // 
            // GeneralTabControl
            // 
            this.GeneralTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.GeneralTabControl.Controls.Add(this.SettingsTabPage);
            this.GeneralTabControl.Controls.Add(this.ServerSettingsTabPage);
            this.GeneralTabControl.Controls.Add(this.ClientSettingsTabPage);
            this.GeneralTabControl.Controls.Add(this.ClientTabPage);
            this.GeneralTabControl.Controls.Add(this.ClientManagerTabPage);
            this.GeneralTabControl.Controls.Add(this.ClientStatisticsTabPage);
            this.GeneralTabControl.Controls.Add(this.ClientMapTabPage);
            this.GeneralTabControl.Controls.Add(this.BuilderTabPage);
            this.GeneralTabControl.Controls.Add(this.ClientBuilderTabPage);
            this.GeneralTabControl.Controls.Add(this.LogsTabPage);
            this.GeneralTabControl.Controls.Add(this.ServerLoggerTabPage);
            this.GeneralTabControl.Controls.Add(this.ClientLoggerTabPage);
            this.GeneralTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralTabControl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GeneralTabControl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralTabControl.HeaderForeColor = System.Drawing.Color.Gray;
            this.GeneralTabControl.ItemSize = new System.Drawing.Size(40, 250);
            this.GeneralTabControl.Location = new System.Drawing.Point(0, 84);
            this.GeneralTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GeneralTabControl.Multiline = true;
            this.GeneralTabControl.Name = "GeneralTabControl";
            this.GeneralTabControl.OnClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.GeneralTabControl.OnHoverColor = System.Drawing.Color.Gray;
            this.GeneralTabControl.SelectedIndex = 0;
            this.GeneralTabControl.Size = new System.Drawing.Size(1053, 681);
            this.GeneralTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.GeneralTabControl.TabForeColor = System.Drawing.Color.Black;
            this.GeneralTabControl.TabIndex = 0;
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.AutoScroll = true;
            this.SettingsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.SettingsTabPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SettingsTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.SettingsTabPage.Location = new System.Drawing.Point(254, 4);
            this.SettingsTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Size = new System.Drawing.Size(795, 673);
            this.SettingsTabPage.TabIndex = 0;
            this.SettingsTabPage.Tag = "SETTINGS";
            this.SettingsTabPage.Text = "SETTINGS";
            // 
            // ServerSettingsTabPage
            // 
            this.ServerSettingsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ServerSettingsTabPage.Controls.Add(this.LayoutPanel);
            this.ServerSettingsTabPage.Controls.Add(this.HolderPanel);
            this.ServerSettingsTabPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ServerSettingsTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.ServerSettingsTabPage.Location = new System.Drawing.Point(254, 4);
            this.ServerSettingsTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ServerSettingsTabPage.Name = "ServerSettingsTabPage";
            this.ServerSettingsTabPage.Size = new System.Drawing.Size(795, 673);
            this.ServerSettingsTabPage.TabIndex = 1;
            this.ServerSettingsTabPage.Text = "Server Settings";
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.LayoutPanel.ColumnCount = 3;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.6383F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.6383F));
            this.LayoutPanel.Controls.Add(this.IPPortSettingsBox, 1, 1);
            this.LayoutPanel.Controls.Add(this.ServerConfigBox, 1, 2);
            this.LayoutPanel.Controls.Add(this.ClientConfigBox, 1, 3);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 5;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutPanel.Size = new System.Drawing.Size(795, 605);
            this.LayoutPanel.TabIndex = 3;
            // 
            // IPPortSettingsBox
            // 
            this.IPPortSettingsBox.AnimationSpeed = 0;
            this.IPPortSettingsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
            this.IPPortSettingsBox.BorderColor = System.Drawing.Color.White;
            this.IPPortSettingsBox.BoxHeight = 50;
            this.IPPortSettingsBox.Collapse = true;
            this.IPPortSettingsBox.Controls.Add(this.IPAddressBox);
            this.IPPortSettingsBox.Controls.Add(this.IPAddressLabel);
            this.IPPortSettingsBox.Controls.Add(this.PortNumeric);
            this.IPPortSettingsBox.Controls.Add(this.PortLabel);
            this.IPPortSettingsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IPPortSettingsBox.EnableCollapsing = true;
            this.IPPortSettingsBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.IPPortSettingsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            this.IPPortSettingsBox.Location = new System.Drawing.Point(87, 78);
            this.IPPortSettingsBox.Name = "IPPortSettingsBox";
            this.IPPortSettingsBox.Padding = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.IPPortSettingsBox.PreviousHeight = 162;
            this.IPPortSettingsBox.Size = new System.Drawing.Size(619, 162);
            this.IPPortSettingsBox.TabIndex = 1;
            this.IPPortSettingsBox.TabStop = false;
            this.IPPortSettingsBox.Text = "IP And Port Settings";
            // 
            // IPAddressBox
            // 
            this.IPAddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IPAddressBox.Location = new System.Drawing.Point(110, 118);
            this.IPAddressBox.Multiline = true;
            this.IPAddressBox.Name = "IPAddressBox";
            this.IPAddressBox.Size = new System.Drawing.Size(258, 24);
            this.IPAddressBox.TabIndex = 3;
            this.IPAddressBox.Text = "0.0.0.0";
            // 
            // IPAddressLabel
            // 
            this.IPAddressLabel.AutoSize = true;
            this.IPAddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.IPAddressLabel.ForeColor = System.Drawing.Color.Black;
            this.IPAddressLabel.Location = new System.Drawing.Point(9, 121);
            this.IPAddressLabel.Name = "IPAddressLabel";
            this.IPAddressLabel.Size = new System.Drawing.Size(95, 17);
            this.IPAddressLabel.TabIndex = 2;
            this.IPAddressLabel.Text = "IP Address: ";
            // 
            // PortNumeric
            // 
            this.PortNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PortNumeric.Location = new System.Drawing.Point(110, 69);
            this.PortNumeric.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortNumeric.Name = "PortNumeric";
            this.PortNumeric.Size = new System.Drawing.Size(109, 24);
            this.PortNumeric.TabIndex = 1;
            this.PortNumeric.Value = new decimal(new int[] {
            1669,
            0,
            0,
            0});
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.BackColor = System.Drawing.Color.Transparent;
            this.PortLabel.ForeColor = System.Drawing.Color.Black;
            this.PortLabel.Location = new System.Drawing.Point(9, 71);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(43, 17);
            this.PortLabel.TabIndex = 0;
            this.PortLabel.Text = "Port:";
            // 
            // ServerConfigBox
            // 
            this.ServerConfigBox.AnimationSpeed = 0;
            this.ServerConfigBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
            this.ServerConfigBox.BorderColor = System.Drawing.Color.White;
            this.ServerConfigBox.BoxHeight = 50;
            this.ServerConfigBox.Collapse = false;
            this.ServerConfigBox.Controls.Add(this.BrowserBlackListButton);
            this.ServerConfigBox.Controls.Add(this.BlackListTextBox);
            this.ServerConfigBox.Controls.Add(this.BlacklistLabel);
            this.ServerConfigBox.Controls.Add(this.HeaderSizeNumeric);
            this.ServerConfigBox.Controls.Add(this.HeaderSizeLabel);
            this.ServerConfigBox.Controls.Add(this.BufferSizeNumeric);
            this.ServerConfigBox.Controls.Add(this.BufferSizeLabel);
            this.ServerConfigBox.Controls.Add(this.MaximumMessageSizeNumeric);
            this.ServerConfigBox.Controls.Add(this.MaximumMessageSizeLabel);
            this.ServerConfigBox.Controls.Add(this.EnableDupIPAddressCheckBox);
            this.ServerConfigBox.Controls.Add(this.MaximumConSameIPNumeric);
            this.ServerConfigBox.Controls.Add(this.MaximumConSameIPLabel);
            this.ServerConfigBox.Controls.Add(this.MaximumConNumeric);
            this.ServerConfigBox.Controls.Add(this.MaximumConLabel);
            this.ServerConfigBox.Controls.Add(this.MaximumPendingConNumeric);
            this.ServerConfigBox.Controls.Add(this.MaximumPendingConLabel);
            this.ServerConfigBox.Controls.Add(this.MaximumKeepAliveNumeric);
            this.ServerConfigBox.Controls.Add(this.MaximumKeepAliveLabel);
            this.ServerConfigBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServerConfigBox.EnableCollapsing = true;
            this.ServerConfigBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.ServerConfigBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            this.ServerConfigBox.Location = new System.Drawing.Point(87, 246);
            this.ServerConfigBox.Name = "ServerConfigBox";
            this.ServerConfigBox.Padding = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.ServerConfigBox.PreviousHeight = 379;
            this.ServerConfigBox.Size = new System.Drawing.Size(619, 379);
            this.ServerConfigBox.TabIndex = 2;
            this.ServerConfigBox.TabStop = false;
            this.ServerConfigBox.Text = "Server Configuration";
            // 
            // BrowserBlackListButton
            // 
            this.BrowserBlackListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(61)))));
            this.BrowserBlackListButton.FlatAppearance.BorderSize = 0;
            this.BrowserBlackListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowserBlackListButton.ForeColor = System.Drawing.Color.White;
            this.BrowserBlackListButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BrowserBlackListButton.Location = new System.Drawing.Point(576, 339);
            this.BrowserBlackListButton.Name = "BrowserBlackListButton";
            this.BrowserBlackListButton.Size = new System.Drawing.Size(39, 24);
            this.BrowserBlackListButton.TabIndex = 18;
            this.BrowserBlackListButton.TabStop = false;
            this.BrowserBlackListButton.Text = "..";
            this.BrowserBlackListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BrowserBlackListButton.UseVisualStyleBackColor = false;
            // 
            // BlackListTextBox
            // 
            this.BlackListTextBox.Location = new System.Drawing.Point(280, 339);
            this.BlackListTextBox.Name = "BlackListTextBox";
            this.BlackListTextBox.Size = new System.Drawing.Size(290, 24);
            this.BlackListTextBox.TabIndex = 17;
            this.BlackListTextBox.Text = "./Blacklist.txt";
            // 
            // BlacklistLabel
            // 
            this.BlacklistLabel.AutoSize = true;
            this.BlacklistLabel.BackColor = System.Drawing.Color.Transparent;
            this.BlacklistLabel.ForeColor = System.Drawing.Color.Black;
            this.BlacklistLabel.Location = new System.Drawing.Point(9, 342);
            this.BlacklistLabel.Name = "BlacklistLabel";
            this.BlacklistLabel.Size = new System.Drawing.Size(106, 17);
            this.BlacklistLabel.TabIndex = 16;
            this.BlacklistLabel.Text = "Blacklist Path:";
            // 
            // HeaderSizeNumeric
            // 
            this.HeaderSizeNumeric.Location = new System.Drawing.Point(280, 275);
            this.HeaderSizeNumeric.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.HeaderSizeNumeric.Name = "HeaderSizeNumeric";
            this.HeaderSizeNumeric.Size = new System.Drawing.Size(105, 24);
            this.HeaderSizeNumeric.TabIndex = 15;
            this.HeaderSizeNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // HeaderSizeLabel
            // 
            this.HeaderSizeLabel.AutoSize = true;
            this.HeaderSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderSizeLabel.ForeColor = System.Drawing.Color.Black;
            this.HeaderSizeLabel.Location = new System.Drawing.Point(9, 277);
            this.HeaderSizeLabel.Name = "HeaderSizeLabel";
            this.HeaderSizeLabel.Size = new System.Drawing.Size(97, 17);
            this.HeaderSizeLabel.TabIndex = 14;
            this.HeaderSizeLabel.Text = "Header Size:";
            // 
            // BufferSizeNumeric
            // 
            this.BufferSizeNumeric.Location = new System.Drawing.Point(280, 242);
            this.BufferSizeNumeric.Maximum = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            this.BufferSizeNumeric.Name = "BufferSizeNumeric";
            this.BufferSizeNumeric.Size = new System.Drawing.Size(105, 24);
            this.BufferSizeNumeric.TabIndex = 13;
            this.BufferSizeNumeric.Value = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            // 
            // BufferSizeLabel
            // 
            this.BufferSizeLabel.AutoSize = true;
            this.BufferSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.BufferSizeLabel.ForeColor = System.Drawing.Color.Black;
            this.BufferSizeLabel.Location = new System.Drawing.Point(9, 244);
            this.BufferSizeLabel.Name = "BufferSizeLabel";
            this.BufferSizeLabel.Size = new System.Drawing.Size(91, 17);
            this.BufferSizeLabel.TabIndex = 12;
            this.BufferSizeLabel.Text = "Buffer Size:";
            // 
            // MaximumMessageSizeNumeric
            // 
            this.MaximumMessageSizeNumeric.Location = new System.Drawing.Point(280, 210);
            this.MaximumMessageSizeNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.MaximumMessageSizeNumeric.Name = "MaximumMessageSizeNumeric";
            this.MaximumMessageSizeNumeric.Size = new System.Drawing.Size(105, 24);
            this.MaximumMessageSizeNumeric.TabIndex = 11;
            this.MaximumMessageSizeNumeric.Value = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            // 
            // MaximumMessageSizeLabel
            // 
            this.MaximumMessageSizeLabel.AutoSize = true;
            this.MaximumMessageSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaximumMessageSizeLabel.ForeColor = System.Drawing.Color.Black;
            this.MaximumMessageSizeLabel.Location = new System.Drawing.Point(9, 212);
            this.MaximumMessageSizeLabel.Name = "MaximumMessageSizeLabel";
            this.MaximumMessageSizeLabel.Size = new System.Drawing.Size(173, 17);
            this.MaximumMessageSizeLabel.TabIndex = 10;
            this.MaximumMessageSizeLabel.Text = "Maximum Message Size";
            // 
            // EnableDupIPAddressCheckBox
            // 
            this.EnableDupIPAddressCheckBox.AutoSize = true;
            this.EnableDupIPAddressCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.EnableDupIPAddressCheckBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.EnableDupIPAddressCheckBox.ForeColor = System.Drawing.Color.Black;
            this.EnableDupIPAddressCheckBox.Location = new System.Drawing.Point(12, 309);
            this.EnableDupIPAddressCheckBox.Name = "EnableDupIPAddressCheckBox";
            this.EnableDupIPAddressCheckBox.Size = new System.Drawing.Size(239, 21);
            this.EnableDupIPAddressCheckBox.TabIndex = 9;
            this.EnableDupIPAddressCheckBox.Text = "Enable Duplicate IP Addresses";
            this.EnableDupIPAddressCheckBox.UseVisualStyleBackColor = false;
            // 
            // MaximumConSameIPNumeric
            // 
            this.MaximumConSameIPNumeric.Location = new System.Drawing.Point(280, 175);
            this.MaximumConSameIPNumeric.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.MaximumConSameIPNumeric.Name = "MaximumConSameIPNumeric";
            this.MaximumConSameIPNumeric.Size = new System.Drawing.Size(105, 24);
            this.MaximumConSameIPNumeric.TabIndex = 8;
            this.MaximumConSameIPNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // MaximumConSameIPLabel
            // 
            this.MaximumConSameIPLabel.AutoSize = true;
            this.MaximumConSameIPLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaximumConSameIPLabel.ForeColor = System.Drawing.Color.Black;
            this.MaximumConSameIPLabel.Location = new System.Drawing.Point(9, 177);
            this.MaximumConSameIPLabel.Name = "MaximumConSameIPLabel";
            this.MaximumConSameIPLabel.Size = new System.Drawing.Size(234, 17);
            this.MaximumConSameIPLabel.TabIndex = 7;
            this.MaximumConSameIPLabel.Text = "Maximum Connections Same IP:\r\n";
            // 
            // MaximumConNumeric
            // 
            this.MaximumConNumeric.Location = new System.Drawing.Point(280, 143);
            this.MaximumConNumeric.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.MaximumConNumeric.Name = "MaximumConNumeric";
            this.MaximumConNumeric.Size = new System.Drawing.Size(105, 24);
            this.MaximumConNumeric.TabIndex = 6;
            this.MaximumConNumeric.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // MaximumConLabel
            // 
            this.MaximumConLabel.AutoSize = true;
            this.MaximumConLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaximumConLabel.ForeColor = System.Drawing.Color.Black;
            this.MaximumConLabel.Location = new System.Drawing.Point(9, 145);
            this.MaximumConLabel.Name = "MaximumConLabel";
            this.MaximumConLabel.Size = new System.Drawing.Size(172, 17);
            this.MaximumConLabel.TabIndex = 5;
            this.MaximumConLabel.Text = "Maximum Connections:\r\n";
            // 
            // MaximumPendingConNumeric
            // 
            this.MaximumPendingConNumeric.Location = new System.Drawing.Point(280, 107);
            this.MaximumPendingConNumeric.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.MaximumPendingConNumeric.Name = "MaximumPendingConNumeric";
            this.MaximumPendingConNumeric.Size = new System.Drawing.Size(105, 24);
            this.MaximumPendingConNumeric.TabIndex = 4;
            this.MaximumPendingConNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // MaximumPendingConLabel
            // 
            this.MaximumPendingConLabel.AutoSize = true;
            this.MaximumPendingConLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaximumPendingConLabel.ForeColor = System.Drawing.Color.Black;
            this.MaximumPendingConLabel.Location = new System.Drawing.Point(9, 109);
            this.MaximumPendingConLabel.Name = "MaximumPendingConLabel";
            this.MaximumPendingConLabel.Size = new System.Drawing.Size(232, 17);
            this.MaximumPendingConLabel.TabIndex = 3;
            this.MaximumPendingConLabel.Text = "Maximum Pending Connections:\r\n";
            // 
            // MaximumKeepAliveNumeric
            // 
            this.MaximumKeepAliveNumeric.Location = new System.Drawing.Point(280, 67);
            this.MaximumKeepAliveNumeric.Name = "MaximumKeepAliveNumeric";
            this.MaximumKeepAliveNumeric.Size = new System.Drawing.Size(105, 24);
            this.MaximumKeepAliveNumeric.TabIndex = 2;
            this.MaximumKeepAliveNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // MaximumKeepAliveLabel
            // 
            this.MaximumKeepAliveLabel.AutoSize = true;
            this.MaximumKeepAliveLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaximumKeepAliveLabel.ForeColor = System.Drawing.Color.Black;
            this.MaximumKeepAliveLabel.Location = new System.Drawing.Point(9, 69);
            this.MaximumKeepAliveLabel.Name = "MaximumKeepAliveLabel";
            this.MaximumKeepAliveLabel.Size = new System.Drawing.Size(220, 17);
            this.MaximumKeepAliveLabel.TabIndex = 1;
            this.MaximumKeepAliveLabel.Text = "Maximum Keep Alive Interval: ";
            // 
            // ClientConfigBox
            // 
            this.ClientConfigBox.AnimationSpeed = 0;
            this.ClientConfigBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
            this.ClientConfigBox.BorderColor = System.Drawing.Color.White;
            this.ClientConfigBox.BoxHeight = 50;
            this.ClientConfigBox.Collapse = true;
            this.ClientConfigBox.Controls.Add(this.ClientHeaderSizeNumeric);
            this.ClientConfigBox.Controls.Add(this.ClientHeaderSizeLabel);
            this.ClientConfigBox.Controls.Add(this.ClientBufferSizeNumeric);
            this.ClientConfigBox.Controls.Add(this.ClientBufferSizeLabel);
            this.ClientConfigBox.Controls.Add(this.ClientMaximumMessageSizeNumeric);
            this.ClientConfigBox.Controls.Add(this.ClientMaximumMessageSizeLabel);
            this.ClientConfigBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientConfigBox.EnableCollapsing = true;
            this.ClientConfigBox.Font = new System.Drawing.Font("Verdana", 10F);
            this.ClientConfigBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            this.ClientConfigBox.Location = new System.Drawing.Point(87, 631);
            this.ClientConfigBox.Name = "ClientConfigBox";
            this.ClientConfigBox.Padding = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.ClientConfigBox.PreviousHeight = 178;
            this.ClientConfigBox.Size = new System.Drawing.Size(619, 178);
            this.ClientConfigBox.TabIndex = 3;
            this.ClientConfigBox.TabStop = false;
            this.ClientConfigBox.Text = "Client Configuration";
            // 
            // ClientHeaderSizeNumeric
            // 
            this.ClientHeaderSizeNumeric.Location = new System.Drawing.Point(280, 133);
            this.ClientHeaderSizeNumeric.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.ClientHeaderSizeNumeric.Name = "ClientHeaderSizeNumeric";
            this.ClientHeaderSizeNumeric.Size = new System.Drawing.Size(105, 24);
            this.ClientHeaderSizeNumeric.TabIndex = 15;
            this.ClientHeaderSizeNumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // ClientHeaderSizeLabel
            // 
            this.ClientHeaderSizeLabel.AutoSize = true;
            this.ClientHeaderSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClientHeaderSizeLabel.ForeColor = System.Drawing.Color.Black;
            this.ClientHeaderSizeLabel.Location = new System.Drawing.Point(9, 135);
            this.ClientHeaderSizeLabel.Name = "ClientHeaderSizeLabel";
            this.ClientHeaderSizeLabel.Size = new System.Drawing.Size(97, 17);
            this.ClientHeaderSizeLabel.TabIndex = 14;
            this.ClientHeaderSizeLabel.Text = "Header Size:";
            // 
            // ClientBufferSizeNumeric
            // 
            this.ClientBufferSizeNumeric.Location = new System.Drawing.Point(280, 100);
            this.ClientBufferSizeNumeric.Maximum = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            this.ClientBufferSizeNumeric.Name = "ClientBufferSizeNumeric";
            this.ClientBufferSizeNumeric.Size = new System.Drawing.Size(105, 24);
            this.ClientBufferSizeNumeric.TabIndex = 13;
            this.ClientBufferSizeNumeric.Value = new decimal(new int[] {
            16384,
            0,
            0,
            0});
            // 
            // ClientBufferSizeLabel
            // 
            this.ClientBufferSizeLabel.AutoSize = true;
            this.ClientBufferSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClientBufferSizeLabel.ForeColor = System.Drawing.Color.Black;
            this.ClientBufferSizeLabel.Location = new System.Drawing.Point(9, 102);
            this.ClientBufferSizeLabel.Name = "ClientBufferSizeLabel";
            this.ClientBufferSizeLabel.Size = new System.Drawing.Size(91, 17);
            this.ClientBufferSizeLabel.TabIndex = 12;
            this.ClientBufferSizeLabel.Text = "Buffer Size:";
            // 
            // ClientMaximumMessageSizeNumeric
            // 
            this.ClientMaximumMessageSizeNumeric.Location = new System.Drawing.Point(280, 68);
            this.ClientMaximumMessageSizeNumeric.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            this.ClientMaximumMessageSizeNumeric.Name = "ClientMaximumMessageSizeNumeric";
            this.ClientMaximumMessageSizeNumeric.Size = new System.Drawing.Size(105, 24);
            this.ClientMaximumMessageSizeNumeric.TabIndex = 11;
            this.ClientMaximumMessageSizeNumeric.Value = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
            // 
            // ClientMaximumMessageSizeLabel
            // 
            this.ClientMaximumMessageSizeLabel.AutoSize = true;
            this.ClientMaximumMessageSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClientMaximumMessageSizeLabel.ForeColor = System.Drawing.Color.Black;
            this.ClientMaximumMessageSizeLabel.Location = new System.Drawing.Point(9, 70);
            this.ClientMaximumMessageSizeLabel.Name = "ClientMaximumMessageSizeLabel";
            this.ClientMaximumMessageSizeLabel.Size = new System.Drawing.Size(179, 17);
            this.ClientMaximumMessageSizeLabel.TabIndex = 10;
            this.ClientMaximumMessageSizeLabel.Text = "Maximum Message Size:";
            // 
            // HolderPanel
            // 
            this.HolderPanel.BackColor = System.Drawing.Color.DimGray;
            this.HolderPanel.Controls.Add(this.StartServerButton);
            this.HolderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HolderPanel.Location = new System.Drawing.Point(0, 605);
            this.HolderPanel.Name = "HolderPanel";
            this.HolderPanel.Size = new System.Drawing.Size(795, 68);
            this.HolderPanel.TabIndex = 4;
            // 
            // StartServerButton
            // 
            this.StartServerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartServerButton.AnimationColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(69)))));
            this.StartServerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(142)))), ((int)(((byte)(192)))));
            this.StartServerButton.BorderColor = System.Drawing.Color.Red;
            this.StartServerButton.BorderSize = 0F;
            this.StartServerButton.EnableAnimation = true;
            this.StartServerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartServerButton.ForeColor = System.Drawing.Color.White;
            this.StartServerButton.ImageLocation = new System.Drawing.Point(30, 6);
            this.StartServerButton.ImageSize = new System.Drawing.Size(14, 14);
            this.StartServerButton.Location = new System.Drawing.Point(619, 13);
            this.StartServerButton.Name = "StartServerButton";
            this.StartServerButton.OnHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(69)))));
            this.StartServerButton.OnHoverForeColor = System.Drawing.Color.White;
            this.StartServerButton.Size = new System.Drawing.Size(153, 40);
            this.StartServerButton.TabIndex = 0;
            this.StartServerButton.Text = "Start Server";
            this.StartServerButton.UseVisualStyleBackColor = false;
            this.StartServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
            // 
            // ClientSettingsTabPage
            // 
            this.ClientSettingsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSettingsTabPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientSettingsTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.ClientSettingsTabPage.Location = new System.Drawing.Point(254, 4);
            this.ClientSettingsTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClientSettingsTabPage.Name = "ClientSettingsTabPage";
            this.ClientSettingsTabPage.Size = new System.Drawing.Size(795, 673);
            this.ClientSettingsTabPage.TabIndex = 2;
            this.ClientSettingsTabPage.Text = "Client Settings";
            // 
            // ClientTabPage
            // 
            this.ClientTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientTabPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.ClientTabPage.Location = new System.Drawing.Point(254, 4);
            this.ClientTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClientTabPage.Name = "ClientTabPage";
            this.ClientTabPage.Size = new System.Drawing.Size(795, 673);
            this.ClientTabPage.TabIndex = 3;
            this.ClientTabPage.Tag = "CLIENT";
            this.ClientTabPage.Text = "Client";
            // 
            // ClientManagerTabPage
            // 
            this.ClientManagerTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientManagerTabPage.Controls.Add(this.button1);
            this.ClientManagerTabPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientManagerTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.ClientManagerTabPage.Location = new System.Drawing.Point(254, 4);
            this.ClientManagerTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClientManagerTabPage.Name = "ClientManagerTabPage";
            this.ClientManagerTabPage.Size = new System.Drawing.Size(795, 673);
            this.ClientManagerTabPage.TabIndex = 4;
            this.ClientManagerTabPage.Text = "Client Manager";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientStatisticsTabPage
            // 
            this.ClientStatisticsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientStatisticsTabPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientStatisticsTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.ClientStatisticsTabPage.Location = new System.Drawing.Point(254, 4);
            this.ClientStatisticsTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClientStatisticsTabPage.Name = "ClientStatisticsTabPage";
            this.ClientStatisticsTabPage.Size = new System.Drawing.Size(795, 673);
            this.ClientStatisticsTabPage.TabIndex = 5;
            this.ClientStatisticsTabPage.Text = "Client Statistics";
            // 
            // ClientMapTabPage
            // 
            this.ClientMapTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientMapTabPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientMapTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.ClientMapTabPage.Location = new System.Drawing.Point(254, 4);
            this.ClientMapTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClientMapTabPage.Name = "ClientMapTabPage";
            this.ClientMapTabPage.Size = new System.Drawing.Size(795, 673);
            this.ClientMapTabPage.TabIndex = 6;
            this.ClientMapTabPage.Text = "Client Map";
            // 
            // BuilderTabPage
            // 
            this.BuilderTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.BuilderTabPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BuilderTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.BuilderTabPage.Location = new System.Drawing.Point(254, 4);
            this.BuilderTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BuilderTabPage.Name = "BuilderTabPage";
            this.BuilderTabPage.Size = new System.Drawing.Size(795, 673);
            this.BuilderTabPage.TabIndex = 7;
            this.BuilderTabPage.Tag = "BUILDER";
            this.BuilderTabPage.Text = "BUILDER";
            // 
            // ClientBuilderTabPage
            // 
            this.ClientBuilderTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientBuilderTabPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientBuilderTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.ClientBuilderTabPage.Location = new System.Drawing.Point(254, 4);
            this.ClientBuilderTabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ClientBuilderTabPage.Name = "ClientBuilderTabPage";
            this.ClientBuilderTabPage.Size = new System.Drawing.Size(795, 673);
            this.ClientBuilderTabPage.TabIndex = 8;
            this.ClientBuilderTabPage.Text = "Client Builder";
            // 
            // LogsTabPage
            // 
            this.LogsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.LogsTabPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LogsTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.LogsTabPage.Location = new System.Drawing.Point(254, 4);
            this.LogsTabPage.Name = "LogsTabPage";
            this.LogsTabPage.Size = new System.Drawing.Size(795, 673);
            this.LogsTabPage.TabIndex = 9;
            this.LogsTabPage.Tag = "LOGS";
            this.LogsTabPage.Text = "LOGS";
            // 
            // ServerLoggerTabPage
            // 
            this.ServerLoggerTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ServerLoggerTabPage.Controls.Add(this.ServerLogView);
            this.ServerLoggerTabPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ServerLoggerTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.ServerLoggerTabPage.Location = new System.Drawing.Point(254, 4);
            this.ServerLoggerTabPage.Name = "ServerLoggerTabPage";
            this.ServerLoggerTabPage.Size = new System.Drawing.Size(795, 673);
            this.ServerLoggerTabPage.TabIndex = 10;
            this.ServerLoggerTabPage.Text = "Server Log";
            // 
            // ServerLogView
            // 
            this.ServerLogView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerLogView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MessageTypeHeader,
            this.MessageHeader,
            this.TimeStampHeader});
            this.ServerLogView.Font = new System.Drawing.Font("Verdana", 9F);
            this.ServerLogView.ForeColor = System.Drawing.Color.Black;
            this.ServerLogView.FullRowSelect = true;
            this.ServerLogView.HideSelection = false;
            this.ServerLogView.Location = new System.Drawing.Point(35, 37);
            this.ServerLogView.Name = "ServerLogView";
            this.ServerLogView.Size = new System.Drawing.Size(720, 595);
            this.ServerLogView.TabIndex = 0;
            this.ServerLogView.UseCompatibleStateImageBehavior = false;
            this.ServerLogView.View = System.Windows.Forms.View.Details;
            // 
            // MessageTypeHeader
            // 
            this.MessageTypeHeader.Text = "MessageType";
            this.MessageTypeHeader.Width = 151;
            // 
            // MessageHeader
            // 
            this.MessageHeader.Text = "Message";
            this.MessageHeader.Width = 100;
            // 
            // TimeStampHeader
            // 
            this.TimeStampHeader.Text = "TimeStamp";
            this.TimeStampHeader.Width = 100;
            // 
            // ClientLoggerTabPage
            // 
            this.ClientLoggerTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientLoggerTabPage.Controls.Add(this.ClientLogView);
            this.ClientLoggerTabPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ClientLoggerTabPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.ClientLoggerTabPage.Location = new System.Drawing.Point(254, 4);
            this.ClientLoggerTabPage.Name = "ClientLoggerTabPage";
            this.ClientLoggerTabPage.Size = new System.Drawing.Size(795, 673);
            this.ClientLoggerTabPage.TabIndex = 11;
            this.ClientLoggerTabPage.Text = "Client Log";
            // 
            // ClientLogView
            // 
            this.ClientLogView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientLogView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ClientLogView.Font = new System.Drawing.Font("Verdana", 9F);
            this.ClientLogView.ForeColor = System.Drawing.Color.Black;
            this.ClientLogView.FullRowSelect = true;
            this.ClientLogView.HideSelection = false;
            this.ClientLogView.Location = new System.Drawing.Point(35, 37);
            this.ClientLogView.Name = "ClientLogView";
            this.ClientLogView.Size = new System.Drawing.Size(720, 595);
            this.ClientLogView.TabIndex = 1;
            this.ClientLogView.UseCompatibleStateImageBehavior = false;
            this.ClientLogView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MessageType";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Message";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TimeStamp";
            this.columnHeader3.Width = 100;
            // 
            // IViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 765);
            this.Controls.Add(this.GeneralTabControl);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "IViewMain";
            this.Text = "IView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IViewMain_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.GeneralTabControl.ResumeLayout(false);
            this.ServerSettingsTabPage.ResumeLayout(false);
            this.LayoutPanel.ResumeLayout(false);
            this.IPPortSettingsBox.ResumeLayout(false);
            this.IPPortSettingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumeric)).EndInit();
            this.ServerConfigBox.ResumeLayout(false);
            this.ServerConfigBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BufferSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumMessageSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumConSameIPNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumConNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumPendingConNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumKeepAliveNumeric)).EndInit();
            this.ClientConfigBox.ResumeLayout(false);
            this.ClientConfigBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientHeaderSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientBufferSizeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientMaximumMessageSizeNumeric)).EndInit();
            this.HolderPanel.ResumeLayout(false);
            this.ClientManagerTabPage.ResumeLayout(false);
            this.ServerLoggerTabPage.ResumeLayout(false);
            this.ClientLoggerTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private IViewCustomControls.IViewTabControl GeneralTabControl;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private System.Windows.Forms.TabPage ServerSettingsTabPage;
        private System.Windows.Forms.TabPage ClientSettingsTabPage;
        private System.Windows.Forms.TabPage ClientTabPage;
        private System.Windows.Forms.TabPage ClientManagerTabPage;
        private System.Windows.Forms.TabPage ClientStatisticsTabPage;
        private System.Windows.Forms.TabPage ClientMapTabPage;
        private System.Windows.Forms.TabPage BuilderTabPage;
        private System.Windows.Forms.TabPage ClientBuilderTabPage;
        private System.Windows.Forms.Label HeaderLabel;
        private IViewCustomControls.IViewAnimatedButton StartServerButton;
        private IViewCustomControls.IViewGroupBox IPPortSettingsBox;
        private System.Windows.Forms.TextBox IPAddressBox;
        private System.Windows.Forms.Label IPAddressLabel;
        private System.Windows.Forms.NumericUpDown PortNumeric;
        private System.Windows.Forms.Label PortLabel;
        private IViewCustomControls.IViewGroupBox ServerConfigBox;
        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private System.Windows.Forms.NumericUpDown MaximumConSameIPNumeric;
        private System.Windows.Forms.Label MaximumConSameIPLabel;
        private System.Windows.Forms.NumericUpDown MaximumConNumeric;
        private System.Windows.Forms.Label MaximumConLabel;
        private System.Windows.Forms.NumericUpDown MaximumPendingConNumeric;
        private System.Windows.Forms.Label MaximumPendingConLabel;
        private System.Windows.Forms.NumericUpDown MaximumKeepAliveNumeric;
        private System.Windows.Forms.Label MaximumKeepAliveLabel;
        private System.Windows.Forms.NumericUpDown HeaderSizeNumeric;
        private System.Windows.Forms.Label HeaderSizeLabel;
        private System.Windows.Forms.NumericUpDown BufferSizeNumeric;
        private System.Windows.Forms.Label BufferSizeLabel;
        private System.Windows.Forms.NumericUpDown MaximumMessageSizeNumeric;
        private System.Windows.Forms.Label MaximumMessageSizeLabel;
        private System.Windows.Forms.CheckBox EnableDupIPAddressCheckBox;
        private IViewCustomControls.IViewNormalButton BrowserBlackListButton;
        private System.Windows.Forms.TextBox BlackListTextBox;
        private System.Windows.Forms.Label BlacklistLabel;
        private IViewCustomControls.IViewGroupBox ClientConfigBox;
        private System.Windows.Forms.NumericUpDown ClientHeaderSizeNumeric;
        private System.Windows.Forms.Label ClientHeaderSizeLabel;
        private System.Windows.Forms.NumericUpDown ClientBufferSizeNumeric;
        private System.Windows.Forms.Label ClientBufferSizeLabel;
        private System.Windows.Forms.NumericUpDown ClientMaximumMessageSizeNumeric;
        private System.Windows.Forms.Label ClientMaximumMessageSizeLabel;
        private System.Windows.Forms.Panel HolderPanel;
        private System.Windows.Forms.TabPage LogsTabPage;
        private System.Windows.Forms.TabPage ServerLoggerTabPage;
        private IViewCustomControls.IViewListview ServerLogView;
        private System.Windows.Forms.ColumnHeader MessageTypeHeader;
        private System.Windows.Forms.ColumnHeader MessageHeader;
        private System.Windows.Forms.ColumnHeader TimeStampHeader;
        private System.Windows.Forms.TabPage ClientLoggerTabPage;
        private IViewCustomControls.IViewListview ClientLogView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button1;
    }
}