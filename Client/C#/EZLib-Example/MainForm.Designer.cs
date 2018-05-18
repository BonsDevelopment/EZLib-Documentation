namespace EZLib_Example
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
            this.ShowNewsButton = new System.Windows.Forms.Button();
            this.GetVariableButton = new System.Windows.Forms.Button();
            this.GetNameButton = new System.Windows.Forms.Button();
            this.GetSerialButton = new System.Windows.Forms.Button();
            this.SilverRequirementSerial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowNewsButton
            // 
            this.ShowNewsButton.Location = new System.Drawing.Point(12, 12);
            this.ShowNewsButton.Name = "ShowNewsButton";
            this.ShowNewsButton.Size = new System.Drawing.Size(97, 23);
            this.ShowNewsButton.TabIndex = 0;
            this.ShowNewsButton.Text = "Show News";
            this.ShowNewsButton.UseVisualStyleBackColor = true;
            this.ShowNewsButton.Click += new System.EventHandler(this.ShowNewsButton_Click);
            // 
            // GetVariableButton
            // 
            this.GetVariableButton.Location = new System.Drawing.Point(12, 41);
            this.GetVariableButton.Name = "GetVariableButton";
            this.GetVariableButton.Size = new System.Drawing.Size(97, 23);
            this.GetVariableButton.TabIndex = 1;
            this.GetVariableButton.Text = "Get Variable";
            this.GetVariableButton.UseVisualStyleBackColor = true;
            this.GetVariableButton.Click += new System.EventHandler(this.GetVariableButton_Click);
            // 
            // GetNameButton
            // 
            this.GetNameButton.Location = new System.Drawing.Point(127, 12);
            this.GetNameButton.Name = "GetNameButton";
            this.GetNameButton.Size = new System.Drawing.Size(97, 23);
            this.GetNameButton.TabIndex = 2;
            this.GetNameButton.Text = "Get Name";
            this.GetNameButton.UseVisualStyleBackColor = true;
            this.GetNameButton.Click += new System.EventHandler(this.GetNameButton_Click);
            // 
            // GetSerialButton
            // 
            this.GetSerialButton.Location = new System.Drawing.Point(127, 41);
            this.GetSerialButton.Name = "GetSerialButton";
            this.GetSerialButton.Size = new System.Drawing.Size(97, 23);
            this.GetSerialButton.TabIndex = 3;
            this.GetSerialButton.Text = "Get Serial";
            this.GetSerialButton.UseVisualStyleBackColor = true;
            this.GetSerialButton.Click += new System.EventHandler(this.GetSerialButton_Click);
            // 
            // SilverRequirementSerial
            // 
            this.SilverRequirementSerial.Location = new System.Drawing.Point(230, 12);
            this.SilverRequirementSerial.Name = "SilverRequirementSerial";
            this.SilverRequirementSerial.Size = new System.Drawing.Size(97, 49);
            this.SilverRequirementSerial.TabIndex = 4;
            this.SilverRequirementSerial.Text = "Requires Silver Serial";
            this.SilverRequirementSerial.UseVisualStyleBackColor = true;
            this.SilverRequirementSerial.Click += new System.EventHandler(this.SilverRequirementSerial_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 73);
            this.Controls.Add(this.SilverRequirementSerial);
            this.Controls.Add(this.GetSerialButton);
            this.Controls.Add(this.GetNameButton);
            this.Controls.Add(this.GetVariableButton);
            this.Controls.Add(this.ShowNewsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EZLib Example";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowNewsButton;
        private System.Windows.Forms.Button GetVariableButton;
        private System.Windows.Forms.Button GetNameButton;
        private System.Windows.Forms.Button GetSerialButton;
        private System.Windows.Forms.Button SilverRequirementSerial;
    }
}

