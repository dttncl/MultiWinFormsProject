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
            this.SuspendLayout();
            // 
            // rtfReadBox
            // 
            this.rtfReadBox.Location = new System.Drawing.Point(36, 67);
            this.rtfReadBox.Name = "rtfReadBox";
            this.rtfReadBox.ReadOnly = true;
            this.rtfReadBox.Size = new System.Drawing.Size(508, 326);
            this.rtfReadBox.TabIndex = 0;
            this.rtfReadBox.Text = "";
            this.rtfReadBox.TextChanged += new System.EventHandler(this.rtfReadBox_TextChanged);
            // 
            // lblReadTitle
            // 
            this.lblReadTitle.AutoSize = true;
            this.lblReadTitle.Location = new System.Drawing.Point(32, 20);
            this.lblReadTitle.Name = "lblReadTitle";
            this.lblReadTitle.Size = new System.Drawing.Size(58, 20);
            this.lblReadTitle.TabIndex = 1;
            this.lblReadTitle.Text = "Output";
            // 
            // frmReadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 431);
            this.Controls.Add(this.lblReadTitle);
            this.Controls.Add(this.rtfReadBox);
            this.Name = "frmReadFile";
            this.Text = "frmReadFile";
            this.Load += new System.EventHandler(this.frmReadFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfReadBox;
        private System.Windows.Forms.Label lblReadTitle;
    }
}