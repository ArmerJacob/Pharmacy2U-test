namespace Pharmacy2U_test
{
    partial class ConversionWindow
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
            this.ConvertInputBox = new System.Windows.Forms.TextBox();
            this.ConvertOutputBox = new System.Windows.Forms.TextBox();
            this.CurrencyConvertTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.AuditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConvertInputBox
            // 
            this.ConvertInputBox.Location = new System.Drawing.Point(12, 82);
            this.ConvertInputBox.Name = "ConvertInputBox";
            this.ConvertInputBox.Size = new System.Drawing.Size(100, 20);
            this.ConvertInputBox.TabIndex = 0;
            this.ConvertInputBox.TextChanged += new System.EventHandler(this.ConvertInputBox_TextChanged);
            // 
            // ConvertOutputBox
            // 
            this.ConvertOutputBox.Location = new System.Drawing.Point(307, 126);
            this.ConvertOutputBox.Name = "ConvertOutputBox";
            this.ConvertOutputBox.ReadOnly = true;
            this.ConvertOutputBox.Size = new System.Drawing.Size(100, 20);
            this.ConvertOutputBox.TabIndex = 1;
            // 
            // CurrencyConvertTo
            // 
            this.CurrencyConvertTo.FormattingEnabled = true;
            this.CurrencyConvertTo.Items.AddRange(new object[] {
            "USD",
            "AUD",
            "EUR"});
            this.CurrencyConvertTo.Location = new System.Drawing.Point(12, 125);
            this.CurrencyConvertTo.Name = "CurrencyConvertTo";
            this.CurrencyConvertTo.Size = new System.Drawing.Size(121, 21);
            this.CurrencyConvertTo.TabIndex = 2;
            this.CurrencyConvertTo.Text = "USD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "GBP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Convert To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Currency Conversion Calculator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter an ammount you wish to calculate into the GBP box, and select the currency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "to convert it to, press \"Convert!\" and it shal calcuate the corencys value.";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(177, 123);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 9;
            this.ConvertButton.Text = "Convert!";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // AuditButton
            // 
            this.AuditButton.Location = new System.Drawing.Point(307, 82);
            this.AuditButton.Name = "AuditButton";
            this.AuditButton.Size = new System.Drawing.Size(75, 23);
            this.AuditButton.TabIndex = 10;
            this.AuditButton.Text = "Audit";
            this.AuditButton.UseVisualStyleBackColor = true;
            this.AuditButton.Click += new System.EventHandler(this.AuditButton_Click);
            // 
            // ConversionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 158);
            this.Controls.Add(this.AuditButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrencyConvertTo);
            this.Controls.Add(this.ConvertOutputBox);
            this.Controls.Add(this.ConvertInputBox);
            this.Name = "ConversionWindow";
            this.Text = "Pharmacy2U Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConvertInputBox;
        private System.Windows.Forms.TextBox ConvertOutputBox;
        private System.Windows.Forms.ComboBox CurrencyConvertTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button AuditButton;
    }
}

