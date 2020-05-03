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

            
        }

        //Calculate weekly pay based on hourly rate and hours per week
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
            //Preventes messagebox showing when textbox is empty
            else if (tb.Text != "")
            {
                weeklyPay = calculateWeekly();
            }
            //Change salary amount based on what salary period is selected.
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

        //Event handler for when textbox text has been changed
        private void textChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            //Check if textbox exists
            if (tb != null)
            {
                calculateSalary(cmSalary.Text, tb);
            }
        }

        //Single handler for Combobox, when changed it calculates again
        private void cmSalary_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculateSalary(cmSalary.Text);
        }
    }
}
