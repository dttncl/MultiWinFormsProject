namespace WinFormProject
{
    partial class frm649
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm649));
            this.lblLMax = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn649Exit = new System.Windows.Forms.Button();
            this.btnL649Read = new System.Windows.Forms.Button();
            this.btnL649Gen = new System.Windows.Forms.Button();
            this.txtL649 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl64909 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLMax
            // 
            this.lblLMax.AutoSize = true;
            this.lblLMax.Location = new System.Drawing.Point(43, 393);
            this.lblLMax.Name = "lblLMax";
            this.lblLMax.Size = new System.Drawing.Size(0, 20);
            this.lblLMax.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(41, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 295);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btn649Exit
            // 
            this.btn649Exit.Location = new System.Drawing.Point(392, 455);
            this.btn649Exit.Name = "btn649Exit";
            this.btn649Exit.Size = new System.Drawing.Size(118, 46);
            this.btn649Exit.TabIndex = 11;
            this.btn649Exit.Text = "E&xit";
            this.btn649Exit.UseVisualStyleBackColor = true;
            this.btn649Exit.Click += new System.EventHandler(this.btn649Exit_Click);
            // 
            // btnL649Read
            // 
            this.btnL649Read.Location = new System.Drawing.Point(215, 458);
            this.btnL649Read.Name = "btnL649Read";
            this.btnL649Read.Size = new System.Drawing.Size(118, 43);
            this.btnL649Read.TabIndex = 10;
            this.btnL649Read.Text = "&Read File";
            this.btnL649Read.UseVisualStyleBackColor = true;
            // 
            // btnL649Gen
            // 
            this.btnL649Gen.Location = new System.Drawing.Point(41, 457);
            this.btnL649Gen.Name = "btnL649Gen";
            this.btnL649Gen.Size = new System.Drawing.Size(118, 43);
            this.btnL649Gen.TabIndex = 9;
            this.btnL649Gen.Text = "&Generate";
            this.btnL649Gen.UseVisualStyleBackColor = true;
            this.btnL649Gen.Click += new System.EventHandler(this.btnL649Gen_Click);
            // 
            // txtL649
            // 
            this.txtL649.Location = new System.Drawing.Point(418, 79);
            this.txtL649.Multiline = true;
            this.txtL649.Name = "txtL649";
            this.txtL649.ReadOnly = true;
            this.txtL649.Size = new System.Drawing.Size(92, 295);
            this.txtL649.TabIndex = 8;
            this.txtL649.TextChanged += new System.EventHandler(this.txtL649_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "The winning numbers are:";
            // 
            // lbl64909
            // 
            this.lbl64909.AutoSize = true;
            this.lbl64909.Location = new System.Drawing.Point(37, 393);
            this.lbl64909.Name = "lbl64909";
            this.lbl64909.Size = new System.Drawing.Size(114, 20);
            this.lbl64909.TabIndex = 14;
            this.lbl64909.Text = "Random 0 to 9";
            // 
            // frm649
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 539);
            this.Controls.Add(this.lbl64909);
            this.Controls.Add(this.lblLMax);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn649Exit);
            this.Controls.Add(this.btnL649Read);
            this.Controls.Add(this.btnL649Gen);
            this.Controls.Add(this.txtL649);
            this.Controls.Add(this.label1);
            this.Name = "frm649";
            this.Text = "Lotto 649";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLMax;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn649Exit;
        private System.Windows.Forms.Button btnL649Read;
        private System.Windows.Forms.Button btnL649Gen;
        private System.Windows.Forms.TextBox txtL649;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl64909;
    }
}