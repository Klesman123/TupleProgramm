namespace TupleProgramm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tee valik");
            Console.WriteLine("1. TupleSix");
            Console.WriteLine("2. TupleParam");
            Console.WriteLine("3. TupleWithValues");

            int choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    TupleSix();
                    break;

                case 2:
                    TupleWithValues();
                    break;

                case 3:
                    WithSortedList();
                    break;

                default:
                    Console.WriteLine("Tegite vale valiku");
                    break;
            }
        }

        private static void TupleSix()
        {
            var values = Tuple.Create(1, 2, 3, 4, 5, 6);
            TupleParam(values);
        }


        private static void TupleParam(Tuple<int, int, int, int, int, int> values)
        {
            Console.WriteLine(values.ToString());
        }


        private static void TupleWithValues()
        {
            ValueTuple<int, string, string> valueTuple = (69, "string", "string2");
            Console.WriteLine(valueTuple.ToString());
        }


        static void WithSortedList()
        {
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(17, "Seitseteist");
            numberNames.Add(15, "Viisteist");
            numberNames.Add(18, "Kaheksateist");
            numberNames.Add(12, "Kaksteist");
            numberNames.Add(11, "Üksteist");
            foreach (var kvp in numberNames)
            {
                Console.WriteLine($"{kvp.Key},{kvp.Value}");
            }
            //
        }
    };
}