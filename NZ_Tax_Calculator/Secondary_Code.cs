using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ_Tax_Calculator
{
    public class Secondary_Code
    {

        public void Initialize_Secondary_Code_Generator()
        {
            Generate_Secondary_Code();
            Console.ReadKey();
        }
        public void Generate_Secondary_Code()
        {
            StartPage startPage = new StartPage();
            Primary_Code primary_code = new Primary_Code();

            Console.Clear();
            Console.WriteLine("Is your annual income from all source likely to be $14,000 or less?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");


            if (Console.ReadKey().Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("Is your annual income from all soures likely to be between $14,001 - $48,000?");
                Console.WriteLine("1. Yes 2. No");

                if (Console.ReadKey().Key == ConsoleKey.D2)
                {
                    Console.Clear();
                    Console.WriteLine("Is your annual income from all sources likely to be between $48,001 - $70,000?");
                    Console.WriteLine("1. Yes 2. No");

                    if (Console.ReadKey().Key == ConsoleKey.D2)
                    {
                        Console.Clear();
                        Console.WriteLine("Do you have a student loan?");
                        Console.WriteLine("1. Yes 2. No");

                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            string Tax_Code = "ST SL";
                            primary_code.Show_Tax_Status(Tax_Code);
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            string Tax_Code = "ST";
                            primary_code.Show_Tax_Status(Tax_Code);
                        }
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.D1)
                    {
                        Console.Clear();
                        Console.WriteLine("Do you have a student loan?");
                        Console.WriteLine("1. Yes 2. No");

                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            string Tax_Code = "SH SL";
                            primary_code.Show_Tax_Status(Tax_Code);
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            string Tax_Code = "SH";
                            primary_code.Show_Tax_Status(Tax_Code);
                        }
                    }
                }
                else if (Console.ReadKey().Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("Do you have a student loan?");
                    Console.WriteLine("1. Yes 2. No");

                    if (Console.ReadKey().Key == ConsoleKey.D1)
                    {
                        string Tax_Code = "S SL";
                        primary_code.Show_Tax_Status(Tax_Code);
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.D2)
                    {
                        string Tax_Code = "S";
                        primary_code.Show_Tax_Status(Tax_Code);
                    }
                }
            }
            else if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine("Do you have a student loan?");
                Console.WriteLine("1. Yes 2. No");

                if (Console.ReadKey().Key == ConsoleKey.D1)
                {
                    string Tax_Code = "SB SL";
                    primary_code.Show_Tax_Status(Tax_Code);
                }
                else if (Console.ReadKey().Key == ConsoleKey.D2)
                {
                    string Tax_Code = "SB";
                    primary_code.Show_Tax_Status(Tax_Code);
                }
            }
        }
    }
}
