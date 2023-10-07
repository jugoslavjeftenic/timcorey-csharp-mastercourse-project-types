﻿namespace T32_01_01_WinForm_MessageWall
{
    partial class Dashboard
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.messageListBoxLabel = new System.Windows.Forms.Label();
            this.addMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.messageLabel.Location = new System.Drawing.Point(37, 38);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(112, 29);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Message";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(155, 35);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(295, 35);
            this.messageTextBox.TabIndex = 1;
            // 
            // messageListBox
            // 
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 29;
            this.messageListBox.Location = new System.Drawing.Point(42, 136);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(408, 207);
            this.messageListBox.TabIndex = 3;
            // 
            // messageListBoxLabel
            // 
            this.messageListBoxLabel.AutoSize = true;
            this.messageListBoxLabel.Location = new System.Drawing.Point(37, 104);
            this.messageListBoxLabel.Name = "messageListBoxLabel";
            this.messageListBoxLabel.Size = new System.Drawing.Size(124, 29);
            this.messageListBoxLabel.TabIndex = 3;
            this.messageListBoxLabel.Text = "Messages";
            // 
            // addMessage
            // 
            this.addMessage.Location = new System.Drawing.Point(456, 35);
            this.addMessage.Name = "addMessage";
            this.addMessage.Size = new System.Drawing.Size(103, 35);
            this.addMessage.TabIndex = 2;
            this.addMessage.Text = "Add";
            this.addMessage.UseVisualStyleBackColor = true;
            this.addMessage.Click += new System.EventHandler(this.AddMessage_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(593, 380);
            this.Controls.Add(this.addMessage);
            this.Controls.Add(this.messageListBoxLabel);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.messageLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.Label messageListBoxLabel;
        private System.Windows.Forms.Button addMessage;
    }
}

