using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerfThis
{
    public class Money
    {   
        public static void PaymentType(double total)
        {
            Console.WriteLine("How will you be paying today? Cash,Check or Credit");
            string payment = Console.ReadLine().ToUpper().Trim();

            bool goAgain = true;
            while (goAgain == true)
            {            
                try
                {
                    if (payment == "CASH")
                    {
                        Console.WriteLine("Great! Paying with cash I see");
                        Console.WriteLine("Please enter the amount of cash you are giving");
                        double cash = double.Parse(Console.ReadLine());
                        if (cash > total)
                        {
                            double change = cash - total;
                            Console.WriteLine("Heres your change! " + change);
                            break;
                        }
                        else if (cash < total)
                        {
                            total -= cash;
                            Console.WriteLine("You still owe money. " + total);
                            PaymentType(total);
                           
                        }
                        else if(cash == total)
                        {
                            Console.WriteLine("Thank you for paying exact change!");
                            break;
                        }
                    }
                    else if (payment == "CHECK")
                    {
                        Console.WriteLine("Perfect! Paying with Check");
                        Console.WriteLine("What is the check number?");
                        string checkNumber = Console.ReadLine();
                        Console.WriteLine("Thank");
                        break;
                    }
                    else if (payment == "CREDIT")
                    {
                        Console.WriteLine("Nice! Paying with credit.");

                        Console.WriteLine("What is your credit card number?");
                        string creditNumber = Console.ReadLine();

                        Console.WriteLine("What is your expiration date?");
                        int expDate = int.Parse(Console.ReadLine());

                        Console.WriteLine("and your CVV?");
                        int securityCode = int.Parse(Console.ReadLine());

                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid payment type.");
                        PaymentType(total);
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter a valid number.");
                    goAgain = true;
                }
            }
        }   
    }
}
