using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is a program to calculate your total income using regular, overtime, and double pay.");
            string repeat = "y";
            do {
                double pay, otPay, doublePay, totalPay;
                double hours, otHours, doubleHours;
                string menuSelection = "";



                Console.WriteLine("Enter pay rate:");
                pay = Convert.ToDouble(Console.ReadLine());

                otPay = pay * 1.5;
                doublePay = pay * 2;

                Console.WriteLine("Enter regular pay hours: ");
                hours = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter OT hours: ");
                otHours = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter double pay hours: ");
                doubleHours = Convert.ToDouble(Console.ReadLine());

                totalPay = (otPay * otHours) + (pay * hours) + (doubleHours * doublePay);



                while (menuSelection != "4")
                {

                Console.WriteLine("Select an option.\n1. Pay period \n2. Monthly\n3. Yearly\n4. Exit");
                menuSelection = Console.ReadLine();

                
                    if (menuSelection == "1")
                    {

                        Console.WriteLine("Your expected pay period income before tax and benefit deducations is: " + totalPay);
                    }
                    else if (menuSelection == "2")
                    {

                        Console.WriteLine("Your expected monthly income pay before tax and benefit deducations is: " + totalPay * 2.1);
                    }
                    else if (menuSelection == "3")
                    {

                        Console.WriteLine("Your expected annuel income pay before tax and benefit deducations is: " + totalPay * 26);
                    }



                }



                Console.WriteLine("Would you like to repeat the calculation? Enter y or n");
                repeat = Console.ReadLine();

            }

            
            while (repeat == "y");

            Console.WriteLine("Thank you for using our program!");

            Console.ReadKey();
        }
    }
}
