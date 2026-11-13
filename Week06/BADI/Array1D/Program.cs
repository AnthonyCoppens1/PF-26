using System;

namespace Array1D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1D arrays
            //aanmaken ervan
            int x = 15;
            Console.WriteLine(x);

            int[] intArray = new int[1];
            Console.WriteLine(intArray);

            foreach (var item in intArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            string[] strings = {"honda", "toyota", "subaru", "volkswagen", "mercedes", "audi"};
            Console.WriteLine(strings.Length);

            double[] D = {1.5, 10.3, -15, 8, 12.1, 8.2, 19};
            bool[] B = {true, true, false, false, false, true, false, true};

            strings[0] = "BMW";
            foreach (var item in strings)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            string[] namen = new string[4];
            namen[0] = "Jean";
            namen[1] = "Jessica";
            namen[3] = "Jason";
            namen[2] = "Jasmine";
            //namen[4] = "John"; --> onmogelijk, want index bestaat niet

            foreach (var item in namen)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            //double[] D = {1.5, 10.3, -15, 8, 12.1, 8.2, 19};
            Console.WriteLine($"Het eerste element in D: {D[0]}");
            Console.WriteLine($"Het laatste element in D: {D[^1]}"); //WERKT NIET IN CODEGRADE
            Console.WriteLine($"Het laatste element in D: {D[D.Length-1]}");
            Console.WriteLine($"Het laatste element in D: {D[6]}");


            //loopen erdoor
            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write($"{strings[i]} ");
            }
            Console.WriteLine();


            //while
            int teller = 0;
            while (teller < strings.Length)
            {
                Console.Write($"{strings[teller]} ");
                teller++;
            }
            Console.WriteLine();



            //array vullen die al op voorhand is gereserveerd
            for(int i = 0; i < intArray.Length; i++)
            {
                //intArray[i] = i * 4;
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var item in intArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            //array vullen met .Split()
            //"kat hond capibara vlinder egel eenhoorn schildpad"
            string antwoord = Console.ReadLine();
            string[] dieren = antwoord.Split();

            for (int i = dieren.Length-1; i >= 0; i--)
            {
                Console.Write($"{dieren[i]} ");
            }
            Console.WriteLine();

            string zin = "dit;is;een;test";
            string[] elementen = zin.Split(";");
            foreach (var item in elementen)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            //omzetten van tekst naar getallen
            int[] gekozenGetallen = new int[5];
            string getallen = Console.ReadLine(); //"10 5 8 3 1 -2"

            string[] G = getallen.Split(); //"10"
            int[] iets =  new int[G.Length];

            for (int i = 0; i < G.Length; i++)
            {
                iets[i] = Convert.ToInt32(G[i]);
                Console.Write($"{iets[i] + 10} ");
            }
            Console.WriteLine();


            iets = Array.ConvertAll(G, Convert.ToInt32);


            //ingebouwde functies/methodes
            int[] array = {5, 1, 3, 2, 4};
            Console.WriteLine($"SOM: {array.Sum()}");
            Console.WriteLine($"Min: {array.Min()}");
            Console.WriteLine($"Max: {array.Max()}");
            Console.WriteLine($"Average: {array.Average()}");

            Array.Sort(array);
            Array.Reverse(array);

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            //sorteeralgoritme
            //link: https://nl.wikipedia.org/wiki/Bubblesort
            array = new int[]{5, 3, 2, 4, 1};

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tijdelijk = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tijdelijk;
                    }
                }
            }

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            array = new int[] {1, 2, 3, 4, 5};
            //som maar dan wiskundig programmeren
            int som = 0;
            for (int i = 0; i < array.Length; i++)
            {
                som += array[i];
            }

            Console.WriteLine($"SOM: {som}");
            Console.WriteLine($"GEMIDDELDE: {som/array.Length}");


            int hoogste = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > hoogste)
                {
                    hoogste = array[i];
                }
            }
            Console.WriteLine($"HOOGSTE: {hoogste}");
        










        }
    }
}