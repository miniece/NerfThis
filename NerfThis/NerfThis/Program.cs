namespace NerfThis
{
    internal class Program
    {
        static void Main()
        {
            Store NerfThis = new Store();

            //greet the user
            Console.WriteLine("Welcome to the NerfThis store. \nWhere you can choose to either slay your enemies and reclaim your seat on the throne \nor have some wholesome outdoor fun :)");
            Console.WriteLine("");
            
            //call RunStore method that contains the large majority of our code
            NerfThis.RunStore();
        }
       

    }
}