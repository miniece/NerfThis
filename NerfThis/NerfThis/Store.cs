﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerfThis
{
    public class Store
    {
        List<Product> Inventory { get; set; } = new List<Product>();
        public Store()
        {
            Product NerfLongshot = new Product("Nerf Longshot", Categories.Weapons, "Aim with accuracy and pinpoint precision using the tageting scope. Can launch foam arrows up to 35 feet away.", 63.99);
            Product ZombieBlaster = new Product("Nerf Zombie Blaster", Categories.Weapons, "The blaster is morotized so you can rev it up and shoot all 18 darts om a row with rapid-fire blasting.", 79.95);


            Product BattleRacer = new Product("Nerf Battle Racer Kart", Categories.Vehicles, "Slay your enemies with this ride on cart. Equipped with placeholders for blasters and darts, bucket seat with hollows for darts, and 3 point steering.", 273.59);
            Product Scooter = new Product("Nerf Blaster Scooter", Categories.Vehicles, "Ride in style with this fully motorized, dual trigger rapid fire action that includes 2 clips and 12 elite darts.", 149.99);

            Product AmmoBelt = new Product("Ammo Belt", Categories.Accessories, "Never lose a dart and stay ready with this ammo belt.", 25.95);
            Product DartRover = new Product("Nerf Dart Rover", Categories.Accessories, "Retrieves a maximum of 100 darts. Plow action is built to capture the most darts.", 34.99);
            Product BlasterRack = new Product("Blaster Rack", Categories.Accessories, "Upgrade your battles to the elite level. This storage rack can hold up to 20 different sizes with shelves, drawers, rail mounts, and hooks.", 59.99);

            Product Football = new Product("Football", Categories.Toys, "Have some lighthearted fun with friends and not try to destroy your enemies.", 15.99);
            Product BasketballHoop = new Product("Nerf Basketball Hoop", Categories.Toys, "Dunk on all of your haters with this full size basketball hoop made completely of foam!", 129.99);
            Product SoccerBall = new Product("Soccer Ball", Categories.Toys, "Kick your enemies when the sun don't shine with this foam soccer ball made with metal center.", 45.93);

            Product FoamArrows = new Product("Foam Arrows", Categories.Ammunition, " Stock up on these arrows for the Nerf Zombie Deadbolt blaster (sold seperately). Colors may vary.", 28.99);
            Product Darts = new Product("Nerf N-Strike Elite Series", Categories.Ammunition, "Let the battles begin. Absolutely destroy your enemies with this 1000 piece foam darts. You'll have maximum impact on the battlefield.", 36.99);

            Inventory.Add(NerfLongshot);
            Inventory.Add(ZombieBlaster);
            Inventory.Add(BattleRacer);
            Inventory.Add(Scooter);
            Inventory.Add(AmmoBelt);
            Inventory.Add(DartRover);
            Inventory.Add(BlasterRack);
            Inventory.Add(Football);
            Inventory.Add(BasketballHoop);
            Inventory.Add(SoccerBall);
            Inventory.Add(FoamArrows);
            Inventory.Add(Darts);
        }
        public Store(List<Product> products)
        {
            Inventory = products;
        }

        public void PrintInventory()
        {
            for(int i = 0; i < Inventory.Count; i++)
            {
                Console.WriteLine($"{i+1}:  \t{Inventory[i].Name, -40}  ${Inventory[i].Price, -10}");    
            }
        }
        public void RunStore()
        {
            List<Product> userCart = new List<Product>();
            double itemTotal = 0;
            List<string> uniqueNames = new List<string>();
            int numPurchased = 0;
            int quantity = 0;
            bool purchaseAgain = true;
            while (purchaseAgain == true)
            {
                string input = "";
                try
                {
                    PrintInventory();
                    Console.WriteLine($"\nWhich product would you like to purchase? Please select by number.");
                    input = Console.ReadLine();
                    numPurchased = int.Parse(input);

                    Console.WriteLine($"{Inventory[numPurchased - 1].Name}: {Inventory[numPurchased - 1].Description} \n");
                    Console.WriteLine($"How many {Inventory[numPurchased - 1].Name}'s would you like to purchase?");
                    quantity = int.Parse(Console.ReadLine());
                    //Adds amount of items to list
                    for (int i = 0; i < quantity; i++)
                    {
                        userCart.Add(Inventory[numPurchased - 1]);
                    }
                }
                catch(ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("That index clearly don't exist, dumb dumb.\r\n");
                    continue;
                }

                uniqueNames = userCart.Select(item => item.Name).Distinct().ToList();
                foreach(string item in uniqueNames)
                {
                    int amount = userCart.Count(i => i.Name == item);
                    Console.WriteLine($"{amount}x {item}");
                }
                
                itemTotal += Math.Round(Inventory[numPurchased - 1].Price * quantity, 2);
                String.Format("{0:0.00}", itemTotal);
                Console.WriteLine($"Current subtotal: {itemTotal}");

                purchaseAgain = AskAgain();
            }
            PurchaseTotal(itemTotal);
        }
        public static void Receipt()
        {
            List<Product> userCart = new List<Product>();
            List<string> uniqueNames = new List<string>();

            Console.WriteLine("Receipt:");
            foreach (string item in uniqueNames)
            {
                int amount = userCart.Count(i => i.Name == item);
                Console.WriteLine($"{amount}x {item}");
            }

        }
        public static void PurchaseTotal(double itemTotal)
        {
            double total = Math.Round(itemTotal * 1.06, 2);
            String.Format("{0:0.00}", total);
            Console.WriteLine($"Total: ${total}");
            Money.PaymentType(total);
        }
        public static bool AskAgain()
        {
            Console.WriteLine("Would you like to purchase more items? Y/N");
            string response = Console.ReadLine().ToLower();
            if (response == "y" || response == "yes")
            {
                return true;
            }
            else if (response == "n" || response == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("\nI didn't understand that. Please try again!");
                return AskAgain();
            }
        }
    }
}
