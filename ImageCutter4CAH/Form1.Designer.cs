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
            this.TxtDir = new System.Windows.Forms.TextBox();
            this.BtnDir = new System.Windows.Forms.Button();
            this.LblDir = new System.Windows.Forms.Label();
            this.NumPages = new System.Windows.Forms.NumericUpDown();
            this.LblPages = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumPages)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(15, 131);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(255, 23);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Create Cards";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.button1_Click);
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
            // LblDir
            // 
            this.LblDir.AutoSize = true;
            this.LblDir.Location = new System.Drawing.Point(12, 19);
            this.LblDir.Name = "LblDir";
            this.LblDir.Size = new System.Drawing.Size(127, 13);
            this.LblDir.TabIndex = 4;
            this.LblDir.Text = "Select Directory of Pages";
            // 
            // NumPages
            // 
            this.NumPages.Location = new System.Drawing.Point(15, 93);
            this.NumPages.Name = "NumPages";
            this.NumPages.Size = new System.Drawing.Size(255, 20);
            this.NumPages.TabIndex = 5;
            this.NumPages.Value = new decimal(new int[] {
            28,
            0,
            0,
            0});
            // 
            // LblPages
            // 
            this.LblPages.AutoSize = true;
            this.LblPages.Location = new System.Drawing.Point(12, 77);
            this.LblPages.Name = "LblPages";
            this.LblPages.Size = new System.Drawing.Size(144, 13);
            this.LblPages.TabIndex = 6;
            this.LblPages.Text = "Enter number of pages to cut";
            // 
            // FrmCAHCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 178);
            this.Controls.Add(this.LblPages);
            this.Controls.Add(this.NumPages);
            this.Controls.Add(this.LblDir);
            this.Controls.Add(this.BtnDir);
            this.Controls.Add(this.TxtDir);
            this.Controls.Add(this.BtnCreate);
            this.Name = "FrmCAHCreator";
            this.Text = "CAH Page to Card Creator";
            ((System.ComponentModel.ISupportInitialize)(this.NumPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.TextBox TxtDir;
        private System.Windows.Forms.Button BtnDir;
        private System.Windows.Forms.Label LblDir;
        private System.Windows.Forms.NumericUpDown NumPages;
        private System.Windows.Forms.Label LblPages;
    }
}

