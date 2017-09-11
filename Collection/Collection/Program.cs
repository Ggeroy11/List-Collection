using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> mylist  = new List<int>() { 1,2,3,4,5,8,6};
            int max = mylist[0];
            int max2 = mylist[0];
            int posMax = 0;
            int posMax2 = 0;
            for (int i = 0; i < mylist.Count; i++)
            {
                if (mylist[i] > max)
                {
                    max2 = max;
                    max = mylist[i];
                    posMax2 = posMax;
                    posMax = i;
                }
                else if (mylist[i]>max2 && mylist[i]<max) {
                    max2 = mylist[i];
                    posMax2 = i;
                }
            }
            Console.WriteLine("Второе максимальное занчение в стеке {0} позицией {1}",max2,posMax2);
            Console.ReadLine();

        }

    }
}
