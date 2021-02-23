using System;


namespace _0223Review_2
{
    class Program2
    {
        static void Main(string[] args)
        {
            string val = Console.ReadLine();
            int num = 0;
            int.TryParse(val, out num);

            for (int i = 0; i < num; i++) //행
            {
                for (int j = 0; j < num - 1 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++) //열
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}
