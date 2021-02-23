using System;


namespace _0223Review
{
    class Program1
    {
        static void Main(string[] args)
        {
            string val = Console.ReadLine();
            int varnum = 0;
            int.TryParse(val, out varnum);
            if (varnum % 4 == 0 && (varnum % 100 != 0 || varnum % 400 == 0))
            {
                Console.WriteLine(1);
            }
            else Console.WriteLine(0);
        }
    }
}
