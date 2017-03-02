namespace ImageCutter4CAH
{
    partial class FrmCAHCreator
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
            this.BtnCreate = new System.Windows.Forms.Button();
            this.PageNumberSelector = new System.Windows.Forms.NumericUpDown();
            this.TxtDir = new System.Windows.Forms.TextBox();
            this.BtnDir = new System.Windows.Forms.Button();
            this.LblPages = new System.Windows.Forms.Label();
            this.LblPageNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PageNumberSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(15, 141);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(255, 23);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Create Cards";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // PageNumberSelector
            // 
            this.PageNumberSelector.Location = new System.Drawing.Point(15, 103);
            this.PageNumberSelector.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.PageNumberSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PageNumberSelector.Name = "PageNumberSelector";
            this.PageNumberSelector.Size = new System.Drawing.Size(255, 20);
            this.PageNumberSelector.TabIndex = 1;
            this.PageNumberSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxtDir
            // 
            this.TxtDir.Location = new System.Drawing.Point(15, 38);
            this.TxtDir.Name = "TxtDir";
            this.TxtDir.Size = new System.Drawing.Size(224, 20);
            this.TxtDir.TabIndex = 2;
            // 
            // BtnDir
            // 
            this.BtnDir.Location = new System.Drawing.Point(245, 36);
            this.BtnDir.Name = "BtnDir";
            this.BtnDir.Size = new System.Drawing.Size(25, 23);
            this.BtnDir.TabIndex = 3;
            this.BtnDir.Text = "...";
            this.BtnDir.UseVisualStyleBackColor = true;
            this.BtnDir.Click += new System.EventHandler(this.BtnDir_Click);
            // 
            // LblPages
            // 
            this.LblPages.AutoSize = true;
            this.LblPages.Location = new System.Drawing.Point(12, 19);
            this.LblPages.Name = "LblPages";
            this.LblPages.Size = new System.Drawing.Size(127, 13);
            this.LblPages.TabIndex = 4;
            this.LblPages.Text = "Select Directory of Pages";
            // 
            // LblPageNo
            // 
            this.LblPageNo.AutoSize = true;
            this.LblPageNo.Location = new System.Drawing.Point(12, 87);
            this.LblPageNo.Name = "LblPageNo";
            this.LblPageNo.Size = new System.Drawing.Size(105, 13);
            this.LblPageNo.TabIndex = 5;
            this.LblPageNo.Text = "Select Page Number";
            // 
            // FrmCAHCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 190);
            this.Controls.Add(this.LblPageNo);
            this.Controls.Add(this.LblPages);
            this.Controls.Add(this.BtnDir);
            this.Controls.Add(this.TxtDir);
            this.Controls.Add(this.PageNumberSelector);
            this.Controls.Add(this.BtnCreate);
            this.Name = "FrmCAHCreator";
            this.Text = "CAH Page to Card Creator";
            ((System.ComponentModel.ISupportInitialize)(this.PageNumberSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.NumericUpDown PageNumberSelector;
        private System.Windows.Forms.TextBox TxtDir;
        private System.Windows.Forms.Button BtnDir;
        private System.Windows.Forms.Label LblPages;
        private System.Windows.Forms.Label LblPageNo;
    }
}

