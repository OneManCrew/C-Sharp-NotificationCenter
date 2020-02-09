namespace TestNotificationCenter
{
    partial class MainScreen
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.light3 = new TestNotificationCenter.Light();
            this.light2 = new TestNotificationCenter.Light();
            this.light1 = new TestNotificationCenter.Light();
            this.switch1 = new TestNotificationCenter.Switch();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 285);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(494, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslabel
            // 
            this.statuslabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(88, 21);
            this.statuslabel.Text = "Ligths OFF";
            // 
            // light3
            // 
            this.light3.Location = new System.Drawing.Point(349, 29);
            this.light3.Name = "light3";
            this.light3.Size = new System.Drawing.Size(94, 94);
            this.light3.TabIndex = 3;
            // 
            // light2
            // 
            this.light2.Location = new System.Drawing.Point(197, 29);
            this.light2.Name = "light2";
            this.light2.Size = new System.Drawing.Size(94, 94);
            this.light2.TabIndex = 2;
            // 
            // light1
            // 
            this.light1.Location = new System.Drawing.Point(35, 29);
            this.light1.Name = "light1";
            this.light1.Size = new System.Drawing.Size(94, 94);
            this.light1.TabIndex = 1;
            // 
            // switch1
            // 
            this.switch1.Location = new System.Drawing.Point(197, 172);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(80, 110);
            this.switch1.TabIndex = 0;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 311);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.light3);
            this.Controls.Add(this.light2);
            this.Controls.Add(this.light1);
            this.Controls.Add(this.switch1);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreenFormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Switch switch1;
        private Light light1;
        private Light light2;
        private Light light3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel;
    }
}

