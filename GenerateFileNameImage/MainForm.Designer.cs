namespace GenerateFileNameImage
{
    partial class MainForm
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
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dlgSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.nuWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nuHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nuFontSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nuWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(13, 13);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(362, 21);
            this.tbPath.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.Location = new System.Drawing.Point(381, 12);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(28, 23);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 67);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(396, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dlgSelectFolder
            // 
            this.dlgSelectFolder.ShowNewFolderButton = false;
            // 
            // nuWidth
            // 
            this.nuWidth.Location = new System.Drawing.Point(53, 40);
            this.nuWidth.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nuWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuWidth.Name = "nuWidth";
            this.nuWidth.Size = new System.Drawing.Size(75, 21);
            this.nuWidth.TabIndex = 3;
            this.nuWidth.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height";
            // 
            // nuHeight
            // 
            this.nuHeight.Location = new System.Drawing.Point(180, 40);
            this.nuHeight.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nuHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuHeight.Name = "nuHeight";
            this.nuHeight.Size = new System.Drawing.Size(75, 21);
            this.nuHeight.TabIndex = 6;
            this.nuHeight.Value = new decimal(new int[] {
            320,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "FontSize";
            // 
            // nuFontSize
            // 
            this.nuFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nuFontSize.Location = new System.Drawing.Point(333, 40);
            this.nuFontSize.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nuFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuFontSize.Name = "nuFontSize";
            this.nuFontSize.Size = new System.Drawing.Size(75, 21);
            this.nuFontSize.TabIndex = 8;
            this.nuFontSize.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 101);
            this.Controls.Add(this.nuFontSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nuHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuWidth);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.tbPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Generate Filename Image";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.nuWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectFolder;
        private System.Windows.Forms.NumericUpDown nuWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nuHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nuFontSize;
    }
}

