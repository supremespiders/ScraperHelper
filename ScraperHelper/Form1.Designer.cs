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
            this.openBrowserButton = new System.Windows.Forms.Button();
            this.displayT = new System.Windows.Forms.Label();
            this.urlT = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.xpathT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.optimizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openBrowserButton
            // 
            this.openBrowserButton.Location = new System.Drawing.Point(1569, 108);
            this.openBrowserButton.Name = "openBrowserButton";
            this.openBrowserButton.Size = new System.Drawing.Size(163, 46);
            this.openBrowserButton.TabIndex = 0;
            this.openBrowserButton.Text = "open browser";
            this.openBrowserButton.UseVisualStyleBackColor = true;
            this.openBrowserButton.Click += new System.EventHandler(this.openBrowserButton_Click);
            // 
            // displayT
            // 
            this.displayT.AutoSize = true;
            this.displayT.Location = new System.Drawing.Point(48, 1025);
            this.displayT.Name = "displayT";
            this.displayT.Size = new System.Drawing.Size(33, 25);
            this.displayT.TabIndex = 1;
            this.displayT.Text = "---";
            // 
            // urlT
            // 
            this.urlT.Location = new System.Drawing.Point(1083, 71);
            this.urlT.Name = "urlT";
            this.urlT.Size = new System.Drawing.Size(649, 31);
            this.urlT.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1569, 1004);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(163, 46);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // xpathT
            // 
            this.xpathT.Location = new System.Drawing.Point(1083, 339);
            this.xpathT.Name = "xpathT";
            this.xpathT.Size = new System.Drawing.Size(649, 31);
            this.xpathT.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1083, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Url :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1083, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Xpath :";
            // 
            // optimizeButton
            // 
            this.optimizeButton.Location = new System.Drawing.Point(1569, 376);
            this.optimizeButton.Name = "optimizeButton";
            this.optimizeButton.Size = new System.Drawing.Size(163, 46);
            this.optimizeButton.TabIndex = 7;
            this.optimizeButton.Text = "Optimize";
            this.optimizeButton.UseVisualStyleBackColor = true;
            this.optimizeButton.Click += new System.EventHandler(this.optimizeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1756, 1083);
            this.Controls.Add(this.optimizeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xpathT);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.urlT);
            this.Controls.Add(this.displayT);
            this.Controls.Add(this.openBrowserButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}