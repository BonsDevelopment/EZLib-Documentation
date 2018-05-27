namespace EZLib.Test
{
    partial class SerialForm
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
            this.Slot1Textbox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Slot2Textbox = new System.Windows.Forms.TextBox();
            this.Slot3Textbox = new System.Windows.Forms.TextBox();
            this.Slot4Textbox = new System.Windows.Forms.TextBox();
            this.CustomTextbox = new System.Windows.Forms.TextBox();
            this.SuffixCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Slot1Textbox
            // 
            this.Slot1Textbox.Location = new System.Drawing.Point(13, 67);
            this.Slot1Textbox.MaxLength = 5;
            this.Slot1Textbox.Name = "Slot1Textbox";
            this.Slot1Textbox.Size = new System.Drawing.Size(79, 22);
            this.Slot1Textbox.TabIndex = 0;
            this.Slot1Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(321, 95);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(111, 23);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Register Serial";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Powered by EZLib";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "EZLib Example";
            // 
            // Slot2Textbox
            // 
            this.Slot2Textbox.Location = new System.Drawing.Point(98, 67);
            this.Slot2Textbox.MaxLength = 5;
            this.Slot2Textbox.Name = "Slot2Textbox";
            this.Slot2Textbox.Size = new System.Drawing.Size(79, 22);
            this.Slot2Textbox.TabIndex = 7;
            this.Slot2Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Slot3Textbox
            // 
            this.Slot3Textbox.Location = new System.Drawing.Point(183, 67);
            this.Slot3Textbox.MaxLength = 5;
            this.Slot3Textbox.Name = "Slot3Textbox";
            this.Slot3Textbox.Size = new System.Drawing.Size(79, 22);
            this.Slot3Textbox.TabIndex = 8;
            this.Slot3Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Slot4Textbox
            // 
            this.Slot4Textbox.Location = new System.Drawing.Point(268, 67);
            this.Slot4Textbox.MaxLength = 5;
            this.Slot4Textbox.Name = "Slot4Textbox";
            this.Slot4Textbox.Size = new System.Drawing.Size(79, 22);
            this.Slot4Textbox.TabIndex = 9;
            this.Slot4Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomTextbox
            // 
            this.CustomTextbox.Enabled = false;
            this.CustomTextbox.Location = new System.Drawing.Point(353, 67);
            this.CustomTextbox.MaxLength = 5;
            this.CustomTextbox.Name = "CustomTextbox";
            this.CustomTextbox.Size = new System.Drawing.Size(79, 22);
            this.CustomTextbox.TabIndex = 10;
            this.CustomTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SuffixCheckbox
            // 
            this.SuffixCheckbox.AutoSize = true;
            this.SuffixCheckbox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuffixCheckbox.Location = new System.Drawing.Point(13, 99);
            this.SuffixCheckbox.Name = "SuffixCheckbox";
            this.SuffixCheckbox.Size = new System.Drawing.Size(55, 17);
            this.SuffixCheckbox.TabIndex = 11;
            this.SuffixCheckbox.Text = "Suffix";
            this.SuffixCheckbox.UseVisualStyleBackColor = true;
            this.SuffixCheckbox.CheckedChanged += new System.EventHandler(this.SuffixCheckbox_CheckedChanged);
            // 
            // SerialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 125);
            this.Controls.Add(this.SuffixCheckbox);
            this.Controls.Add(this.CustomTextbox);
            this.Controls.Add(this.Slot4Textbox);
            this.Controls.Add(this.Slot3Textbox);
            this.Controls.Add(this.Slot2Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.Slot1Textbox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SerialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Registration | EZLib";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Slot1Textbox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Slot2Textbox;
        private System.Windows.Forms.TextBox Slot3Textbox;
        private System.Windows.Forms.TextBox Slot4Textbox;
        private System.Windows.Forms.TextBox CustomTextbox;
        private System.Windows.Forms.CheckBox SuffixCheckbox;
    }
}