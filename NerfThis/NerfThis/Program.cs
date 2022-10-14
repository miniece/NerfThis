namespace NerfThis
{
    internal class Program
    {
        static void Main(string[] args)
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


            List<Product> inventory = new List<Product>();
            inventory.Add(NerfLongshot);
            inventory.Add(ZombieBlaster);
            inventory.Add(BattleRacer);
            inventory.Add(Scooter);
            inventory.Add(AmmoBelt);
            inventory.Add(DartRover);
            inventory.Add(BlasterRack);
            inventory.Add(Football);
            inventory.Add(BasketballHoop);
            inventory.Add(SoccerBall);
            inventory.Add(FoamArrows);
            inventory.Add(Darts);
            Store NerfThis = new Store(inventory);
            List<Product> userCart = new List<Product>();

            Console.WriteLine("Welcome to the NerfThis store. \nWhere you can choose to either slay your enemies and reclaim your seat on the throne \nor have some wholesome outdoor fun :)");
            Console.WriteLine("");
            double itemTotal = 0;
            bool purchaseAgain = true;
            while (purchaseAgain == true)
            {
                NerfThis.PrintInventory();
                Console.WriteLine();
                Console.WriteLine("Which product would you like to purchase? Please select by number.");
                int numPurchased = int.Parse(Console.ReadLine());
                Console.WriteLine($"{inventory[numPurchased - 1].Name}: {inventory[numPurchased - 1].Description} \n");
                Console.WriteLine($"How many {inventory[numPurchased - 1].Name}'s would you like to purchase?");
                int quantity = int.Parse(Console.ReadLine());
                for (int i = 0; i < quantity; i++)
                {
                    userCart.Add(inventory[numPurchased - 1]);
                }

                foreach (Product cart in userCart)
                {
                    Console.WriteLine($"{cart.Name} {cart.Price}");
                }
                itemTotal += Math.Round(inventory[numPurchased - 1].Price * quantity, 2);
                Console.WriteLine(itemTotal);

                purchaseAgain = AskAgain();
            }
            Console.WriteLine(itemTotal);
            double total = Math.Round(itemTotal * 1.06, 2);
            Console.WriteLine(total);


        }
        static bool AskAgain()
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