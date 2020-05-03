using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxHelper
{
    class TaxRate
    {
        private string bracket;
        private int taxableIncome;

        public string Bracket { get => bracket; set => bracket = value; }

        public int determineBracket(int grossIncome)
        {
            if (grossIncome < 18200)
            {
                return 0;
            }
            else if (grossIncome > 18201 && grossIncome < 37000)
            {
                return 1;
            }
            else if (grossIncome > 37001 && grossIncome < 90000)
            {
                return 2;
            }
            else if (grossIncome > 90001 && grossIncome < 180000)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        public double CalculateTax(int income)
        {
            double taxAmount = 0;
            //$100,000

            //No tax needed
            if (determineBracket(income) == 0)
            {
                return 0;
            }
            else if (determineBracket(income) == 1)
            {
                taxAmount = (income - 18201) * 0.19;
            }
            else if (determineBracket(income) == 2)
            {
                taxAmount = 3572 + (income - 37001) * 0.325;
            }
            else if (determineBracket(income) == 3)
            {
                taxAmount = 20797 + (income - 90001) * 0.37;
            }
            else
            {
                taxAmount = 54096 + (income - 180000) * 0.45;
            }
            return taxAmount;
        }

        public double CalculateSalary(int hourlyRate)
        {
            return 0;
        }




    }
}


//$0 – $18,200
//use methods to calculate tax and return the taxed amount?

//FTE: 43,134.96
//First Week:  1,493 PAY | Deductions: 188 | 67.50 hours
//Second Week: 1,621 PAY | Deductions: 358 | 75 Hours/7.25 Overtime

