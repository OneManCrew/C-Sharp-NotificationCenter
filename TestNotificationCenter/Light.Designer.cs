namespace TestNotificationCenter
{
    partial class Light
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ligthPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ligthPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ligthPictureBox
            // 
            this.ligthPictureBox.BackgroundImage = global::TestNotificationCenter.Properties.Resources.light_off;
            this.ligthPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ligthPictureBox.Location = new System.Drawing.Point(0, 0);
            this.ligthPictureBox.Name = "ligthPictureBox";
            this.ligthPictureBox.Size = new System.Drawing.Size(94, 94);
            this.ligthPictureBox.TabIndex = 0;
            this.ligthPictureBox.TabStop = false;
            // 
            // Light
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ligthPictureBox);
            this.Name = "Light";
            this.Size = new System.Drawing.Size(94, 94);
            ((System.ComponentModel.ISupportInitialize)(this.ligthPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ligthPictureBox;
    }
}
