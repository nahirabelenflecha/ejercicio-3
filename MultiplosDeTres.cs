using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace multiplos
{
    public class Program
    {
        static public void Main(string[] args)
        {
            int mul, CantMul;
            mul=3;
            Console.WriteLine("Ingrese la cantidad de multiplos de tres que desea ver");
            CantMul = int.Parse(Console.ReadLine());

            for(int a=mul; a<=(mul*CantMul); a+=mul)
            {
                Console.WriteLine(",", a);
            }
        }
    }
}