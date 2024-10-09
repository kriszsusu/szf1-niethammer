namespace Tombok01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int[] y = { 10, 20, 30, 55, 110, -40 };
            int[] osztalyzatok = { 1, 2, 3, 4, 5 };
            char[] betuk = { 'A', 'B', 'C', 'D' };
            string[] szavak = { "alma", "körte", "banán", "szilva" };
            double[] szamk = { 3.14, 2.71, 0.8 };

            int max = y.Length - 1;
            Console.WriteLine( y[max] + szavak[0] );

            for ( int i = 0; i < szavak.Length; i++ )
            {
                Console.WriteLine(szavak[i]);
            }

            int[] sok_szam = new int[100];

            Console.WriteLine("21. szám a tömbben: " + sok_szam[21]);
            Console.WriteLine("Az utolsó szám a tömbben: " + sok_szam[sok_szam.Length - 1]);

            // Tömb alapértéke

            for ( int i = 0; i < sok_szam.Length; i++ )
            {
                sok_szam[i] = i;
            }
        }
    }
}
