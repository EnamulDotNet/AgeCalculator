using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class AgeCalculator : Form
    {
        public AgeCalculator()
        {
            InitializeComponent();
            DateTime tDate = DateTime.Now;
            string toDay = tDate.ToString("dd-MM-yyyy");
            ageOnDateTextbox.Text = toDay;
        }

        private void ageOnDateTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateOfBirth = Convert.ToDateTime(dateOfBirthTextbox.Text);
                DateTime ageOnDate = Convert.ToDateTime(ageOnDateTextbox.Text);
                int bd = dateOfBirth.Day;
                int bm = dateOfBirth.Month;
                int by = dateOfBirth.Year;
                int cd = ageOnDate.Day;
                int cm = ageOnDate.Month;
                int cy = ageOnDate.Year;
                int dd, mm, yy;
                if (bd <= cd)
                {
                    dd = cd - bd;
                }
                else
                {
                    dd = cd - bd + 30;
                    bm += 1;
                }
                if (bm <= cm)
                {
                    mm = cd - bd;
                }
                else
                {
                    mm = cm - bm + 12;
                    by += 1;
                }

                yy = cy - by;

                yearTextBox.Text = yy.ToString();
                monthTextBox.Text = mm.ToString();
                dayTextBox.Text = dd.ToString();
                errLabel.Text = "";
            }
            catch (Exception)
            {

               errLabel.Text="Invalid input";
            }
            
        }
    }
}
