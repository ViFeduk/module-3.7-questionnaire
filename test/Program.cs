namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваше имя {name} и возраст {age}");
            Console.WriteLine("Введите свой день рождения");
            var birthdate = Console.ReadLine();
            Console.WriteLine($"Ваш день рождения {birthdate}");
        }

        
    }
}
