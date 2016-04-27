using System;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class AgeCalculator : Form
    {
        public AgeCalculator()
        {
            InitializeComponent();
            cDdateTimePicker.Value = DateTime.Now;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
           
      
                int bd = dOBdateTimePicker.Value.Day;
                int bm = dOBdateTimePicker.Value.Month;
                int by = dOBdateTimePicker.Value.Year;
                int cd = cDdateTimePicker.Value.Day;
                int cm = cDdateTimePicker.Value.Month;
                int cy = cDdateTimePicker.Value.Year;
                int dd, mm;
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
                    mm = cm - bm;
                }
                else
                {
                    mm = cm - bm + 12;
                    by += 1;
                }

                if (by <= cy)
                {
                    int yy = cy - by;
                    if (dd==30)
                    {
                        dd = 0;
                        mm += 1;
                        if (mm==12)
                        {
                            mm = 0;
                            yy += 1;
                        }
                    }
                    yearTextBox.Text = yy.ToString();
                    monthTextBox.Text = mm.ToString();
                    dayTextBox.Text = dd.ToString();
                    errLabel.Text = "";
                }
                else
                {
                    errLabel.Text = "Age on date can't be earlier than DOB";
                }
                
            
        }
    }
}
