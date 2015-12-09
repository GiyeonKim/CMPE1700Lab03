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

            //find the int in the list
            //count the list
            
            int a = VectUtils.Find(ListVect, 10);
            int b = VectUtils.Count(ListVect, 4);
            int c = VectUtils.Largest(ListVect, 0);
            int s = VectUtils.Smallest(ListVect, 0);


            //showing the list of the vector
            Console.WriteLine("Vector list");
            for (int i = 0; i < ListVect.Length; i++)
            {
                Console.WriteLine(ListVect.Values[i]);
            }


            //find the largest value in list
            //find the smallest value in the list
            Console.WriteLine("The Largest is at " + c);
            Console.WriteLine("The smalles is  at " + s + "\n");


            //reversing the vector list
            Console.WriteLine("\nReverse");

            //print out the reverse version of the vector list
            VectUtils.Reverse(ListVect);
            for (int i = 0; i < ListVect.Length; i++)
            {
                Console.Write(ListVect.Values[i] + " ");
            }

            // sortingn the vector list in ascending
            Console.WriteLine("\n\nSort (ascending)");

            //prints out the asceding list vector 
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

            //deleting one of value in the vector list
            Console.WriteLine("\nDelete middle value in vector list");

            VectUtils.Delete(ListVect, 2); ListVect.Length -= 1; // **important to put this in for delete
            //print out the list of the value after deleting the item
            for (int i = 0; i < ListVect.Length; i++)
            {
                Console.Write(ListVect.Values[i] + " ");
            }
            //sorting the list vector by descending
            Console.WriteLine("\n\nSort (descending)");

            VectUtils.Sort(ListVect, true); // descending = true     ascending = false
            for (int i = 0; i < ListVect.Length; i++)
            {
                Console.Write(ListVect.Values[i] + " ");
            }

            a = VectUtils.Find(ListVect, 11);
            b = VectUtils.Count(ListVect, 7);


            //printout the largest value in listvect after sort descending
            //printout the smallest value in listvect after sort descending
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
