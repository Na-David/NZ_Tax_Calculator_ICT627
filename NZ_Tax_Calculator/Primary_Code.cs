using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ_Tax_Calculator
{
    public class Primary_Code
    {
        public void Initialize_Primary_Code_Generator()
        {
            Generate_Primary_Code();
            Console.ReadKey();
        }
        public void Generate_Primary_Code()
        {
            StartPage startPage = new StartPage();
            Secondary_Code secondary_Code = new Secondary_Code();


            Console.Clear();
            Console.WriteLine("Do you receive an income tested benefit?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            if (Console.ReadKey().Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("Is this tax code for your main or highest source of income?");
                Console.WriteLine("1. Yes 2. No");

                if (Console.ReadKey().Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("Are you a New Zealand tax resident?");
                    Console.WriteLine("1. Yes 2. No");

                    if (Console.ReadKey().Key == ConsoleKey.D1)
                    {

                        Console.Clear();
                        Console.WriteLine("Is your annual income likely to be between $24,000 - $48,000?");
                        Console.WriteLine("1. Yes 2. No");

                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            Console.Clear();
                            Console.WriteLine("Are you or your partner entitled to working for Families Tax Credits or \nAn overseas equivalent or do you receive NZ Super, veteran's pension or \nAn overseas equivalent?");
                            Console.WriteLine("1. Yes 2. No");
                            if (Console.ReadKey().Key == ConsoleKey.D2)
                            {
                                Console.Clear();
                                Console.WriteLine("Do you have a new Zealand Student Loan?");
                                Console.WriteLine("1. Yes 2. No");

                                if (Console.ReadKey().Key == ConsoleKey.D1)
                                {
                                    string Tax_Code = "ME SL";
                                    Show_Tax_Status(Tax_Code);
                                }
                                else if (Console.ReadKey().Key == ConsoleKey.D2)
                                {
                                    string Tax_Code = "ME";
                                    Show_Tax_Status(Tax_Code);
                                }
                            }
                            else if (Console.ReadKey().Key == ConsoleKey.D1)
                            {
                                Console.Clear();
                                Console.WriteLine("Do you have a new Zealand Student Loan?");
                                Console.WriteLine("1. Yes 2. No");

                                if (Console.ReadKey().Key == ConsoleKey.D1)
                                {
                                    string Tax_Code = "M SL";
                                    Show_Tax_Status(Tax_Code);
                                }
                                else if (Console.ReadKey().Key == ConsoleKey.D2)
                                {
                                    string Tax_Code = "M";
                                    Show_Tax_Status(Tax_Code);
                                }
                            }
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            Console.Clear();
                            Console.WriteLine("Do you have a New Zealand student loan?");
                            Console.WriteLine("1. Yes 2. No");

                            if (Console.ReadKey().Key == ConsoleKey.D1)
                            {
                                string Tax_Code = "M SL";
                                Show_Tax_Status(Tax_Code);
                            }
                            else if (Console.ReadKey().Key == ConsoleKey.D2)
                            {
                                string Tax_Code = "M";
                                Show_Tax_Status(Tax_Code);
                            }
                        }
                    }
                    else if (Console.ReadKey().Key == ConsoleKey.D2)
                    {
                        Console.Clear();
                        Console.WriteLine("Do you have a New Zealand student loan?");
                        Console.WriteLine("1. Yes 2. No");

                        if (Console.ReadKey().Key == ConsoleKey.D1)
                        {
                            string Tax_Code = "M SL";
                            Show_Tax_Status(Tax_Code);
                        }
                        else if (Console.ReadKey().Key == ConsoleKey.D2)
                        {
                            string Tax_Code = "M";
                            Show_Tax_Status(Tax_Code);
                        }
                    }
                }
                else if (Console.ReadKey().Key == ConsoleKey.D2)
                {
                    secondary_Code.Generate_Secondary_Code();
                }
            }
            else if (Console.ReadKey().Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine("Is this tax code for the income tested benefit?");
                Console.WriteLine("1. Yes 2. No");

                if (Console.ReadKey().Key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("Your tax code is M!");
                    Console.WriteLine("Press Enter to go back to the Start Page!");
                    Console.ReadKey();
                    startPage.InitializeWithQuestion();
                }
                else if (Console.ReadKey().Key == ConsoleKey.D2)
                {
                    secondary_Code.Generate_Secondary_Code();
                }
            }
        }

        public void Show_Tax_Status(string Tax_Code)
        {
            StartPage startPage = new StartPage();

            Console.Clear();
            Console.WriteLine("Your tax code is " + Tax_Code);
            Console.WriteLine("Press Enter to go back to the Start Page!");
            Console.ReadKey();
            startPage.InitializeWithQuestion();
        }

    }
}
