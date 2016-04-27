namespace AgeCalculator
{
    partial class AgeCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateOfBirthTextbox = new System.Windows.Forms.TextBox();
            this.ageOnDateTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errLabel = new System.Windows.Forms.Label();
            this.dOBdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cDdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date of Birth: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age on This Date:";
            // 
            // dateOfBirthTextbox
            // 
            this.dateOfBirthTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthTextbox.Location = new System.Drawing.Point(99, 260);
            this.dateOfBirthTextbox.Name = "dateOfBirthTextbox";
            this.dateOfBirthTextbox.Size = new System.Drawing.Size(170, 26);
            this.dateOfBirthTextbox.TabIndex = 1;
            this.dateOfBirthTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ageOnDateTextbox
            // 
            this.ageOnDateTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageOnDateTextbox.Location = new System.Drawing.Point(327, 250);
            this.ageOnDateTextbox.Name = "ageOnDateTextbox";
            this.ageOnDateTextbox.Size = new System.Drawing.Size(170, 26);
            this.ageOnDateTextbox.TabIndex = 2;
            this.ageOnDateTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(214, 125);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(161, 45);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Age: ";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextBox.Location = new System.Drawing.Point(149, 201);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.ReadOnly = true;
            this.yearTextBox.Size = new System.Drawing.Size(62, 26);
            this.yearTextBox.TabIndex = 5;
            this.yearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Years";
            // 
            // monthTextBox
            // 
            this.monthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthTextBox.Location = new System.Drawing.Point(261, 200);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.ReadOnly = true;
            this.monthTextBox.Size = new System.Drawing.Size(62, 26);
            this.monthTextBox.TabIndex = 5;
            this.monthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Months";
            // 
            // dayTextBox
            // 
            this.dayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTextBox.Location = new System.Drawing.Point(381, 200);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.ReadOnly = true;
            this.dayTextBox.Size = new System.Drawing.Size(61, 26);
            this.dayTextBox.TabIndex = 5;
            this.dayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(444, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Days";
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.ForeColor = System.Drawing.Color.Red;
            this.errLabel.Location = new System.Drawing.Point(216, 77);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(0, 13);
            this.errLabel.TabIndex = 7;
            // 
            // dOBdateTimePicker
            // 
            this.dOBdateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dOBdateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dOBdateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOBdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dOBdateTimePicker.Location = new System.Drawing.Point(214, 49);
            this.dOBdateTimePicker.Name = "dOBdateTimePicker";
            this.dOBdateTimePicker.Size = new System.Drawing.Size(161, 26);
            this.dOBdateTimePicker.TabIndex = 8;
            this.dOBdateTimePicker.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // cDdateTimePicker
            // 
            this.cDdateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.cDdateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.cDdateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cDdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cDdateTimePicker.Location = new System.Drawing.Point(214, 93);
            this.cDdateTimePicker.Name = "cDdateTimePicker";
            this.cDdateTimePicker.Size = new System.Drawing.Size(161, 26);
            this.cDdateTimePicker.TabIndex = 8;
            this.cDdateTimePicker.Value = new System.DateTime(2016, 4, 27, 0, 0, 0, 0);
            // 
            // AgeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 298);
            this.Controls.Add(this.cDdateTimePicker);
            this.Controls.Add(this.dOBdateTimePicker);
            this.Controls.Add(this.errLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.ageOnDateTextbox);
            this.Controls.Add(this.dateOfBirthTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgeCalculator";
            this.Text = "Age Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dateOfBirthTextbox;
        private System.Windows.Forms.TextBox ageOnDateTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label errLabel;
        private System.Windows.Forms.DateTimePicker dOBdateTimePicker;
        private System.Windows.Forms.DateTimePicker cDdateTimePicker;
    }
}

