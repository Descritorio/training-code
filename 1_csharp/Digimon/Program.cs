using System;

namespace Digimon
{
    internal class Program
    {
        internal class Digimon {}

        static void Main(string[] args)
        {
            var p = new Program();
            p.Fight(null, null);
        }

        public void Fight(Digimon a, Digimon b) 
        {
            System.Console.WriteLine("{0} fights {1}", a, b);
        }
    }
}
