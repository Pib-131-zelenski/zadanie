using System;
using System.Linq;

namespace laamda
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите 1ое слогаемое x:");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите ое слогаемое y:");
            int y = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите множитель z:");
            int z = Convert.ToInt16(Console.ReadLine());

            var calc = new calc();
            Func<int, int, int, int> func = calc.fFunc;
            Console.WriteLine("Результат операции (x+y)*z: " + func(x, y, z));
            Console.ReadKey();

            Console.WriteLine("Введите первую половину слова");
            string s = Console.ReadLine();
            Console.WriteLine("Введите вторую половину слова");
            string s1 = Console.ReadLine();

            var Str = new Str();
            Console.WriteLine("Результатом сложения половины слов является:" + Str.SFunc(s, s1));
            Console.ReadKey();


            bool[] bo = new[] { true, false, false, false, false, false };
            bool[] boo = (bool[])Enumerable.Where(bo, a => a == false);
            int len = boo.Length;
            Console.WriteLine("Количество элементов массива со значением false =" + len);
        }

        private class Str
        {
            public readonly Func<string, string, string> SFunc = (s, s1) => (s + s1);
        }
        
        private class calc
        {
            public readonly Func<int, int, int, int> fFunc = (x, y, z) => (x + y)*z;
        }
    }
}