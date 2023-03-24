namespace WinFormProject
{
    partial class frmMax
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMax));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLMax = new System.Windows.Forms.TextBox();
            this.btnLMaxGen = new System.Windows.Forms.Button();
            this.btnLMaxRead = new System.Windows.Forms.Button();
            this.btnLMaxExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLMax09 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "The winning numbers are:";
            // 
            // txtLMax
            // 
            this.txtLMax.Location = new System.Drawing.Point(413, 70);
            this.txtLMax.Multiline = true;
            this.txtLMax.Name = "txtLMax";
            this.txtLMax.ReadOnly = true;
            this.txtLMax.Size = new System.Drawing.Size(92, 295);
            this.txtLMax.TabIndex = 1;
            this.txtLMax.TabStop = false;
            // 
            // btnLMaxGen
            // 
            this.btnLMaxGen.Location = new System.Drawing.Point(36, 448);
            this.btnLMaxGen.Name = "btnLMaxGen";
            this.btnLMaxGen.Size = new System.Drawing.Size(118, 43);
            this.btnLMaxGen.TabIndex = 2;
            this.btnLMaxGen.Text = "&Generate";
            this.btnLMaxGen.UseVisualStyleBackColor = true;
            this.btnLMaxGen.Click += new System.EventHandler(this.btnLMaxGen_Click);
            // 
            // btnLMaxRead
            // 
            this.btnLMaxRead.Location = new System.Drawing.Point(210, 449);
            this.btnLMaxRead.Name = "btnLMaxRead";
            this.btnLMaxRead.Size = new System.Drawing.Size(118, 43);
            this.btnLMaxRead.TabIndex = 3;
            this.btnLMaxRead.Text = "&Read File";
            this.btnLMaxRead.UseVisualStyleBackColor = true;
            this.btnLMaxRead.Click += new System.EventHandler(this.btnLMaxRead_Click);
            // 
            // btnLMaxExit
            // 
            this.btnLMaxExit.Location = new System.Drawing.Point(387, 446);
            this.btnLMaxExit.Name = "btnLMaxExit";
            this.btnLMaxExit.Size = new System.Drawing.Size(118, 46);
            this.btnLMaxExit.TabIndex = 4;
            this.btnLMaxExit.Text = "E&xit";
            this.btnLMaxExit.UseVisualStyleBackColor = true;
            this.btnLMaxExit.Click += new System.EventHandler(this.btnLMaxExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(36, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 295);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblLMax09
            // 
            this.lblLMax09.AutoSize = true;
            this.lblLMax09.Location = new System.Drawing.Point(32, 381);
            this.lblLMax09.Name = "lblLMax09";
            this.lblLMax09.Size = new System.Drawing.Size(114, 20);
            this.lblLMax09.TabIndex = 6;
            this.lblLMax09.Text = "Random 0 to 9";
            // 
            // frmMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 539);
            this.Controls.Add(this.lblLMax09);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLMaxExit);
            this.Controls.Add(this.btnLMaxRead);
            this.Controls.Add(this.btnLMaxGen);
            this.Controls.Add(this.txtLMax);
            this.Controls.Add(this.label1);
            this.Name = "frmMax";
            this.Text = "LottoMax - Bernadette";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLMax;
        private System.Windows.Forms.Button btnLMaxGen;
        private System.Windows.Forms.Button btnLMaxRead;
        private System.Windows.Forms.Button btnLMaxExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLMax09;
    }
}