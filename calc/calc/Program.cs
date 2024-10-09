namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 1)
            {
                int x = Convert.ToInt32(args[0]);
                char op = Convert.ToChar(args[1]);
                int y = Convert.ToInt32(args[2]);

                switch(op)
                {
                    case '+':
                        Console.WriteLine($"Eredmény: {x + y}");
                        break;

                    case '-':
                        Console.WriteLine($"Eredmény: {x - y}");
                        break;

                    case '*':
                        Console.WriteLine($"Eredmény: {x * y}");
                        break;

                    case '/':
                        Console.WriteLine($"Eredmény: {x / y}");
                        break;
                }

            } else
            {
                Console.WriteLine("Nincs elég paraméter megadva!");
            }
        }
    }
}
