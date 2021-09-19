using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ_Tax_Calculator
{
    public class TakeHomePay
    {
        public void question()
        {
            Console.WriteLine("");
            Console.WriteLine("Please choose one of belows for you.");
            Console.WriteLine("1. Weekly Take Home Pay");
            Console.WriteLine("2. Fortnightly Take Home Pay");
            Console.WriteLine("3. Monthly TakeHomePay");

            Answer();
        }

        public void Answer()
        {
            Weekly weekly = new Weekly();
            Fortnightly fortnightly = new Fortnightly();
            Monthly monthly = new Monthly();

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    weekly.weekly_TakeHomePay();
                    break;
                case ConsoleKey.D2:
                    fortnightly.fortnightly_TakeHomePay();
                    break;
                case ConsoleKey.D3:
                    monthly.monthly_TakeHomePay();
                    break;
            }
        }



    }

    public class TakeHomePayInterface
    {
        public void GenerateInterface(double Take_Home_Pay)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine(" ___________________________________________");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|            Here is your result            |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("| Your annual income  is : NZD " + Tax_Generator.income);
            Console.WriteLine("| Your Tax Payable is : NZD " + Tax_Generator.tax);
            Console.WriteLine("| Your Weekly take home pay is : NZD " + Math.Round(Take_Home_Pay, 2));
            Console.WriteLine("|___________________________________________|");
        }

        public void StartNewPage()
        {
            Console.ReadKey();
            StartPage new_start = new StartPage();
            new_start.InitializeWithQuestion();
        }
    }

    public class Weekly : TakeHomePayInterface
    {
        TakeHomePayInterface THPInterface = new TakeHomePayInterface();
        public void weekly_TakeHomePay()
        {
            double Take_Home_Pay;
            Take_Home_Pay = (Tax_Generator.income - Tax_Generator.tax) / 52;
            THPInterface.GenerateInterface(Take_Home_Pay);

            
        }
    }

    public class Fortnightly : TakeHomePayInterface
    {
        TakeHomePayInterface THPInterface = new TakeHomePayInterface();
        public void fortnightly_TakeHomePay()
        {
            double Take_Home_Pay;
            Take_Home_Pay = (Tax_Generator.income - Tax_Generator.tax) / 26;
            THPInterface.GenerateInterface(Take_Home_Pay);

            THPInterface.StartNewPage();
        }
    }


    public class Monthly : TakeHomePayInterface
    {
        TakeHomePayInterface THPInterface = new TakeHomePayInterface();
        public void monthly_TakeHomePay()
        {
            double Take_Home_Pay;
            Take_Home_Pay = (Tax_Generator.income - Tax_Generator.tax) / 12;
            THPInterface.GenerateInterface(Take_Home_Pay);

            THPInterface.StartNewPage();
        }

    }
}
