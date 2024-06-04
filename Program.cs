using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _13_algoritmizacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICollection col;
            ArrayList list = new ArrayList();
            list.Add(4.5);
            list.Add(18);

            try
            {

                foreach (object e in list)
                {
                    Console.WriteLine(e);
                }

                list.RemoveAt(0);
                list.Reverse();


                ArrayList list2 = new ArrayList();

                col = new ArrayList();
                Console.WriteLine("введите коллекцию");
                col = Console.ReadLine().Split(' ');
                list2.AddRange(col);

                Console.WriteLine("с какого элемента и сколько нужно удалить?");
                string[] din = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(din[0]);
                int h = Convert.ToInt32(din[1]);
                while (h > 0)
                {
                    list2.RemoveAt(n);
                    h--;

                }
                foreach (object e in list2)
                {
                    Console.WriteLine(e);
                }
            }
            catch {
                Console.WriteLine("ошибка");
            }
            
           



        }
    }
}

