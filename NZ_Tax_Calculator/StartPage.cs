using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ_Tax_Calculator
{
    public class StartPage
    {

        public void InitializeWithQuestion()
        {
            Console.Clear();
            Console.WriteLine(" ____________________________________________");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|               Tax Calculator               |");
            Console.WriteLine("|____________________________________________|");
            Console.WriteLine("");

            Console.WriteLine("What do you want to do with our service?");
            Console.WriteLine("1. Tax Code Generation");
            Console.WriteLine("2. Tax Rate Calculation");

            StartOptionSelect();
        }

        public void StartOptionSelect()
        {
            Primary_Code primary_Code = new Primary_Code();
            Tax_Generator tax_Generator = new Tax_Generator();

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    primary_Code.Initialize_Primary_Code_Generator();
                    break;
                //Tax rate calculation
                case ConsoleKey.D2:
                    tax_Generator.Initialize_Tax_Generator();
                    break;

            }
        }


    }
}
