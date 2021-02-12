using System;

namespace My_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dict<int, string>();
            dict.Add(new Item<int, string>(1, "One"));
            dict.Add(new Item<int, string>(1, "One"));
            dict.Add(new Item<int, string>(2, "Two"));
            dict.Add(new Item<int, string>(3, "Three"));
            dict.Add(new Item<int, string>(4, "Four"));
            dict.Add(new Item<int, string>(5, "Five"));
            dict.Add(new Item<int, string>(101, "One hundred one"));
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(dict.Search(3) ?? "Not Found");
            Console.WriteLine(dict.Search(7) ?? "Not Found");
            dict.Remove(1);
            dict.Remove(2);
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            var basicMap = new Basic_Map<int, string>();
            basicMap.Add(new Item<int, string>(1, "One"));
            basicMap.Add(new Item<int, string>(2, "Two"));
            basicMap.Add(new Item<int, string>(3, "Three"));
            basicMap.Add(new Item<int, string>(4, "Four"));
            basicMap.Add(new Item<int, string>(5, "Five"));

            basicMap.Remove(1);
            Console.WriteLine(basicMap.Search(7) ?? "Not Found");
            Console.ReadKey();
        }
    }
}
