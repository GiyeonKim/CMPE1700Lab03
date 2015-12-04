using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1700Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            //making list of vectors
            //adding the vectors to the list
            Vector ListVect = new Vector();
            ListVect = VectUtils.Add(ListVect, 5);
            ListVect = VectUtils.Add(ListVect, 8);
            ListVect = VectUtils.Add(ListVect, 6);
            ListVect = VectUtils.Add(ListVect, 30);
            ListVect = VectUtils.Add(ListVect, 1);
            int a = VectUtils.Find(ListVect, 10);
            int b = VectUtils.Count(ListVect, 4);
            int c = VectUtils.Largest(ListVect, 0);
            int s = VectUtils.Smallest(ListVect, 0);

            Console.WriteLine("The Largest is at " + c );
            Console.WriteLine("The smalles is  at " + s + "\n");

            //showing the list of the vector
            Console.WriteLine("Vector list");
            for (int i = 0; i < ListVect.Length; i++)
            {
                Console.WriteLine(ListVect.Values[i]);
            }
            
            //reversing the vector list
            Console.WriteLine("\nReverse");
            VectUtils.Reverse(ListVect);
            for (int i = 0; i < ListVect.Length; i++)
            {
                Console.Write(ListVect.Values[i] + " ");
            }

            // sortingn the vector list in ascending
            Console.WriteLine("\n\nSort (ascending)");
            VectUtils.Sort(ListVect, false); // descending = true     ascending = false
            for (int i = 0; i < ListVect.Length; i++)
            {
                Console.Write(ListVect.Values[i] + " ");
            }


            a = VectUtils.Find(ListVect, 11);
            b = VectUtils.Count(ListVect, 7);
            c = VectUtils.Largest(ListVect, 0);
            s = VectUtils.Smallest(ListVect, 0);
            Console.WriteLine("\n\nAfter sorting");
            Console.WriteLine("The Largest is at " + c);
            Console.WriteLine("The smalles is  at " + s + "\n");


            Console.WriteLine("\nDelete");
            VectUtils.Delete(ListVect, 2); ListVect.Length -= 1; // important to put this in for delete
            for (int i = 0; i < ListVect.Length; i++)
            {
                Console.Write(ListVect.Values[i] + " ");
            }

            Console.WriteLine("\n\nSort (descending)");
            VectUtils.Sort(ListVect, true); // descending = true     ascending = false
            for (int i = 0; i < ListVect.Length; i++)
            {
                Console.Write(ListVect.Values[i] + " ");
            }

            a = VectUtils.Find(ListVect, 11);
            b = VectUtils.Count(ListVect, 7);
            c = VectUtils.Largest(ListVect, 0);
            s = VectUtils.Smallest(ListVect, 0);
            Console.WriteLine("\nThe Largest is at " + c);
            Console.WriteLine("The smalles is  at " + s + "\n");
            //shrinked the size of the vector
            Console.WriteLine("Shrink the size of the vector list");
            VectUtils.Shrink(ListVect);
            for (int i = 0; i < ListVect.Length; i++)
            {
                Console.Write(ListVect.Values[i] + " ");
            }


            Console.ReadKey();
        }
    }
}
