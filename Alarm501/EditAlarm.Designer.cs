namespace Alarm501
{
    partial class EditAlarm
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
            this.AlarmComboBox = new System.Windows.Forms.ComboBox();
            this.OnCheckBox = new System.Windows.Forms.CheckBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AlarmComboBox
            // 
            this.AlarmComboBox.FormattingEnabled = true;
            this.AlarmComboBox.Location = new System.Drawing.Point(35, 32);
            this.AlarmComboBox.Name = "AlarmComboBox";
            this.AlarmComboBox.Size = new System.Drawing.Size(216, 24);
            this.AlarmComboBox.TabIndex = 0;
            // 
            // OnCheckBox
            // 
            this.OnCheckBox.AutoSize = true;
            this.OnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OnCheckBox.Location = new System.Drawing.Point(268, 32);
            this.OnCheckBox.Name = "OnCheckBox";
            this.OnCheckBox.Size = new System.Drawing.Size(53, 24);
            this.OnCheckBox.TabIndex = 1;
            this.OnCheckBox.Text = "On";
            this.OnCheckBox.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(35, 77);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(118, 42);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(203, 77);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(118, 42);
            this.SetButton.TabIndex = 3;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            // 
            // EditAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 131);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OnCheckBox);
            this.Controls.Add(this.AlarmComboBox);
            this.Name = "EditAlarm";
            this.Text = "EditAlarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AlarmComboBox;
        private System.Windows.Forms.CheckBox OnCheckBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SetButton;
    }
}