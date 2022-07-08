using System;
using static VbtStaj2022DesignPattern.Interpret;

namespace VbtStaj2022DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Description1 = "Futbol maclarini çok sevsem de, genelde izlemiyorum";
            string Description2 = "Bebegimin sagligi için anne sütüne çok önem veriyorum.";
            string Description3 = "Spor'a giderken arabayı güzellikle vurdum.";

            Console.WriteLine($"{Description1} (Erkek):");
            Console.WriteLine(InterpretPattern.getMaleExpression().Interpret(Description1));

            bool expResult = false;
            Console.WriteLine($"{Description2} (Kadın:)");
            foreach (Expression exp in InterpretPattern.getFemaleExpression())
            {
                if (exp.Interpret(Description2)) { expResult = true; break; }
            }
            Console.WriteLine(expResult);

            bool expResult2 = false;
            Console.WriteLine($"{Description3} (Kadın:)");
            foreach (Expression exp in InterpretPattern.getFemaleExpression())
            {
                if (exp.Interpret(Description3)) { expResult2 = true; break; }
            }
            Console.WriteLine(expResult2);
        }
    }
}