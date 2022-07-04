using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 5, 4, 4, 5 }; //два массива
            int[] b = { 2, 1, 0, 1, 2, 3, 4 };
            int[] c = new int[b.Length];

            for (int i = 0; i < b.Length; i++)
                if (i < a.Length)
                {
                    c[i] = a[i] + b[i]; //услоавие для сложения двух массивов
                }
                else
                {
                    c[i] = b[i];
                }
            Console.WriteLine("Новый массив: ");
            Array.ForEach(c, x => Console.Write( x + " " ));//вывод нового массива
            Console.ReadKey();
        }
    }
}
