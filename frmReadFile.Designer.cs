namespace WinFormProject
{
    partial class frmReadFile
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
            this.rtfReadBox = new System.Windows.Forms.RichTextBox();
            this.lblReadTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtfReadBox
            // 
            this.rtfReadBox.Location = new System.Drawing.Point(22, 52);
            this.rtfReadBox.Name = "rtfReadBox";
            this.rtfReadBox.ReadOnly = true;
            this.rtfReadBox.Size = new System.Drawing.Size(631, 224);
            this.rtfReadBox.TabIndex = 0;
            this.rtfReadBox.TabStop = false;
            this.rtfReadBox.Text = "";
            // 
            // lblReadTitle
            // 
            this.lblReadTitle.AutoSize = true;
            this.lblReadTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadTitle.Location = new System.Drawing.Point(21, 13);
            this.lblReadTitle.Name = "lblReadTitle";
            this.lblReadTitle.Size = new System.Drawing.Size(71, 25);
            this.lblReadTitle.TabIndex = 1;
            this.lblReadTitle.Text = "Output";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(542, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmReadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 349);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblReadTitle);
            this.Controls.Add(this.rtfReadBox);
            this.Name = "frmReadFile";
            this.Text = "Read Form";
            this.Load += new System.EventHandler(this.frmReadFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfReadBox;
        private System.Windows.Forms.Label lblReadTitle;
        private System.Windows.Forms.Button btnExit;
    }
}