namespace Alarm501
{
    partial class Form1
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
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SnoozeButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.AlarmListView = new System.Windows.Forms.ListView();
            this.AlarmText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(179, 46);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(102, 65);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(55, 46);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(102, 65);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SnoozeButton
            // 
            this.SnoozeButton.Location = new System.Drawing.Point(55, 425);
            this.SnoozeButton.Name = "SnoozeButton";
            this.SnoozeButton.Size = new System.Drawing.Size(102, 66);
            this.SnoozeButton.TabIndex = 2;
            this.SnoozeButton.Text = "Snooze";
            this.SnoozeButton.UseVisualStyleBackColor = true;
            this.SnoozeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(179, 425);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(102, 66);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // AlarmListView
            // 
            this.AlarmListView.HideSelection = false;
            this.AlarmListView.Location = new System.Drawing.Point(55, 132);
            this.AlarmListView.Name = "AlarmListView";
            this.AlarmListView.Size = new System.Drawing.Size(226, 222);
            this.AlarmListView.TabIndex = 4;
            this.AlarmListView.UseCompatibleStateImageBehavior = false;
            // 
            // AlarmText
            // 
            this.AlarmText.Location = new System.Drawing.Point(78, 376);
            this.AlarmText.Name = "AlarmText";
            this.AlarmText.Size = new System.Drawing.Size(177, 22);
            this.AlarmText.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 503);
            this.Controls.Add(this.AlarmText);
            this.Controls.Add(this.AlarmListView);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.SnoozeButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Name = "Form1";
            this.Text = "Alarm501";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SnoozeButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.ListView AlarmListView;
        private System.Windows.Forms.TextBox AlarmText;
    }
}

