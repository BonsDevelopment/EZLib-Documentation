namespace EZLib.Test
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
            this.UsernameLabel1 = new System.Windows.Forms.Label();
            this.EmailLabel1 = new System.Windows.Forms.Label();
            this.SerialLabel1 = new System.Windows.Forms.Label();
            this.ExpirationDateLabel1 = new System.Windows.Forms.Label();
            this.SerialLabel2 = new System.Windows.Forms.Label();
            this.ExpirationDateLabel2 = new System.Windows.Forms.Label();
            this.EmailLabel2 = new System.Windows.Forms.Label();
            this.UsernameLabel2 = new System.Windows.Forms.Label();
            this.FetchVariableButton = new System.Windows.Forms.Button();
            this.FetchHWIDButton = new System.Windows.Forms.Button();
            this.FetchNewsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLabel1
            // 
            this.UsernameLabel1.AutoSize = true;
            this.UsernameLabel1.Location = new System.Drawing.Point(12, 9);
            this.UsernameLabel1.Name = "UsernameLabel1";
            this.UsernameLabel1.Size = new System.Drawing.Size(61, 13);
            this.UsernameLabel1.TabIndex = 0;
            this.UsernameLabel1.Text = "Username:";
            // 
            // EmailLabel1
            // 
            this.EmailLabel1.AutoSize = true;
            this.EmailLabel1.Location = new System.Drawing.Point(12, 31);
            this.EmailLabel1.Name = "EmailLabel1";
            this.EmailLabel1.Size = new System.Drawing.Size(81, 13);
            this.EmailLabel1.TabIndex = 1;
            this.EmailLabel1.Text = "Email Address:";
            // 
            // SerialLabel1
            // 
            this.SerialLabel1.AutoSize = true;
            this.SerialLabel1.Location = new System.Drawing.Point(12, 70);
            this.SerialLabel1.Name = "SerialLabel1";
            this.SerialLabel1.Size = new System.Drawing.Size(38, 13);
            this.SerialLabel1.TabIndex = 2;
            this.SerialLabel1.Text = "Serial:";
            // 
            // ExpirationDateLabel1
            // 
            this.ExpirationDateLabel1.AutoSize = true;
            this.ExpirationDateLabel1.Location = new System.Drawing.Point(12, 92);
            this.ExpirationDateLabel1.Name = "ExpirationDateLabel1";
            this.ExpirationDateLabel1.Size = new System.Drawing.Size(89, 13);
            this.ExpirationDateLabel1.TabIndex = 3;
            this.ExpirationDateLabel1.Text = "Expiration Date:";
            // 
            // SerialLabel2
            // 
            this.SerialLabel2.AutoSize = true;
            this.SerialLabel2.Location = new System.Drawing.Point(56, 70);
            this.SerialLabel2.Name = "SerialLabel2";
            this.SerialLabel2.Size = new System.Drawing.Size(26, 13);
            this.SerialLabel2.TabIndex = 4;
            this.SerialLabel2.Text = "N/A";
            // 
            // ExpirationDateLabel2
            // 
            this.ExpirationDateLabel2.AutoSize = true;
            this.ExpirationDateLabel2.Location = new System.Drawing.Point(107, 92);
            this.ExpirationDateLabel2.Name = "ExpirationDateLabel2";
            this.ExpirationDateLabel2.Size = new System.Drawing.Size(26, 13);
            this.ExpirationDateLabel2.TabIndex = 5;
            this.ExpirationDateLabel2.Text = "N/A";
            // 
            // EmailLabel2
            // 
            this.EmailLabel2.AutoSize = true;
            this.EmailLabel2.Location = new System.Drawing.Point(99, 31);
            this.EmailLabel2.Name = "EmailLabel2";
            this.EmailLabel2.Size = new System.Drawing.Size(26, 13);
            this.EmailLabel2.TabIndex = 6;
            this.EmailLabel2.Text = "N/A";
            // 
            // UsernameLabel2
            // 
            this.UsernameLabel2.AutoSize = true;
            this.UsernameLabel2.Location = new System.Drawing.Point(79, 9);
            this.UsernameLabel2.Name = "UsernameLabel2";
            this.UsernameLabel2.Size = new System.Drawing.Size(26, 13);
            this.UsernameLabel2.TabIndex = 7;
            this.UsernameLabel2.Text = "N/A";
            // 
            // FetchVariableButton
            // 
            this.FetchVariableButton.Location = new System.Drawing.Point(248, 116);
            this.FetchVariableButton.Name = "FetchVariableButton";
            this.FetchVariableButton.Size = new System.Drawing.Size(90, 23);
            this.FetchVariableButton.TabIndex = 8;
            this.FetchVariableButton.Text = "Fetch Variable";
            this.FetchVariableButton.UseVisualStyleBackColor = true;
            this.FetchVariableButton.Click += new System.EventHandler(this.FetchVariableButton_Click);
            // 
            // FetchHWIDButton
            // 
            this.FetchHWIDButton.Location = new System.Drawing.Point(15, 116);
            this.FetchHWIDButton.Name = "FetchHWIDButton";
            this.FetchHWIDButton.Size = new System.Drawing.Size(118, 23);
            this.FetchHWIDButton.TabIndex = 9;
            this.FetchHWIDButton.Text = "Fetch Hardware ID";
            this.FetchHWIDButton.UseVisualStyleBackColor = true;
            this.FetchHWIDButton.Click += new System.EventHandler(this.FetchHWIDButton_Click);
            // 
            // FetchNewsButton
            // 
            this.FetchNewsButton.Location = new System.Drawing.Point(139, 116);
            this.FetchNewsButton.Name = "FetchNewsButton";
            this.FetchNewsButton.Size = new System.Drawing.Size(103, 23);
            this.FetchNewsButton.TabIndex = 10;
            this.FetchNewsButton.Text = "Fetch News";
            this.FetchNewsButton.UseVisualStyleBackColor = true;
            this.FetchNewsButton.Click += new System.EventHandler(this.FetchNewsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 151);
            this.Controls.Add(this.FetchNewsButton);
            this.Controls.Add(this.FetchHWIDButton);
            this.Controls.Add(this.FetchVariableButton);
            this.Controls.Add(this.UsernameLabel2);
            this.Controls.Add(this.EmailLabel2);
            this.Controls.Add(this.ExpirationDateLabel2);
            this.Controls.Add(this.SerialLabel2);
            this.Controls.Add(this.ExpirationDateLabel1);
            this.Controls.Add(this.SerialLabel1);
            this.Controls.Add(this.EmailLabel1);
            this.Controls.Add(this.UsernameLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel1;
        private System.Windows.Forms.Label EmailLabel1;
        private System.Windows.Forms.Label SerialLabel1;
        private System.Windows.Forms.Label ExpirationDateLabel1;
        private System.Windows.Forms.Label SerialLabel2;
        private System.Windows.Forms.Label ExpirationDateLabel2;
        private System.Windows.Forms.Label EmailLabel2;
        private System.Windows.Forms.Label UsernameLabel2;
        private System.Windows.Forms.Button FetchVariableButton;
        private System.Windows.Forms.Button FetchHWIDButton;
        private System.Windows.Forms.Button FetchNewsButton;
    }
}