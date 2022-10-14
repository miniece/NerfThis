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
            Product BlasterRack = new Product("NerfLongshot", Categories.Accessories, "Upgrade your battles to the elite level. This storage rack can hold up to 20 different sizes with shelves, drawers, rail mounts, and hooks.", 59.99);

            Product Football = new Product("Football", Categories.Toys, "Have some lighthearted fun with friends and not try to destroy your enemies.", 15.00);
            Product BasketballHoop = new Product("Nerf Basketball Hoop", Categories.Toys, "Dunk on all of your haters with this full size basketball made completely of foam!", 129.99);
            Product SoccerBall = new Product("NerfLongshot", Categories.Toys, "Kick your enemies when the sun don't shine with this foam soccer ball made with metal center.", 45.93);

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

            Console.WriteLine("Welcome to the NerfThis store. Where you can choose to either slay your enemies and reclaim your seat to the throne or have some wholesome outdoor fun :)");
            Console.WriteLine("");
            Console.WriteLine("Which product would you like to order?");


        }
    }
}