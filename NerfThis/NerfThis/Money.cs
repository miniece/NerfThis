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
            Console.WriteLine("How Will you be paying today? Cash,Check or Credit");
            string payment = Console.ReadLine();
            if (payment == "Cash")
            {
                Console.WriteLine("Great! Paying with cash I see");
                Console.WriteLine("Please enter the amount of cash you are giving");
               double cash = double.Parse(Console.ReadLine());
                if (cash > total)
                {
                    double change = cash - total;
                    Console.WriteLine("Heres your change!" + change);
                }
                else if (cash < total)
                {
                    total -= cash;
                    Console.WriteLine("You still owe money." + total);
                    PaymentType(total);
        
                }

            } else if (payment == "Check")
            {
                Console.WriteLine("Perfect! Paying with Check");                
                Console.WriteLine("what is the check number?");
                string check = Console.ReadLine();
                Console.WriteLine("thank");

            } else if ( payment == "Credit") {
                Console.WriteLine("Nice! Paying with credit.");
              
                Console.WriteLine("what is your credit card number?");
                string credit = Console.ReadLine();
               
                Console.WriteLine("what is your expiration date?");
                int credit2 = int.Parse(Console.ReadLine());
               
                Console.WriteLine("and your CVV?");
                int credit3 = int.Parse(Console.ReadLine());
                
                Console.WriteLine(credit);
                Console.WriteLine(credit2);
                Console.WriteLine(credit3);


            } else
            {
                Console.WriteLine("Please give a valid answer.");
            }
      
        }   
    }
}
