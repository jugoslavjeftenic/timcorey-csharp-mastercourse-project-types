namespace T32_02_02_SolutionMiniProject_WinForm
{
    partial class AddressEntry
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
            this.streetAddresLabel = new System.Windows.Forms.Label();
            this.streetAddressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.saveRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // streetAddresLabel
            // 
            this.streetAddresLabel.AutoSize = true;
            this.streetAddresLabel.Location = new System.Drawing.Point(25, 24);
            this.streetAddresLabel.Name = "streetAddresLabel";
            this.streetAddresLabel.Size = new System.Drawing.Size(154, 25);
            this.streetAddresLabel.TabIndex = 0;
            this.streetAddresLabel.Text = "Street Address";
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.Location = new System.Drawing.Point(185, 21);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.Size = new System.Drawing.Size(283, 31);
            this.streetAddressTextBox.TabIndex = 0;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(185, 57);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(283, 31);
            this.cityTextBox.TabIndex = 1;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(130, 60);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(49, 25);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "City";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(185, 93);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(283, 31);
            this.stateTextBox.TabIndex = 2;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(117, 96);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(62, 25);
            this.stateLabel.TabIndex = 4;
            this.stateLabel.Text = "State";
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(185, 129);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(283, 31);
            this.zipCodeTextBox.TabIndex = 3;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(80, 132);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(99, 25);
            this.zipCodeLabel.TabIndex = 6;
            this.zipCodeLabel.Text = "Zip Code";
            // 
            // saveRecordButton
            // 
            this.saveRecordButton.Location = new System.Drawing.Point(170, 205);
            this.saveRecordButton.Name = "saveRecordButton";
            this.saveRecordButton.Size = new System.Drawing.Size(163, 44);
            this.saveRecordButton.TabIndex = 4;
            this.saveRecordButton.Text = "Save";
            this.saveRecordButton.UseVisualStyleBackColor = true;
            this.saveRecordButton.Click += new System.EventHandler(this.saveRecordButton_Click);
            // 
            // AddressEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 272);
            this.Controls.Add(this.saveRecordButton);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.zipCodeLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetAddressTextBox);
            this.Controls.Add(this.streetAddresLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddressEntry";
            this.Text = "Address Entry Form by Tim Corey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label streetAddresLabel;
        private System.Windows.Forms.TextBox streetAddressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.Button saveRecordButton;
    }
}