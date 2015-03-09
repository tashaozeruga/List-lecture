using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            a.Add(5);
            a.Add(3);
            a.Add(7);
            a.Add(9);
            a.Add(2);
            a.Add(1);
            a.Add(7);
            a.Add(9);
            a.Add(2);

            foreach (int element in a)
            {
                Console.Write(element.ToString () + ", ");
            }

            Console.WriteLine();

            a.Remove(5);
            foreach (int element in a)
            {
                Console.Write(element.ToString() + ", ");
            }

            Console.WriteLine();


            Console.WriteLine(a[3].ToString());
                

        }
    }
}
