using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ_Tax_Calculator
{
    public class Tax_Generator
    {
        public static double tax;
        public static double income;
        public void Initialize_Tax_Generator()
        {
            TakeHomePay takeHomePay = new TakeHomePay();
            Console.Clear();
            Console.WriteLine("Please enter your income: ");
            income = double.Parse(Console.ReadLine());
            Console.WriteLine("Your Tax is {0}!!", Calculate());
            takeHomePay.question();
            Console.ReadKey();

        }
        public double Calculate()
        {
            if (income <= 14000)
            {
                tax = income * 0.105;
            }
            else if (14000 < income && income <= 48000)

            {
                tax = (income - 14000) * 0.175 + (14000 * 0.105);
            }
            else if (48000 < income && income <= 70000)
            {
                tax = (income - 48000) * 0.3 + (34000 * 0.175) + (14000 * 0.105);
            }
            else if (income > 70000)
            {
                tax = (income - 70000) * 0.33 + (22000 * 0.3) + (34000 * 0.175) + (14000 * 0.105);
            }
            return tax;



        }


    }

}

