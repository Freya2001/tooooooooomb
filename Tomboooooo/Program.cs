using System;

namespace Tomboooooo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string alma = "Samsung";
            //Console.WriteLine(alma[3]);
            //alma.Split('s');
            Console.WriteLine("Adj meg 10 pozitív egész számot szóközökkel elválasztva!");
            string input = Console.ReadLine();
            string[] szamokStr = input.Split(' ');
            int[] tombi = new int[10];
            for (int i = 0; i < szamokStr.Length; i++)
            {
                int szam;
                bool szamE = Int32.TryParse(szamokStr[i], out szam);
                tombi[i] = szam;
            }
            for (int i = 0; i < tombi.Length; i++)
            {
                Console.WriteLine("Az " + (i + 1) + ". elem: " + tombi[i]);
            }
        }
    }
}
