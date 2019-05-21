using System;

namespace Practice_Project
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] luckyNumbers = { 5, 4, 3, 2, 1, 2, 3, 4, 5};

            string[] friends = new string[5];
            Console.WriteLine("list 5 of your closes friends!");
            friends[0] = Console.ReadLine();
            friends[1] = Console.ReadLine();
            friends[2] = Console.ReadLine();
            friends[3] = Console.ReadLine();
            friends[4] = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("These are your five closest friends: ");
            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);
            Console.WriteLine(friends[4]);

        }
    }
}
