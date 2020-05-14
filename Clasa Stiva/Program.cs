using System;
using System.Collections.Generic;
using System.Text;
namespace Clasa_Stiva
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool t = true;
            string comanda;
            int n;
            Console.Write("Introduceti dimensiunea stivei:");
            n = int.Parse(Console.ReadLine());
            Stiva STIVA = new Stiva(n);
            while(t==true)
            {
                Console.WriteLine("Optiuni:");
                Console.WriteLine("1)Push");
                Console.WriteLine("2)Pop");
                Console.WriteLine("3)Clear");
                Console.WriteLine("4)Iesire");
                comanda = Console.ReadLine();

                if(comanda=="1")
                {
                    Console.Write("Introduceti numarul:");
                    int nr = int.Parse(Console.ReadLine());
                    STIVA.Push(nr);
                }
                if(comanda=="2")
                {
                    STIVA.Pop();
                }
                if(comanda=="3")
                {
                    STIVA.Clear();
                }
                if(comanda=="4")
                {
                    t = false;
                }
            }
            
            

        }
    }
}
