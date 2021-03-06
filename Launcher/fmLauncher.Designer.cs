﻿namespace Launcher
{
    partial class fmLauncher
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLauncher));
            this.cboApps = new System.Windows.Forms.ComboBox();
            this.lblApp = new System.Windows.Forms.Label();
            this.btnAddListEntry = new System.Windows.Forms.Button();
            this.btnDeleteListEntry = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grdLaunch = new System.Windows.Forms.DataGridView();
            this.btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.conObjects = new System.Windows.Forms.SplitContainer();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnOpenConfig = new System.Windows.Forms.Button();
            this.rdoNothingOption = new System.Windows.Forms.RadioButton();
            this.rdoMinimizeOption = new System.Windows.Forms.RadioButton();
            this.rdoCloseOption = new System.Windows.Forms.RadioButton();
            this.lblConfigFile = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpExport = new System.Windows.Forms.GroupBox();
            this.btnCsvExport = new System.Windows.Forms.Button();
            this.grpDevParameters = new System.Windows.Forms.GroupBox();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.chkSession = new System.Windows.Forms.CheckBox();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.chkAction = new System.Windows.Forms.CheckBox();
            this.grpBasicParameters = new System.Windows.Forms.GroupBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEndpoint = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtHttp = new System.Windows.Forms.TextBox();
            this.dlgFileSave = new System.Windows.Forms.SaveFileDialog();
            this.nfyTrayMinimize = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuAssocApps = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nameTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endpointUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endpointPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debugDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.debugActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debugSessionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svcSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdLaunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conObjects)).BeginInit();
            this.conObjects.Panel1.SuspendLayout();
            this.conObjects.Panel2.SuspendLayout();
            this.conObjects.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpExport.SuspendLayout();
            this.grpDevParameters.SuspendLayout();
            this.grpBasicParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svcSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboApps
            // 
            this.cboApps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboApps.FormattingEnabled = true;
            this.cboApps.Items.AddRange(new object[] {
            "S2d_v2",
            "DqmClient"});
            this.cboApps.Location = new System.Drawing.Point(6, 32);
            this.cboApps.Name = "cboApps";
            this.cboApps.Size = new System.Drawing.Size(121, 21);
            this.cboApps.TabIndex = 5;
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Location = new System.Drawing.Point(3, 16);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(70, 13);
            this.lblApp.TabIndex = 2;
            this.lblApp.Text = "Za aplikaciju:";
            // 
            // btnAddListEntry
            // 
            this.btnAddListEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddListEntry.Image = global::Launcher.Properties.Resources.Add;
            this.btnAddListEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddListEntry.Location = new System.Drawing.Point(6, 170);
            this.btnAddListEntry.Name = "btnAddListEntry";
            this.btnAddListEntry.Size = new System.Drawing.Size(97, 23);
            this.btnAddListEntry.TabIndex = 60;
            this.btnAddListEntry.Text = "Dodaj";
            this.btnAddListEntry.UseVisualStyleBackColor = true;
            this.btnAddListEntry.Click += new System.EventHandler(this.btnAddListEntry_Click);
            // 
            // btnDeleteListEntry
            // 
            this.btnDeleteListEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteListEntry.Image = global::Launcher.Properties.Resources.Delete;
            this.btnDeleteListEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteListEntry.Location = new System.Drawing.Point(229, 170);
            this.btnDeleteListEntry.Name = "btnDeleteListEntry";
            this.btnDeleteListEntry.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteListEntry.TabIndex = 65;
            this.btnDeleteListEntry.Text = "Obriši";
            this.btnDeleteListEntry.UseVisualStyleBackColor = true;
            this.btnDeleteListEntry.Click += new System.EventHandler(this.btnDeleteListEntry_Click);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(133, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 20);
            this.txtName.TabIndex = 10;
            this.txtName.Text = "test";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(130, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(27, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ime:";
            // 
            // grdLaunch
            // 
            this.grdLaunch.AllowUserToAddRows = false;
            this.grdLaunch.AllowUserToDeleteRows = false;
            this.grdLaunch.AllowUserToResizeColumns = false;
            this.grdLaunch.AllowUserToResizeRows = false;
            this.grdLaunch.AutoGenerateColumns = false;
            this.grdLaunch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdLaunch.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdLaunch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.grdLaunch.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.grdLaunch.ColumnHeadersHeight = 18;
            this.grdLaunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdLaunch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn,
            this.nameTextDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.endpointUrlDataGridViewTextBoxColumn,
            this.endpointPortDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.debugDataGridViewCheckBoxColumn,
            this.debugActionDataGridViewTextBoxColumn,
            this.debugSessionIdDataGridViewTextBoxColumn});
            this.grdLaunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdLaunch.DataSource = this.svcSettingsBindingSource;
            this.grdLaunch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdLaunch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.grdLaunch.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdLaunch.Location = new System.Drawing.Point(0, 0);
            this.grdLaunch.MultiSelect = false;
            this.grdLaunch.Name = "grdLaunch";
            this.grdLaunch.RowHeadersVisible = false;
            this.grdLaunch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grdLaunch.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdLaunch.RowTemplate.DividerHeight = 3;
            this.grdLaunch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdLaunch.Size = new System.Drawing.Size(937, 369);
            this.grdLaunch.TabIndex = 0;
            this.grdLaunch.TabStop = false;
            this.grdLaunch.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grdLaunch_CellBeginEdit);
            this.grdLaunch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLaunch_CellClick);
            this.grdLaunch.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLaunch_CellEndEdit);
            this.grdLaunch.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLaunch_CellEnter);
            // 
            // btn
            // 
            this.btn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btn.DividerWidth = 10;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn.Frozen = true;
            this.btn.HeaderText = "Run";
            this.btn.MinimumWidth = 60;
            this.btn.Name = "btn";
            this.btn.ReadOnly = true;
            this.btn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btn.Text = "Pokreni";
            this.btn.ToolTipText = "Pokretanje aplikacije sa zadanim parametrima.";
            this.btn.UseColumnTextForButtonValue = true;
            this.btn.Width = 60;
            // 
            // conObjects
            // 
            this.conObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conObjects.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.conObjects.IsSplitterFixed = true;
            this.conObjects.Location = new System.Drawing.Point(1, 2);
            this.conObjects.Name = "conObjects";
            this.conObjects.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // conObjects.Panel1
            // 
            this.conObjects.Panel1.Controls.Add(this.grdLaunch);
            // 
            // conObjects.Panel2
            // 
            this.conObjects.Panel2.Controls.Add(this.grpOptions);
            this.conObjects.Panel2.Controls.Add(this.btnExit);
            this.conObjects.Panel2.Controls.Add(this.grpExport);
            this.conObjects.Panel2.Controls.Add(this.grpDevParameters);
            this.conObjects.Panel2.Controls.Add(this.grpBasicParameters);
            this.conObjects.Size = new System.Drawing.Size(937, 581);
            this.conObjects.SplitterDistance = 369;
            this.conObjects.TabIndex = 6;
            this.conObjects.TabStop = false;
            // 
            // grpOptions
            // 
            this.grpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptions.Controls.Add(this.btnOpenFolder);
            this.grpOptions.Controls.Add(this.btnOpenConfig);
            this.grpOptions.Controls.Add(this.rdoNothingOption);
            this.grpOptions.Controls.Add(this.rdoMinimizeOption);
            this.grpOptions.Controls.Add(this.rdoCloseOption);
            this.grpOptions.Controls.Add(this.lblConfigFile);
            this.grpOptions.Location = new System.Drawing.Point(530, 8);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(276, 197);
            this.grpOptions.TabIndex = 20;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Opcije";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenFolder.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOpenFolder.Image = global::Launcher.Properties.Resources.Folder;
            this.btnOpenFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFolder.Location = new System.Drawing.Point(140, 170);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(130, 23);
            this.btnOpenFolder.TabIndex = 31;
            this.btnOpenFolder.Text = "Otvori folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnOpenConfig
            // 
            this.btnOpenConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOpenConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenConfig.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOpenConfig.Image = global::Launcher.Properties.Resources.File;
            this.btnOpenConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenConfig.Location = new System.Drawing.Point(6, 170);
            this.btnOpenConfig.Name = "btnOpenConfig";
            this.btnOpenConfig.Size = new System.Drawing.Size(130, 23);
            this.btnOpenConfig.TabIndex = 31;
            this.btnOpenConfig.Text = "Otvori datoteku";
            this.btnOpenConfig.UseVisualStyleBackColor = true;
            this.btnOpenConfig.Click += new System.EventHandler(this.btnOpenConfig_Click);
            // 
            // rdoNothingOption
            // 
            this.rdoNothingOption.AutoSize = true;
            this.rdoNothingOption.ForeColor = System.Drawing.SystemColors.Window;
            this.rdoNothingOption.Location = new System.Drawing.Point(6, 66);
            this.rdoNothingOption.Name = "rdoNothingOption";
            this.rdoNothingOption.Size = new System.Drawing.Size(121, 17);
            this.rdoNothingOption.TabIndex = 30;
            this.rdoNothingOption.Text = "Ništa od navedenog";
            this.rdoNothingOption.UseVisualStyleBackColor = true;
            this.rdoNothingOption.CheckedChanged += new System.EventHandler(this.rdoCloseOption_CheckedChanged);
            // 
            // rdoMinimizeOption
            // 
            this.rdoMinimizeOption.AutoSize = true;
            this.rdoMinimizeOption.ForeColor = System.Drawing.SystemColors.Window;
            this.rdoMinimizeOption.Location = new System.Drawing.Point(6, 42);
            this.rdoMinimizeOption.Name = "rdoMinimizeOption";
            this.rdoMinimizeOption.Size = new System.Drawing.Size(253, 17);
            this.rdoMinimizeOption.TabIndex = 20;
            this.rdoMinimizeOption.Text = "MINIMIZE \"Launcher\" kod pokretanja aplikacije";
            this.rdoMinimizeOption.UseVisualStyleBackColor = true;
            this.rdoMinimizeOption.CheckedChanged += new System.EventHandler(this.rdoCloseOption_CheckedChanged);
            // 
            // rdoCloseOption
            // 
            this.rdoCloseOption.AutoSize = true;
            this.rdoCloseOption.ForeColor = System.Drawing.SystemColors.Window;
            this.rdoCloseOption.Location = new System.Drawing.Point(6, 19);
            this.rdoCloseOption.Name = "rdoCloseOption";
            this.rdoCloseOption.Size = new System.Drawing.Size(239, 17);
            this.rdoCloseOption.TabIndex = 10;
            this.rdoCloseOption.Text = "CLOSE \"Launcher\" kod pokretanja aplikacije";
            this.rdoCloseOption.UseVisualStyleBackColor = true;
            this.rdoCloseOption.CheckedChanged += new System.EventHandler(this.rdoCloseOption_CheckedChanged);
            // 
            // lblConfigFile
            // 
            this.lblConfigFile.AutoSize = true;
            this.lblConfigFile.ForeColor = System.Drawing.SystemColors.Window;
            this.lblConfigFile.Location = new System.Drawing.Point(6, 154);
            this.lblConfigFile.Name = "lblConfigFile";
            this.lblConfigFile.Size = new System.Drawing.Size(92, 13);
            this.lblConfigFile.TabIndex = 56;
            this.lblConfigFile.Text = "CONFIG datoteka";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Image = global::Launcher.Properties.Resources.Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(812, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 191);
            this.btnExit.TabIndex = 100;
            this.btnExit.Text = "Izlaz";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpExport
            // 
            this.grpExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpExport.Controls.Add(this.btnCsvExport);
            this.grpExport.Location = new System.Drawing.Point(341, 157);
            this.grpExport.Name = "grpExport";
            this.grpExport.Size = new System.Drawing.Size(183, 48);
            this.grpExport.TabIndex = 20;
            this.grpExport.TabStop = false;
            this.grpExport.Text = "Export liste";
            // 
            // btnCsvExport
            // 
            this.btnCsvExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCsvExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCsvExport.Image = global::Launcher.Properties.Resources.Csv;
            this.btnCsvExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCsvExport.Location = new System.Drawing.Point(6, 21);
            this.btnCsvExport.Name = "btnCsvExport";
            this.btnCsvExport.Size = new System.Drawing.Size(171, 23);
            this.btnCsvExport.TabIndex = 95;
            this.btnCsvExport.Text = "CSV format";
            this.btnCsvExport.UseVisualStyleBackColor = true;
            this.btnCsvExport.Click += new System.EventHandler(this.btnCsvExport_Click);
            // 
            // grpDevParameters
            // 
            this.grpDevParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDevParameters.Controls.Add(this.chkDebug);
            this.grpDevParameters.Controls.Add(this.txtSession);
            this.grpDevParameters.Controls.Add(this.chkSession);
            this.grpDevParameters.Controls.Add(this.txtAction);
            this.grpDevParameters.Controls.Add(this.chkAction);
            this.grpDevParameters.Location = new System.Drawing.Point(341, 8);
            this.grpDevParameters.Name = "grpDevParameters";
            this.grpDevParameters.Size = new System.Drawing.Size(183, 143);
            this.grpDevParameters.TabIndex = 0;
            this.grpDevParameters.TabStop = false;
            this.grpDevParameters.Text = "Developer Parametri (Opcionalno)";
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkDebug.Location = new System.Drawing.Point(6, 60);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(54, 17);
            this.chkDebug.TabIndex = 0;
            this.chkDebug.Text = "debug";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // txtSession
            // 
            this.txtSession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSession.Location = new System.Drawing.Point(73, 110);
            this.txtSession.Name = "txtSession";
            this.txtSession.ReadOnly = true;
            this.txtSession.Size = new System.Drawing.Size(104, 20);
            this.txtSession.TabIndex = 90;
            // 
            // chkSession
            // 
            this.chkSession.AutoSize = true;
            this.chkSession.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkSession.Location = new System.Drawing.Point(6, 112);
            this.chkSession.Name = "chkSession";
            this.chkSession.Size = new System.Drawing.Size(59, 17);
            this.chkSession.TabIndex = 85;
            this.chkSession.Text = "session";
            this.chkSession.UseVisualStyleBackColor = true;
            this.chkSession.CheckedChanged += new System.EventHandler(this.chkSession_CheckedChanged);
            // 
            // txtAction
            // 
            this.txtAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAction.Location = new System.Drawing.Point(73, 84);
            this.txtAction.Name = "txtAction";
            this.txtAction.ReadOnly = true;
            this.txtAction.Size = new System.Drawing.Size(104, 20);
            this.txtAction.TabIndex = 80;
            // 
            // chkAction
            // 
            this.chkAction.AutoSize = true;
            this.chkAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkAction.Location = new System.Drawing.Point(6, 86);
            this.chkAction.Name = "chkAction";
            this.chkAction.Size = new System.Drawing.Size(53, 17);
            this.chkAction.TabIndex = 75;
            this.chkAction.Text = "action";
            this.chkAction.UseVisualStyleBackColor = true;
            this.chkAction.CheckedChanged += new System.EventHandler(this.chkAction_CheckedChanged);
            // 
            // grpBasicParameters
            // 
            this.grpBasicParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpBasicParameters.Controls.Add(this.txtUrl);
            this.grpBasicParameters.Controls.Add(this.lblPassword);
            this.grpBasicParameters.Controls.Add(this.lblName);
            this.grpBasicParameters.Controls.Add(this.txtName);
            this.grpBasicParameters.Controls.Add(this.lblApp);
            this.grpBasicParameters.Controls.Add(this.btnDeleteListEntry);
            this.grpBasicParameters.Controls.Add(this.btnAddListEntry);
            this.grpBasicParameters.Controls.Add(this.lblUsername);
            this.grpBasicParameters.Controls.Add(this.cboApps);
            this.grpBasicParameters.Controls.Add(this.lblEndpoint);
            this.grpBasicParameters.Controls.Add(this.lblPort);
            this.grpBasicParameters.Controls.Add(this.txtPassword);
            this.grpBasicParameters.Controls.Add(this.txtUsername);
            this.grpBasicParameters.Controls.Add(this.txtPort);
            this.grpBasicParameters.Controls.Add(this.txtHttp);
            this.grpBasicParameters.Location = new System.Drawing.Point(3, 8);
            this.grpBasicParameters.Name = "grpBasicParameters";
            this.grpBasicParameters.Size = new System.Drawing.Size(332, 197);
            this.grpBasicParameters.TabIndex = 1;
            this.grpBasicParameters.TabStop = false;
            this.grpBasicParameters.Text = "Osnovni Parametri (Obavezno)";
            // 
            // txtUrl
            // 
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrl.Location = new System.Drawing.Point(135, 59);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(103, 20);
            this.txtUrl.TabIndex = 35;
            this.txtUrl.Text = "192.168.111.122";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 113);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(52, 13);
            this.lblPassword.TabIndex = 56;
            this.lblPassword.Text = "password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 87);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 13);
            this.lblUsername.TabIndex = 56;
            this.lblUsername.Text = "username";
            // 
            // lblEndpoint
            // 
            this.lblEndpoint.AutoSize = true;
            this.lblEndpoint.Location = new System.Drawing.Point(6, 61);
            this.lblEndpoint.Name = "lblEndpoint";
            this.lblEndpoint.Size = new System.Drawing.Size(79, 13);
            this.lblEndpoint.TabIndex = 56;
            this.lblEndpoint.Text = "endpoint (URL)";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(244, 61);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(28, 13);
            this.lblPort.TabIndex = 2;
            this.lblPort.Text = "port:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(91, 110);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(235, 20);
            this.txtPassword.TabIndex = 50;
            this.txtPassword.Text = "i";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(91, 84);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(235, 20);
            this.txtUsername.TabIndex = 45;
            this.txtUsername.Text = "inin";
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Location = new System.Drawing.Point(278, 58);
            this.txtPort.MaxLength = 8;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(48, 20);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "99";
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // txtHttp
            // 
            this.txtHttp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHttp.Location = new System.Drawing.Point(91, 59);
            this.txtHttp.Name = "txtHttp";
            this.txtHttp.ReadOnly = true;
            this.txtHttp.Size = new System.Drawing.Size(38, 20);
            this.txtHttp.TabIndex = 30;
            this.txtHttp.TabStop = false;
            this.txtHttp.Text = "http://";
            // 
            // nfyTrayMinimize
            // 
            this.nfyTrayMinimize.BalloonTipText = "Bilo je tamo, sad je ovdje.";
            this.nfyTrayMinimize.BalloonTipTitle = "Gle!";
            this.nfyTrayMinimize.Icon = ((System.Drawing.Icon)(resources.GetObject("nfyTrayMinimize.Icon")));
            this.nfyTrayMinimize.Text = "Minimized to tray";
            this.nfyTrayMinimize.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nfyTrayMinimize_MouseDoubleClick);
            // 
            // mnuAssocApps
            // 
            this.mnuAssocApps.Name = "contextMenuStrip1";
            this.mnuAssocApps.Size = new System.Drawing.Size(61, 4);
            this.mnuAssocApps.Opening += new System.ComponentModel.CancelEventHandler(this.mnuAssocApps_Opening);
            this.mnuAssocApps.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuAssocApps_ItemClicked);
            // 
            // nameTextDataGridViewTextBoxColumn
            // 
            this.nameTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameTextDataGridViewTextBoxColumn.DataPropertyName = "NameText";
            this.nameTextDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.nameTextDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.nameTextDataGridViewTextBoxColumn.Name = "nameTextDataGridViewTextBoxColumn";
            this.nameTextDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Aplikacija";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameDataGridViewTextBoxColumn.Width = 77;
            // 
            // endpointUrlDataGridViewTextBoxColumn
            // 
            this.endpointUrlDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.endpointUrlDataGridViewTextBoxColumn.DataPropertyName = "EndpointUrl";
            this.endpointUrlDataGridViewTextBoxColumn.HeaderText = "EndpointUrl";
            this.endpointUrlDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.endpointUrlDataGridViewTextBoxColumn.Name = "endpointUrlDataGridViewTextBoxColumn";
            this.endpointUrlDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.endpointUrlDataGridViewTextBoxColumn.Width = 87;
            // 
            // endpointPortDataGridViewTextBoxColumn
            // 
            this.endpointPortDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.endpointPortDataGridViewTextBoxColumn.DataPropertyName = "EndpointPort";
            this.endpointPortDataGridViewTextBoxColumn.HeaderText = "Port";
            this.endpointPortDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.endpointPortDataGridViewTextBoxColumn.Name = "endpointPortDataGridViewTextBoxColumn";
            this.endpointPortDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.endpointPortDataGridViewTextBoxColumn.Width = 51;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.usernameDataGridViewTextBoxColumn.Width = 80;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.passwordDataGridViewTextBoxColumn.Width = 78;
            // 
            // debugDataGridViewCheckBoxColumn
            // 
            this.debugDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.debugDataGridViewCheckBoxColumn.DataPropertyName = "Debug";
            this.debugDataGridViewCheckBoxColumn.HeaderText = "Debug";
            this.debugDataGridViewCheckBoxColumn.Name = "debugDataGridViewCheckBoxColumn";
            this.debugDataGridViewCheckBoxColumn.ReadOnly = true;
            this.debugDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.debugDataGridViewCheckBoxColumn.Width = 45;
            // 
            // debugActionDataGridViewTextBoxColumn
            // 
            this.debugActionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.debugActionDataGridViewTextBoxColumn.DataPropertyName = "DebugAction";
            this.debugActionDataGridViewTextBoxColumn.HeaderText = "DebugAction";
            this.debugActionDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.debugActionDataGridViewTextBoxColumn.Name = "debugActionDataGridViewTextBoxColumn";
            this.debugActionDataGridViewTextBoxColumn.ReadOnly = true;
            this.debugActionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.debugActionDataGridViewTextBoxColumn.Width = 94;
            // 
            // debugSessionIdDataGridViewTextBoxColumn
            // 
            this.debugSessionIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.debugSessionIdDataGridViewTextBoxColumn.DataPropertyName = "DebugSessionId";
            this.debugSessionIdDataGridViewTextBoxColumn.HeaderText = "DebugSessionId";
            this.debugSessionIdDataGridViewTextBoxColumn.MinimumWidth = 40;
            this.debugSessionIdDataGridViewTextBoxColumn.Name = "debugSessionIdDataGridViewTextBoxColumn";
            this.debugSessionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.debugSessionIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.debugSessionIdDataGridViewTextBoxColumn.Width = 110;
            // 
            // svcSettingsBindingSource
            // 
            this.svcSettingsBindingSource.DataSource = typeof(Launcher.Models.SvcSettings);
            // 
            // fmLauncher
            // 
            this.AcceptButton = this.btnAddListEntry;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(940, 584);
            this.Controls.Add(this.conObjects);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmLauncher";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S2D/DQM Launcher";
            this.Load += new System.EventHandler(this.fmLauncher_Load);
            this.Resize += new System.EventHandler(this.fmLauncher_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grdLaunch)).EndInit();
            this.conObjects.Panel1.ResumeLayout(false);
            this.conObjects.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conObjects)).EndInit();
            this.conObjects.ResumeLayout(false);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpExport.ResumeLayout(false);
            this.grpDevParameters.ResumeLayout(false);
            this.grpDevParameters.PerformLayout();
            this.grpBasicParameters.ResumeLayout(false);
            this.grpBasicParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svcSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Button btnAddListEntry;
        private System.Windows.Forms.Button btnDeleteListEntry;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.SplitContainer conObjects;
        private System.Windows.Forms.GroupBox grpBasicParameters;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox grpDevParameters;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.CheckBox chkSession;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.CheckBox chkAction;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.CheckBox chkDebug;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEndpoint;
        private System.Windows.Forms.TextBox txtHttp;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.GroupBox grpExport;
        private System.Windows.Forms.Button btnCsvExport;
        private System.Windows.Forms.ComboBox cboApps;
        private System.Windows.Forms.BindingSource svcSettingsBindingSource;
        private System.Windows.Forms.SaveFileDialog dlgFileSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.DataGridView grdLaunch;
        private System.Windows.Forms.RadioButton rdoMinimizeOption;
        private System.Windows.Forms.RadioButton rdoCloseOption;
        private System.Windows.Forms.RadioButton rdoNothingOption;
        private System.Windows.Forms.DataGridViewButtonColumn btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endpointUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endpointPortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn debugDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debugActionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debugSessionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.NotifyIcon nfyTrayMinimize;
        private System.Windows.Forms.Button btnOpenConfig;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label lblConfigFile;
        private System.Windows.Forms.ContextMenuStrip mnuAssocApps;
    }
}

