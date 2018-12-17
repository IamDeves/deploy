using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deploy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt16(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
