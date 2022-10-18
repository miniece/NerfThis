namespace NerfThis
{
    internal class Program
    {
        static void Main()
        {
            //method that calls the class to run the program
            Store NerfThis = new Store();

            Console.WriteLine("Welcome to the NerfThis store. \nWhere you can choose to either slay your enemies and reclaim your seat on the throne \nor have some wholesome outdoor fun :)");
            Console.WriteLine("");
            
            NerfThis.RunStore();
        }
       

    }
}