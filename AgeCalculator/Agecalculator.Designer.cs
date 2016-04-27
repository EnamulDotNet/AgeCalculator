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
            this.label3 = new System.Windows.Forms.Label();
            this.ageOnDateTextbox = new System.Windows.Forms.TextBox();
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
            this.dateOfBirthTextbox.Location = new System.Drawing.Point(216, 48);
            this.dateOfBirthTextbox.Name = "dateOfBirthTextbox";
            this.dateOfBirthTextbox.Size = new System.Drawing.Size(170, 26);
            this.dateOfBirthTextbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "(DD-MM-YYYY)";
            // 
            // ageOnDateTextbox
            // 
            this.ageOnDateTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageOnDateTextbox.Location = new System.Drawing.Point(216, 92);
            this.ageOnDateTextbox.Name = "ageOnDateTextbox";
            this.ageOnDateTextbox.Size = new System.Drawing.Size(170, 26);
            this.ageOnDateTextbox.TabIndex = 4;
            // 
            // AgeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 298);
            this.Controls.Add(this.ageOnDateTextbox);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ageOnDateTextbox;
    }
}

