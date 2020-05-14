using System;
using System.Collections.Generic;
using System.Text;

namespace Clasa_Stiva
{
    class Stiva
    {
        private int size,i;
        private int[] v;
      public Stiva(int n)
      {
            size = n;
            v = new int[n];
      }

        public void Push(int nr)
        {
            for(i=size-1;i>=0;i--)
            {
                if (v[i] == 0) { v[i] = nr; break; }
                if(i==0)
                Console.WriteLine("Stiva este plina!");
            }
        }

        public void Pop()
        {
            for(i=0;i<size; i++)
            {
                if (v[i] != 0) { Console.WriteLine("{0}", v[i]); break; }
                if(i==size-1)
                    Console.WriteLine("Stiva este goala!");
            }      
        }
        public void Clear()
        {
            for (i = 0; i < size; i++)
                v[i] = 0;
        }
       
    }
}
