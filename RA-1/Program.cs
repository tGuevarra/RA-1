namespace RA
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Please, enter your age: ");
            var age = Console.ReadLine();

            Console.WriteLine($"Hello World! This is {name}, and he is {age} y.o.");
            Console.ReadLine();
        }
    }
}
