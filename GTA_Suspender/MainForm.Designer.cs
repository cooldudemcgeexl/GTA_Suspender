namespace GTA_Suspender
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
            this.SuspendButton = new System.Windows.Forms.Button();
            this.StatusMsg = new System.Windows.Forms.Label();
            this.SuspendTimeUD = new System.Windows.Forms.NumericUpDown();
            this.SusTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SuspendTimeUD)).BeginInit();
            this.SuspendLayout();
            // 
            // SuspendButton
            // 
            this.SuspendButton.Location = new System.Drawing.Point(146, 211);
            this.SuspendButton.Name = "SuspendButton";
            this.SuspendButton.Size = new System.Drawing.Size(150, 45);
            this.SuspendButton.TabIndex = 0;
            this.SuspendButton.Text = "Suspend Game";
            this.SuspendButton.UseVisualStyleBackColor = true;
            this.SuspendButton.Click += new System.EventHandler(this.SuspendButton_Click);
            // 
            // StatusMsg
            // 
            this.StatusMsg.AutoSize = true;
            this.StatusMsg.ForeColor = System.Drawing.Color.Black;
            this.StatusMsg.Location = new System.Drawing.Point(38, 82);
            this.StatusMsg.Name = "StatusMsg";
            this.StatusMsg.Size = new System.Drawing.Size(133, 13);
            this.StatusMsg.TabIndex = 2;
            this.StatusMsg.Text = "GTA V is currently running.";
            // 
            // SuspendTimeUD
            // 
            this.SuspendTimeUD.Location = new System.Drawing.Point(285, 82);
            this.SuspendTimeUD.Name = "SuspendTimeUD";
            this.SuspendTimeUD.Size = new System.Drawing.Size(120, 20);
            this.SuspendTimeUD.TabIndex = 3;
            this.SuspendTimeUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // SusTimeLabel
            // 
            this.SusTimeLabel.AutoSize = true;
            this.SusTimeLabel.Location = new System.Drawing.Point(282, 66);
            this.SusTimeLabel.Name = "SusTimeLabel";
            this.SusTimeLabel.Size = new System.Drawing.Size(123, 13);
            this.SusTimeLabel.TabIndex = 4;
            this.SusTimeLabel.Text = "Suspend time (seconds):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 326);
            this.Controls.Add(this.SusTimeLabel);
            this.Controls.Add(this.SuspendTimeUD);
            this.Controls.Add(this.StatusMsg);
            this.Controls.Add(this.SuspendButton);
            this.Icon = global::GTA_Suspender.Properties.Resources.suspendericon;
            this.Name = "MainForm";
            this.Text = "GTA V Suspender";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SuspendTimeUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SuspendButton;
        private System.Windows.Forms.Label StatusMsg;
        private System.Windows.Forms.NumericUpDown SuspendTimeUD;
        private System.Windows.Forms.Label SusTimeLabel;
    }
}

