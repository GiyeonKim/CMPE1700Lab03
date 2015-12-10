using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1700Lab03
{
   public class Program
    {
       public static void Main(string[] args)
        {
          

            Vector vec = new Vector();


            for (int i = 0; i < 20; ++i)

                VectUtils.Add(vec, i);

            Console.WriteLine(VectUtils.Length(vec) + "-"

                + VectUtils.Largest(vec) + "-"

                + VectUtils.Smallest(vec));

            vec = VectUtils.Grow(vec);

            Console.Write(VectUtils.Size(vec) + "-");

            vec = VectUtils.Shrink(vec);

            Console.WriteLine(VectUtils.Size(vec));

            VectUtils.Insert(vec, 5, 1);

            Console.WriteLine(VectUtils.Find(vec, -1) + "-"

                + VectUtils.Count(vec, -1));

            Console.WriteLine(VectUtils.Find(vec, 5) + "-"

                + VectUtils.Count(vec, 5));

            for (int i = 0; i < VectUtils.Length(vec); ++i)

                Console.Write(VectUtils.Item(vec, i));

            Console.WriteLine();


            VectUtils.Sort(vec, true);

            for (int i = 0; i < VectUtils.Length(vec); ++i)

                Console.Write(VectUtils.Item(vec, i));

            Console.WriteLine();


            VectUtils.Reverse(vec);

            for (int i = 0; i < VectUtils.Length(vec); ++i)

                Console.Write(VectUtils.Item(vec, i));

            Console.WriteLine();
            Console.ReadKey();


           
        }
    }
}
