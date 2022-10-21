namespace ScraperHelper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.displayT = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.xpathT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.optimizeButton = new System.Windows.Forms.Button();
            this.startListeningButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.requestsTabs = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.requestsGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.scenarioGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sameDomainC = new System.Windows.Forms.CheckBox();
            this.stopCaptureButton = new System.Windows.Forms.Button();
            this.howManyInHeadersL = new System.Windows.Forms.Label();
            this.howManyInBodyL = new System.Windows.Forms.Label();
            this.hideIrreleventReqCheckbox = new System.Windows.Forms.CheckBox();
            this.startNewCaptureButton = new System.Windows.Forms.Button();
            this.openBrowserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.urlT = new System.Windows.Forms.TextBox();
            this.execRequestButton = new System.Windows.Forms.Button();
            this.formDataT = new System.Windows.Forms.RichTextBox();
            this.cookiesT = new System.Windows.Forms.RichTextBox();
            this.headersT = new System.Windows.Forms.RichTextBox();
            this.searchRequestsButton = new System.Windows.Forms.Button();
            this.termExistL = new System.Windows.Forms.Label();
            this.optimizeRequestButton = new System.Windows.Forms.Button();
            this.generateRequestCodeButton = new System.Windows.Forms.Button();
            this.openOnBrowserButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resultHeadersT = new System.Windows.Forms.RichTextBox();
            this.localSearchTermT = new System.Windows.Forms.TextBox();
            this.getNeededRequestsButton = new System.Windows.Forms.Button();
            this.addToFinalRequestsButton = new System.Windows.Forms.Button();
            this.resultT = new System.Windows.Forms.RichTextBox();
            this.reqUrlT = new System.Windows.Forms.TextBox();
            this.httpMethodT = new System.Windows.Forms.ComboBox();
            this.decodeUrlButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.finalRequestsGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.requestsTabs.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestsGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scenarioGridView)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finalRequestsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayT
            // 
            this.displayT.AutoSize = true;
            this.displayT.Location = new System.Drawing.Point(29, 18);
            this.displayT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.displayT.Name = "displayT";
            this.displayT.Size = new System.Drawing.Size(33, 25);
            this.displayT.TabIndex = 1;
            this.displayT.Text = "---";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(2038, 20);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(162, 36);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // xpathT
            // 
            this.xpathT.Location = new System.Drawing.Point(266, 94);
            this.xpathT.Margin = new System.Windows.Forms.Padding(2);
            this.xpathT.Name = "xpathT";
            this.xpathT.Size = new System.Drawing.Size(649, 31);
            this.xpathT.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Xpath :";
            // 
            // optimizeButton
            // 
            this.optimizeButton.Location = new System.Drawing.Point(752, 131);
            this.optimizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.optimizeButton.Name = "optimizeButton";
            this.optimizeButton.Size = new System.Drawing.Size(162, 46);
            this.optimizeButton.TabIndex = 7;
            this.optimizeButton.Text = "Optimize";
            this.optimizeButton.UseVisualStyleBackColor = true;
            this.optimizeButton.Click += new System.EventHandler(this.optimizeButton_Click);
            // 
            // startListeningButton
            // 
            this.startListeningButton.Location = new System.Drawing.Point(752, 41);
            this.startListeningButton.Margin = new System.Windows.Forms.Padding(2);
            this.startListeningButton.Name = "startListeningButton";
            this.startListeningButton.Size = new System.Drawing.Size(162, 46);
            this.startListeningButton.TabIndex = 10;
            this.startListeningButton.Text = "start listening";
            this.startListeningButton.UseVisualStyleBackColor = true;
            this.startListeningButton.Click += new System.EventHandler(this.startListeningButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2405, 1134);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.startListeningButton);
            this.tabPage1.Controls.Add(this.xpathT);
            this.tabPage1.Controls.Add(this.optimizeButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(2397, 1096);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(2397, 1096);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.requestsTabs);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 884);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2393, 210);
            this.panel3.TabIndex = 42;
            // 
            // requestsTabs
            // 
            this.requestsTabs.Controls.Add(this.tabPage4);
            this.requestsTabs.Controls.Add(this.tabPage5);
            this.requestsTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestsTabs.Location = new System.Drawing.Point(0, 0);
            this.requestsTabs.Name = "requestsTabs";
            this.requestsTabs.SelectedIndex = 0;
            this.requestsTabs.Size = new System.Drawing.Size(2393, 210);
            this.requestsTabs.TabIndex = 33;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.requestsGrid);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(2385, 172);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "All Requests";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // requestsGrid
            // 
            this.requestsGrid.AllowUserToAddRows = false;
            this.requestsGrid.AllowUserToDeleteRows = false;
            this.requestsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.requestsGrid.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.requestsGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.requestsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestsGrid.Location = new System.Drawing.Point(3, 3);
            this.requestsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.requestsGrid.MultiSelect = false;
            this.requestsGrid.Name = "requestsGrid";
            this.requestsGrid.ReadOnly = true;
            this.requestsGrid.RowHeadersWidth = 62;
            this.requestsGrid.RowTemplate.Height = 33;
            this.requestsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestsGrid.Size = new System.Drawing.Size(2379, 166);
            this.requestsGrid.TabIndex = 32;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.checkToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 68);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(131, 32);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(131, 32);
            this.checkToolStripMenuItem.Text = "Check";
            this.checkToolStripMenuItem.Click += new System.EventHandler(this.checkToolStripMenuItem_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.scenarioGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(2385, 172);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Scenario";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // scenarioGridView
            // 
            this.scenarioGridView.AllowUserToAddRows = false;
            this.scenarioGridView.AllowUserToDeleteRows = false;
            this.scenarioGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scenarioGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.scenarioGridView.ContextMenuStrip = this.contextMenuStrip2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scenarioGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.scenarioGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scenarioGridView.Location = new System.Drawing.Point(3, 3);
            this.scenarioGridView.Margin = new System.Windows.Forms.Padding(2);
            this.scenarioGridView.MultiSelect = false;
            this.scenarioGridView.Name = "scenarioGridView";
            this.scenarioGridView.ReadOnly = true;
            this.scenarioGridView.RowHeadersWidth = 62;
            this.scenarioGridView.RowTemplate.Height = 33;
            this.scenarioGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scenarioGridView.Size = new System.Drawing.Size(2379, 166);
            this.scenarioGridView.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "HttpReq";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Url";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Type";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "req";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem1,
            this.checkToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(129, 68);
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(128, 32);
            this.clearToolStripMenuItem1.Text = "clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // checkToolStripMenuItem1
            // 
            this.checkToolStripMenuItem1.Name = "checkToolStripMenuItem1";
            this.checkToolStripMenuItem1.Size = new System.Drawing.Size(128, 32);
            this.checkToolStripMenuItem1.Text = "check";
            this.checkToolStripMenuItem1.Click += new System.EventHandler(this.checkToolStripMenuItem1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sameDomainC);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.stopCaptureButton);
            this.panel2.Controls.Add(this.howManyInHeadersL);
            this.panel2.Controls.Add(this.howManyInBodyL);
            this.panel2.Controls.Add(this.hideIrreleventReqCheckbox);
            this.panel2.Controls.Add(this.startNewCaptureButton);
            this.panel2.Controls.Add(this.openBrowserButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.urlT);
            this.panel2.Controls.Add(this.execRequestButton);
            this.panel2.Controls.Add(this.formDataT);
            this.panel2.Controls.Add(this.cookiesT);
            this.panel2.Controls.Add(this.headersT);
            this.panel2.Controls.Add(this.searchRequestsButton);
            this.panel2.Controls.Add(this.termExistL);
            this.panel2.Controls.Add(this.optimizeRequestButton);
            this.panel2.Controls.Add(this.generateRequestCodeButton);
            this.panel2.Controls.Add(this.openOnBrowserButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.resultHeadersT);
            this.panel2.Controls.Add(this.localSearchTermT);
            this.panel2.Controls.Add(this.getNeededRequestsButton);
            this.panel2.Controls.Add(this.addToFinalRequestsButton);
            this.panel2.Controls.Add(this.resultT);
            this.panel2.Controls.Add(this.reqUrlT);
            this.panel2.Controls.Add(this.httpMethodT);
            this.panel2.Controls.Add(this.decodeUrlButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2393, 882);
            this.panel2.TabIndex = 41;
            // 
            // sameDomainC
            // 
            this.sameDomainC.AutoSize = true;
            this.sameDomainC.Location = new System.Drawing.Point(1799, 24);
            this.sameDomainC.Margin = new System.Windows.Forms.Padding(4);
            this.sameDomainC.Name = "sameDomainC";
            this.sameDomainC.Size = new System.Drawing.Size(148, 29);
            this.sameDomainC.TabIndex = 48;
            this.sameDomainC.Text = "Same domain";
            this.sameDomainC.UseVisualStyleBackColor = true;
            // 
            // stopCaptureButton
            // 
            this.stopCaptureButton.Location = new System.Drawing.Point(1458, 20);
            this.stopCaptureButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopCaptureButton.Name = "stopCaptureButton";
            this.stopCaptureButton.Size = new System.Drawing.Size(168, 36);
            this.stopCaptureButton.TabIndex = 47;
            this.stopCaptureButton.Text = "stop the capture";
            this.stopCaptureButton.UseVisualStyleBackColor = true;
            this.stopCaptureButton.Click += new System.EventHandler(this.stopCaptureButton_Click);
            // 
            // howManyInHeadersL
            // 
            this.howManyInHeadersL.AutoSize = true;
            this.howManyInHeadersL.Location = new System.Drawing.Point(1395, 784);
            this.howManyInHeadersL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.howManyInHeadersL.Name = "howManyInHeadersL";
            this.howManyInHeadersL.Size = new System.Drawing.Size(33, 25);
            this.howManyInHeadersL.TabIndex = 46;
            this.howManyInHeadersL.Text = "---";
            // 
            // howManyInBodyL
            // 
            this.howManyInBodyL.AutoSize = true;
            this.howManyInBodyL.Location = new System.Drawing.Point(722, 784);
            this.howManyInBodyL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.howManyInBodyL.Name = "howManyInBodyL";
            this.howManyInBodyL.Size = new System.Drawing.Size(33, 25);
            this.howManyInBodyL.TabIndex = 45;
            this.howManyInBodyL.Text = "---";
            // 
            // hideIrreleventReqCheckbox
            // 
            this.hideIrreleventReqCheckbox.AutoSize = true;
            this.hideIrreleventReqCheckbox.Location = new System.Drawing.Point(1910, 842);
            this.hideIrreleventReqCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.hideIrreleventReqCheckbox.Name = "hideIrreleventReqCheckbox";
            this.hideIrreleventReqCheckbox.Size = new System.Drawing.Size(152, 29);
            this.hideIrreleventReqCheckbox.TabIndex = 44;
            this.hideIrreleventReqCheckbox.Text = "Hide irrelevent";
            this.hideIrreleventReqCheckbox.UseVisualStyleBackColor = true;
            // 
            // startNewCaptureButton
            // 
            this.startNewCaptureButton.Location = new System.Drawing.Point(1285, 20);
            this.startNewCaptureButton.Margin = new System.Windows.Forms.Padding(2);
            this.startNewCaptureButton.Name = "startNewCaptureButton";
            this.startNewCaptureButton.Size = new System.Drawing.Size(168, 36);
            this.startNewCaptureButton.TabIndex = 33;
            this.startNewCaptureButton.Text = "start new capture";
            this.startNewCaptureButton.UseVisualStyleBackColor = true;
            this.startNewCaptureButton.Click += new System.EventHandler(this.startNewCaptureButton_Click);
            // 
            // openBrowserButton
            // 
            this.openBrowserButton.Location = new System.Drawing.Point(1630, 20);
            this.openBrowserButton.Margin = new System.Windows.Forms.Padding(2);
            this.openBrowserButton.Name = "openBrowserButton";
            this.openBrowserButton.Size = new System.Drawing.Size(162, 36);
            this.openBrowserButton.TabIndex = 43;
            this.openBrowserButton.Text = "open browser";
            this.openBrowserButton.UseVisualStyleBackColor = true;
            this.openBrowserButton.Click += new System.EventHandler(this.openBrowserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1236, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Url :";
            // 
            // urlT
            // 
            this.urlT.Location = new System.Drawing.Point(1285, 65);
            this.urlT.Margin = new System.Windows.Forms.Padding(2);
            this.urlT.Name = "urlT";
            this.urlT.Size = new System.Drawing.Size(914, 31);
            this.urlT.TabIndex = 41;
            // 
            // execRequestButton
            // 
            this.execRequestButton.Location = new System.Drawing.Point(4, 20);
            this.execRequestButton.Margin = new System.Windows.Forms.Padding(4);
            this.execRequestButton.Name = "execRequestButton";
            this.execRequestButton.Size = new System.Drawing.Size(195, 36);
            this.execRequestButton.TabIndex = 18;
            this.execRequestButton.Text = "Execute";
            this.execRequestButton.UseVisualStyleBackColor = true;
            this.execRequestButton.Click += new System.EventHandler(this.execRequestButton_Click);
            // 
            // formDataT
            // 
            this.formDataT.Location = new System.Drawing.Point(6, 508);
            this.formDataT.Margin = new System.Windows.Forms.Padding(2);
            this.formDataT.Name = "formDataT";
            this.formDataT.Size = new System.Drawing.Size(674, 273);
            this.formDataT.TabIndex = 38;
            this.formDataT.Text = "";
            this.formDataT.WordWrap = false;
            // 
            // cookiesT
            // 
            this.cookiesT.Location = new System.Drawing.Point(6, 325);
            this.cookiesT.Margin = new System.Windows.Forms.Padding(2);
            this.cookiesT.Name = "cookiesT";
            this.cookiesT.Size = new System.Drawing.Size(674, 176);
            this.cookiesT.TabIndex = 39;
            this.cookiesT.Text = "";
            this.cookiesT.WordWrap = false;
            // 
            // headersT
            // 
            this.headersT.Location = new System.Drawing.Point(4, 104);
            this.headersT.Margin = new System.Windows.Forms.Padding(2);
            this.headersT.Name = "headersT";
            this.headersT.Size = new System.Drawing.Size(676, 215);
            this.headersT.TabIndex = 40;
            this.headersT.Text = "";
            this.headersT.WordWrap = false;
            // 
            // searchRequestsButton
            // 
            this.searchRequestsButton.Location = new System.Drawing.Point(1741, 834);
            this.searchRequestsButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchRequestsButton.Name = "searchRequestsButton";
            this.searchRequestsButton.Size = new System.Drawing.Size(162, 46);
            this.searchRequestsButton.TabIndex = 34;
            this.searchRequestsButton.Text = "Search";
            this.searchRequestsButton.UseVisualStyleBackColor = true;
            this.searchRequestsButton.Click += new System.EventHandler(this.searchRequestsButton_Click);
            // 
            // termExistL
            // 
            this.termExistL.AutoSize = true;
            this.termExistL.Location = new System.Drawing.Point(8, 854);
            this.termExistL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.termExistL.Name = "termExistL";
            this.termExistL.Size = new System.Drawing.Size(33, 25);
            this.termExistL.TabIndex = 21;
            this.termExistL.Text = "---";
            // 
            // optimizeRequestButton
            // 
            this.optimizeRequestButton.Location = new System.Drawing.Point(206, 20);
            this.optimizeRequestButton.Margin = new System.Windows.Forms.Padding(4);
            this.optimizeRequestButton.Name = "optimizeRequestButton";
            this.optimizeRequestButton.Size = new System.Drawing.Size(195, 36);
            this.optimizeRequestButton.TabIndex = 19;
            this.optimizeRequestButton.Text = "Optimize";
            this.optimizeRequestButton.UseVisualStyleBackColor = true;
            this.optimizeRequestButton.Click += new System.EventHandler(this.optimizeRequestButton_Click);
            // 
            // generateRequestCodeButton
            // 
            this.generateRequestCodeButton.Location = new System.Drawing.Point(409, 20);
            this.generateRequestCodeButton.Margin = new System.Windows.Forms.Padding(4);
            this.generateRequestCodeButton.Name = "generateRequestCodeButton";
            this.generateRequestCodeButton.Size = new System.Drawing.Size(195, 36);
            this.generateRequestCodeButton.TabIndex = 22;
            this.generateRequestCodeButton.Text = "Generate c sharp req";
            this.generateRequestCodeButton.UseVisualStyleBackColor = true;
            this.generateRequestCodeButton.Click += new System.EventHandler(this.generateRequestCodeButton_Click);
            // 
            // openOnBrowserButton
            // 
            this.openOnBrowserButton.Location = new System.Drawing.Point(611, 20);
            this.openOnBrowserButton.Margin = new System.Windows.Forms.Padding(4);
            this.openOnBrowserButton.Name = "openOnBrowserButton";
            this.openOnBrowserButton.Size = new System.Drawing.Size(195, 36);
            this.openOnBrowserButton.TabIndex = 24;
            this.openOnBrowserButton.Text = "open on browser";
            this.openOnBrowserButton.UseVisualStyleBackColor = true;
            this.openOnBrowserButton.Click += new System.EventHandler(this.openOnBrowserButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1329, 814);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Search Term :";
            // 
            // resultHeadersT
            // 
            this.resultHeadersT.Location = new System.Drawing.Point(1394, 104);
            this.resultHeadersT.Margin = new System.Windows.Forms.Padding(2);
            this.resultHeadersT.Name = "resultHeadersT";
            this.resultHeadersT.Size = new System.Drawing.Size(805, 676);
            this.resultHeadersT.TabIndex = 29;
            this.resultHeadersT.Text = "";
            this.resultHeadersT.WordWrap = false;
            // 
            // localSearchTermT
            // 
            this.localSearchTermT.Location = new System.Drawing.Point(1329, 840);
            this.localSearchTermT.Margin = new System.Windows.Forms.Padding(2);
            this.localSearchTermT.Name = "localSearchTermT";
            this.localSearchTermT.Size = new System.Drawing.Size(406, 31);
            this.localSearchTermT.TabIndex = 25;
            // 
            // getNeededRequestsButton
            // 
            this.getNeededRequestsButton.Location = new System.Drawing.Point(826, 20);
            this.getNeededRequestsButton.Margin = new System.Windows.Forms.Padding(4);
            this.getNeededRequestsButton.Name = "getNeededRequestsButton";
            this.getNeededRequestsButton.Size = new System.Drawing.Size(195, 36);
            this.getNeededRequestsButton.TabIndex = 27;
            this.getNeededRequestsButton.Text = "Get Needed request";
            this.getNeededRequestsButton.UseVisualStyleBackColor = true;
            this.getNeededRequestsButton.Click += new System.EventHandler(this.GetNeededRequestsButton_Click);
            // 
            // addToFinalRequestsButton
            // 
            this.addToFinalRequestsButton.Location = new System.Drawing.Point(1029, 20);
            this.addToFinalRequestsButton.Margin = new System.Windows.Forms.Padding(4);
            this.addToFinalRequestsButton.Name = "addToFinalRequestsButton";
            this.addToFinalRequestsButton.Size = new System.Drawing.Size(195, 36);
            this.addToFinalRequestsButton.TabIndex = 28;
            this.addToFinalRequestsButton.Text = "Add to final Requests";
            this.addToFinalRequestsButton.UseVisualStyleBackColor = true;
            this.addToFinalRequestsButton.Click += new System.EventHandler(this.addToFinalRequestsButton_Click);
            // 
            // resultT
            // 
            this.resultT.Location = new System.Drawing.Point(722, 104);
            this.resultT.Margin = new System.Windows.Forms.Padding(2);
            this.resultT.Name = "resultT";
            this.resultT.Size = new System.Drawing.Size(665, 676);
            this.resultT.TabIndex = 31;
            this.resultT.Text = "";
            this.resultT.WordWrap = false;
            // 
            // reqUrlT
            // 
            this.reqUrlT.Location = new System.Drawing.Point(130, 64);
            this.reqUrlT.Margin = new System.Windows.Forms.Padding(4);
            this.reqUrlT.Name = "reqUrlT";
            this.reqUrlT.Size = new System.Drawing.Size(550, 31);
            this.reqUrlT.TabIndex = 1;
            // 
            // httpMethodT
            // 
            this.httpMethodT.FormattingEnabled = true;
            this.httpMethodT.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.httpMethodT.Location = new System.Drawing.Point(6, 62);
            this.httpMethodT.Margin = new System.Windows.Forms.Padding(4);
            this.httpMethodT.Name = "httpMethodT";
            this.httpMethodT.Size = new System.Drawing.Size(115, 33);
            this.httpMethodT.TabIndex = 20;
            // 
            // decodeUrlButton
            // 
            this.decodeUrlButton.Location = new System.Drawing.Point(686, 60);
            this.decodeUrlButton.Margin = new System.Windows.Forms.Padding(4);
            this.decodeUrlButton.Name = "decodeUrlButton";
            this.decodeUrlButton.Size = new System.Drawing.Size(169, 36);
            this.decodeUrlButton.TabIndex = 23;
            this.decodeUrlButton.Text = "Decode";
            this.decodeUrlButton.UseVisualStyleBackColor = true;
            this.decodeUrlButton.Click += new System.EventHandler(this.decodeUrlButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.finalRequestsGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(2397, 1096);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // finalRequestsGrid
            // 
            this.finalRequestsGrid.AllowUserToAddRows = false;
            this.finalRequestsGrid.AllowUserToDeleteRows = false;
            this.finalRequestsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finalRequestsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.finalRequestsGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.finalRequestsGrid.Location = new System.Drawing.Point(39, 69);
            this.finalRequestsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.finalRequestsGrid.Name = "finalRequestsGrid";
            this.finalRequestsGrid.ReadOnly = true;
            this.finalRequestsGrid.RowHeadersWidth = 62;
            this.finalRequestsGrid.RowTemplate.Height = 33;
            this.finalRequestsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.finalRequestsGrid.Size = new System.Drawing.Size(2051, 272);
            this.finalRequestsGrid.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "HttpReq";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Url";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "req";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.displayT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1134);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2405, 65);
            this.panel1.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2405, 1134);
            this.panel4.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "HttpReq";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Url";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "req";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Number";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2405, 1199);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.requestsTabs.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestsGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scenarioGridView)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.finalRequestsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label displayT;
        private Button saveButton;
        private TextBox xpathT;
        private Label label2;
        private Button optimizeButton;
        private Button startListeningButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private TextBox reqUrlT;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem checkToolStripMenuItem;
        private Button optimizeRequestButton;
        private Button execRequestButton;
        private ComboBox httpMethodT;
        private Label termExistL;
        private Button generateRequestCodeButton;
        private Button decodeUrlButton;
        private Button openOnBrowserButton;
        private Label label4;
        private TextBox localSearchTermT;
        private Button getNeededRequestsButton;
        private Button addToFinalRequestsButton;
        private TabPage tabPage3;
        private DataGridView finalRequestsGrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private RichTextBox resultHeadersT;
        private RichTextBox resultT;
        private Button searchRequestsButton;
        private Button startNewCaptureButton;
        private DataGridView requestsGrid;
        private RichTextBox formDataT;
        private RichTextBox cookiesT;
        private RichTextBox headersT;
        private Panel panel3;
        private Panel panel2;
        private Button openBrowserButton;
        private Label label1;
        private TextBox urlT;
        private Panel panel4;
        private CheckBox hideIrreleventReqCheckbox;
        private Label howManyInHeadersL;
        private Label howManyInBodyL;
        private Button stopCaptureButton;
        private CheckBox sameDomainC;
        private TabControl requestsTabs;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private DataGridView scenarioGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem clearToolStripMenuItem1;
        private ToolStripMenuItem checkToolStripMenuItem1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}