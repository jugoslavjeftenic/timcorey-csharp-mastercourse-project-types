namespace T32_02_01_HomeworkMiniProject_WinForm
{
    partial class AddressForm
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
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetNumberLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.streetNumberTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.addAddressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(31, 9);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(128, 25);
            this.streetLabel.TabIndex = 0;
            this.streetLabel.Text = "Street name";
            // 
            // streetNumberLabel
            // 
            this.streetNumberLabel.AutoSize = true;
            this.streetNumberLabel.Location = new System.Drawing.Point(12, 47);
            this.streetNumberLabel.Name = "streetNumberLabel";
            this.streetNumberLabel.Size = new System.Drawing.Size(147, 25);
            this.streetNumberLabel.TabIndex = 0;
            this.streetNumberLabel.Text = "Street number";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(110, 84);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(49, 25);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "City";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(72, 121);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(87, 25);
            this.countryLabel.TabIndex = 0;
            this.countryLabel.Text = "Country";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(165, 6);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(199, 31);
            this.streetTextBox.TabIndex = 1;
            // 
            // streetNumberTextBox
            // 
            this.streetNumberTextBox.Location = new System.Drawing.Point(165, 44);
            this.streetNumberTextBox.Name = "streetNumberTextBox";
            this.streetNumberTextBox.Size = new System.Drawing.Size(199, 31);
            this.streetNumberTextBox.TabIndex = 2;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(165, 81);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(199, 31);
            this.cityTextBox.TabIndex = 3;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(165, 118);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(199, 31);
            this.countryTextBox.TabIndex = 4;
            // 
            // addAddressButton
            // 
            this.addAddressButton.Location = new System.Drawing.Point(382, 118);
            this.addAddressButton.Name = "addAddressButton";
            this.addAddressButton.Size = new System.Drawing.Size(161, 31);
            this.addAddressButton.TabIndex = 5;
            this.addAddressButton.Text = "Add address";
            this.addAddressButton.UseVisualStyleBackColor = true;
            this.addAddressButton.Click += new System.EventHandler(this.AddAddressButton_Click);
            // 
            // AddresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 170);
            this.Controls.Add(this.addAddressButton);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.streetNumberTextBox);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetNumberLabel);
            this.Controls.Add(this.streetLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddresForm";
            this.Text = "Add Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label streetNumberLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox streetNumberTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Button addAddressButton;
    }
}