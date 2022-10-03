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
            this.openBrowserButton = new System.Windows.Forms.Button();
            this.displayT = new System.Windows.Forms.Label();
            this.urlT = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.xpathT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.optimizeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTermT = new System.Windows.Forms.TextBox();
            this.startListeningButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.requestsGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.termExistL = new System.Windows.Forms.Label();
            this.httpMethodT = new System.Windows.Forms.ComboBox();
            this.optimizeRequestButton = new System.Windows.Forms.Button();
            this.execRequestButton = new System.Windows.Forms.Button();
            this.resultT = new System.Windows.Forms.TextBox();
            this.formDataT = new System.Windows.Forms.TextBox();
            this.reqUrlT = new System.Windows.Forms.TextBox();
            this.cookiesT = new System.Windows.Forms.TextBox();
            this.headersT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestsGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openBrowserButton
            // 
            this.openBrowserButton.Location = new System.Drawing.Point(1510, 99);
            this.openBrowserButton.Margin = new System.Windows.Forms.Padding(2);
            this.openBrowserButton.Name = "openBrowserButton";
            this.openBrowserButton.Size = new System.Drawing.Size(130, 37);
            this.openBrowserButton.TabIndex = 0;
            this.openBrowserButton.Text = "open browser";
            this.openBrowserButton.UseVisualStyleBackColor = true;
            this.openBrowserButton.Click += new System.EventHandler(this.openBrowserButton_Click);
            // 
            // displayT
            // 
            this.displayT.AutoSize = true;
            this.displayT.Location = new System.Drawing.Point(14, 20);
            this.displayT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.displayT.Name = "displayT";
            this.displayT.Size = new System.Drawing.Size(27, 20);
            this.displayT.TabIndex = 1;
            this.displayT.Text = "---";
            // 
            // urlT
            // 
            this.urlT.Location = new System.Drawing.Point(1121, 70);
            this.urlT.Margin = new System.Windows.Forms.Padding(2);
            this.urlT.Name = "urlT";
            this.urlT.Size = new System.Drawing.Size(520, 27);
            this.urlT.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1265, 7);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(130, 37);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // xpathT
            // 
            this.xpathT.Location = new System.Drawing.Point(1121, 284);
            this.xpathT.Margin = new System.Windows.Forms.Padding(2);
            this.xpathT.Name = "xpathT";
            this.xpathT.Size = new System.Drawing.Size(520, 27);
            this.xpathT.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1121, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Url :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1121, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Xpath :";
            // 
            // optimizeButton
            // 
            this.optimizeButton.Location = new System.Drawing.Point(1510, 314);
            this.optimizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.optimizeButton.Name = "optimizeButton";
            this.optimizeButton.Size = new System.Drawing.Size(130, 37);
            this.optimizeButton.TabIndex = 7;
            this.optimizeButton.Text = "Optimize";
            this.optimizeButton.UseVisualStyleBackColor = true;
            this.optimizeButton.Click += new System.EventHandler(this.optimizeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1121, 388);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search Term :";
            // 
            // searchTermT
            // 
            this.searchTermT.Location = new System.Drawing.Point(1121, 410);
            this.searchTermT.Margin = new System.Windows.Forms.Padding(2);
            this.searchTermT.Name = "searchTermT";
            this.searchTermT.Size = new System.Drawing.Size(520, 27);
            this.searchTermT.TabIndex = 8;
            // 
            // startListeningButton
            // 
            this.startListeningButton.Location = new System.Drawing.Point(1510, 242);
            this.startListeningButton.Margin = new System.Windows.Forms.Padding(2);
            this.startListeningButton.Name = "startListeningButton";
            this.startListeningButton.Size = new System.Drawing.Size(130, 37);
            this.startListeningButton.TabIndex = 10;
            this.startListeningButton.Text = "start listening";
            this.startListeningButton.UseVisualStyleBackColor = true;
            this.startListeningButton.Click += new System.EventHandler(this.startListeningButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1705, 844);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.requestsGrid);
            this.tabPage1.Controls.Add(this.urlT);
            this.tabPage1.Controls.Add(this.startListeningButton);
            this.tabPage1.Controls.Add(this.openBrowserButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.xpathT);
            this.tabPage1.Controls.Add(this.searchTermT);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.optimizeButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1697, 811);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
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
            this.Column4});
            this.requestsGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.requestsGrid.Location = new System.Drawing.Point(0, 563);
            this.requestsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.requestsGrid.Name = "requestsGrid";
            this.requestsGrid.ReadOnly = true;
            this.requestsGrid.RowHeadersWidth = 62;
            this.requestsGrid.RowTemplate.Height = 33;
            this.requestsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.requestsGrid.Size = new System.Drawing.Size(1641, 218);
            this.requestsGrid.TabIndex = 11;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.checkToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 52);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.checkToolStripMenuItem.Text = "Check";
            this.checkToolStripMenuItem.Click += new System.EventHandler(this.checkToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.termExistL);
            this.tabPage2.Controls.Add(this.httpMethodT);
            this.tabPage2.Controls.Add(this.optimizeRequestButton);
            this.tabPage2.Controls.Add(this.execRequestButton);
            this.tabPage2.Controls.Add(this.resultT);
            this.tabPage2.Controls.Add(this.formDataT);
            this.tabPage2.Controls.Add(this.reqUrlT);
            this.tabPage2.Controls.Add(this.cookiesT);
            this.tabPage2.Controls.Add(this.headersT);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1697, 811);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // termExistL
            // 
            this.termExistL.AutoSize = true;
            this.termExistL.Location = new System.Drawing.Point(889, 736);
            this.termExistL.Name = "termExistL";
            this.termExistL.Size = new System.Drawing.Size(27, 20);
            this.termExistL.TabIndex = 21;
            this.termExistL.Text = "---";
            // 
            // httpMethodT
            // 
            this.httpMethodT.FormattingEnabled = true;
            this.httpMethodT.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.httpMethodT.Location = new System.Drawing.Point(10, 38);
            this.httpMethodT.Name = "httpMethodT";
            this.httpMethodT.Size = new System.Drawing.Size(93, 28);
            this.httpMethodT.TabIndex = 20;
            // 
            // optimizeRequestButton
            // 
            this.optimizeRequestButton.Location = new System.Drawing.Point(639, 324);
            this.optimizeRequestButton.Name = "optimizeRequestButton";
            this.optimizeRequestButton.Size = new System.Drawing.Size(135, 29);
            this.optimizeRequestButton.TabIndex = 19;
            this.optimizeRequestButton.Text = "Optimize";
            this.optimizeRequestButton.UseVisualStyleBackColor = true;
            this.optimizeRequestButton.Click += new System.EventHandler(this.optimizeRequestButton_Click);
            // 
            // execRequestButton
            // 
            this.execRequestButton.Location = new System.Drawing.Point(639, 289);
            this.execRequestButton.Name = "execRequestButton";
            this.execRequestButton.Size = new System.Drawing.Size(135, 29);
            this.execRequestButton.TabIndex = 18;
            this.execRequestButton.Text = "Execute";
            this.execRequestButton.UseVisualStyleBackColor = true;
            this.execRequestButton.Click += new System.EventHandler(this.execRequestButton_Click);
            // 
            // resultT
            // 
            this.resultT.Location = new System.Drawing.Point(991, 39);
            this.resultT.Multiline = true;
            this.resultT.Name = "resultT";
            this.resultT.Size = new System.Drawing.Size(698, 717);
            this.resultT.TabIndex = 17;
            // 
            // formDataT
            // 
            this.formDataT.Location = new System.Drawing.Point(10, 411);
            this.formDataT.Multiline = true;
            this.formDataT.Name = "formDataT";
            this.formDataT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.formDataT.Size = new System.Drawing.Size(576, 250);
            this.formDataT.TabIndex = 16;
            // 
            // reqUrlT
            // 
            this.reqUrlT.Location = new System.Drawing.Point(109, 39);
            this.reqUrlT.Name = "reqUrlT";
            this.reqUrlT.Size = new System.Drawing.Size(477, 27);
            this.reqUrlT.TabIndex = 1;
            // 
            // cookiesT
            // 
            this.cookiesT.Location = new System.Drawing.Point(10, 242);
            this.cookiesT.Multiline = true;
            this.cookiesT.Name = "cookiesT";
            this.cookiesT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.cookiesT.Size = new System.Drawing.Size(576, 163);
            this.cookiesT.TabIndex = 15;
            // 
            // headersT
            // 
            this.headersT.Location = new System.Drawing.Point(10, 73);
            this.headersT.Multiline = true;
            this.headersT.Name = "headersT";
            this.headersT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.headersT.Size = new System.Drawing.Size(576, 163);
            this.headersT.TabIndex = 14;
            this.headersT.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.displayT);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 790);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1705, 54);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1705, 844);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestsGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button openBrowserButton;
        private Label displayT;
        private TextBox urlT;
        private Button saveButton;
        private TextBox xpathT;
        private Label label1;
        private Label label2;
        private Button optimizeButton;
        private Label label3;
        private TextBox searchTermT;
        private Button startListeningButton;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private DataGridView requestsGrid;
        private TextBox reqUrlT;
        private TextBox formDataT;
        private TextBox cookiesT;
        private TextBox headersT;
        private TextBox resultT;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem checkToolStripMenuItem;
        private Button optimizeRequestButton;
        private Button execRequestButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox httpMethodT;
        private Label termExistL;
    }
}