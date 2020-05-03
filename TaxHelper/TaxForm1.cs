using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxHelper
{
    public partial class TaxForm1 : Form
    {
        public TaxForm1()
        {
            InitializeComponent();
            
        }

        //Function to check if value is numeric
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void TaxForm1_Load(object sender, EventArgs e)
        {
            //cmSalary.SelectedIndex = 0;

            
        }
        public void test()
        {

        }

        private double calculateWeekly()
        {
            double weeklyPay = 0;
            if (Decimal.TryParse(txtHourlyRate.Text, out decimal hourlyRate))
            {
                weeklyPay = Convert.ToDouble(txtHoursPerWeek.Text) * Convert.ToDouble(txtHourlyRate.Text);
            }
            else
            {
                MessageBox.Show("Not a value: Please enter a number");
            }
            return weeklyPay;
        }

        //Function calculates salary based on weekly pay, with optional textbox parameter
        private void calculateSalary(string salaryPeriod, TextBox tb = null)
        {
            double weeklyPay = 0;
            //Change to weekly as soon as value is input
            if (cmSalary.Text == "")
            {
                cmSalary.SelectedIndex = 0;
            }
            if (tb == null)
            {
                weeklyPay = calculateWeekly();
            }
            else if (tb.Text != "")
            {
                weeklyPay = calculateWeekly();
            }
            switch(salaryPeriod)
            {
                case "Fortnightly":
                    txtSalary.Text = "$" + weeklyPay * 2;
                    break;
                case "Monthly":
                    txtSalary.Text = "$" + weeklyPay * 4;
                    break;
                case "Annually":
                    txtSalary.Text = "$" + weeklyPay * 52;
                    break;
                default:
                    txtSalary.Text = "$" + weeklyPay;
                    break;
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                calculateSalary(cmSalary.Text, tb);
            }
        }

        private void cmSalary_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateSalary(cmSalary.Text);
        }
    }
}
