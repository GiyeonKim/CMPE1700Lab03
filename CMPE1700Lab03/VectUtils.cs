using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1700Lab03
{
    public class VectUtils
    {
        //Returns the nth item in the vector (n=0 means first item)
        //throws an exception if no nth item
        static public int Item(Vector vector, int index)
        {
            if (vector == null)
                throw new NullReferenceException();
            if (index >= vector.Length)
                throw new IndexOutOfRangeException();
            return vector.Values[index];
        }

        //Adds an item to the end of the vector
        //returns a new vector
        //May need a new vector, so it must return a new vector
        //Calling code should look like myVector=Add(myVector,12);
        //Note that you should be using the doubling algorithm
        //To acquire new space when you run out.
        static public Vector Add(Vector vector, int val)
        {
            Vector Vec = new Vector();
            if (vector == null)
            {
                vector.Values = new int[1];
                vector.Values[0] = val;
                return vector;
            }
            else
            {
                Vec.Values = vector.Values;
                Vec.Length = vector.Length;
                vector.Values = new int[vector.Length + 1];
                vector.Length += 1;
                for (int i = 0; i < Vec.Length; i++)
                {
                    vector.Values[i] = Vec.Values[i];
                }
                vector.Values[vector.Length - 1] = val;
                return vector;
            }



        }

        //Inserts an item at location (0 is the first item)
        //So, adding at zero is add in front of all others.
        //May need a new vector, so it must return a new vector
        //Calling code should look like myVector=Insert(myVector,12,4);
        //Note that you should be using the doubling algorithm
        //To acquire new space when you run out.
        //REMEMBER TO CHECK IF THE INDEX IS VALID AND THROW AN
        //EXCEPTION IF NECESSARY.  MAKE SURE YOU DEAL WITH AN EMPTY
        //VECTOR, LIKE THE ABOVE
        static public Vector Insert(Vector vector, int val, int index)
        {
            Vector Vec = new Vector();
            if (index >= vector.Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                Vec.Values = new int[vector.Length + 1];
                Vec.Length = vector.Length + 1;
                if (index == 0)
                {
                    Vec.Values[0] = val;
                    for (int i = 1; i < Vec.Length; i++)
                    {
                        Vec.Values[i] = vector.Values[i - 1];
                    }
                }
                else
                {
                    for (int i = 0; i < index; i++)
                    {
                        Vec.Values[i] = vector.Values[i];
                    }
                    Vec.Values[index] = val;
                    for (int i = index + 1; i < Vec.Length; i++)
                    {
                        Vec.Values[i] = vector.Values[i - 1];
                    }
                }

                vector.Values = new int[vector.Length + 1];
                vector.Length += 1;
                for (int i = 0; i < Vec.Length; i++)
                {
                    vector.Values[i] = Vec.Values[i];
                }
                return vector;
            }

        }

        //Deletes an item at location (0 is first item)
        //Returns a bool - true if successful, false if
        //unable (for example, if item doesn't exist).
        //Doesn't need to create a new vector, just edit existing one.
        static public bool Delete(Vector vector, int index)
        {
            if (vector.Values == null)
            {
                return false;
            }
            Vector Vec = new Vector();
            Vec.Values = new int[vector.Length - 1];
            Vec.Length = vector.Length - 1;
            if (index >= vector.Length || index < 0)
            {

                return false;
            }
            else
            {
                if (index == 0)
                {
                    for (int i = 0; i < Vec.Length; i++)
                    {
                        Vec.Values[i] = vector.Values[i + 1];
                    }
                }
                else
                {
                    for (int i = 0; i < index; i++)
                    {

                        Vec.Values[i] = vector.Values[i];

                    }
                    for (int i = index; i < Vec.Length; i++)
                    {
                        Vec.Values[i] = vector.Values[i + 1];

                    }
                    vector.Values = new int[vector.Length - 1];
                    for (int i = 0; i < Vec.Length; i++)
                    {
                        vector.Values[i] = Vec.Values[i];


                    }
                    Console.WriteLine();
                }
                return true;
            }

        }

        //Returns the number of items currently stored in the vector
      public  static int Length(Vector vector)
        {
            return vector.Length;
        }

        //Returns the maximum capacity of the current vector
        //Count is how many ints are in there now.
        //Size is how many I can fit before I have to grow
       public static int Size(Vector vector)
        {
            if (vector.Values != null)
                return vector.Values.Length;
            else
                return 0;
        }

        //Utility function to double the size of the current vector
        //Changes the vector, so need to return the new one.
        public static Vector Grow(Vector vector)
        {
            if (vector.Values == null)
            {
                throw new NullReferenceException();
            }
            Vector Vec = new Vector();
            Vec.Values = new int[vector.Length];
            Vec.Length = vector.Length;
            for (int i = 0; i < vector.Length; i++)
            {
                Vec.Values[i] = vector.Values[i];
            }
            vector.Values = new int[vector.Length * 2];
            vector.Length = vector.Length * 2;
            for (int i = 0; i < Vec.Length; i++)
            {
                vector.Values[i] = Vec.Values[i];
            }
            return vector;
        }

        //Returns the location (0 is first) of the first
        //instance of the value val, returns -1 if not
        //present
        public static int Find(Vector vector, int val)
        {
            if (vector.Values == null)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < vector.Length; i++)
                {
                    if (vector.Values[i] == val)
                    {
                        return i;
                    }
                }
                return -1;
            }

        }

        //Returns the total number of items that match val.
        //0 means no items.
        public static int Count(Vector vector, int val)
        {
            int count = 0;
            if (vector.Values == null)
            {
                return 0;
            }
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector.Values[i] == val)
                {
                    count += 1;
                }
            }
            return count;
        }

        //Returns the location (0 is first) of the largest 
        //item.  -1 if error (for example, no items).
        public static int Largest(Vector vector)
        {
            if (vector.Values == null)
            {
                return -1;
            }
            int val = vector.Values[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector.Values[i] > val)
                {
                    val = vector.Values[i];
                }
            }
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector.Values[i] == val)
                    return i;
            }
            return -1;
        }

        //Returns the location (0 is first) of the smallest 
        //item.  -1 if error (for example, no items).
        public static int Smallest(Vector vector)
        {
            if (vector.Values == null)
            {
                return -1;
            }
            int val = vector.Values[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector.Values[i] == 0)
                {

                    val = vector.Values[i];
                }
                if (vector.Values[i] < val)
                {
                    val = vector.Values[i];
                }
            }
            for (int i = 0; i < vector.Length; i++)
            {

                if (vector.Values[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }

        //BONUS FEATURE (extra marks if you implement it)
        //Shrinks the Array to 1/2 size off the vector 
        //Size is more than twice its count.
        public static Vector Shrink(Vector vector)
        {
            if (vector.Values == null)
            {
                throw new NullReferenceException();
            }
            Vector v = new Vector();
            v.Values = new int[vector.Length];
            v.Length = vector.Length/2;
            for (int i = 0; i < vector.Length; i++)
            {
                v.Values[i] = vector.Values[i];
            }
            vector.Values = new int[vector.Length / 2];
            vector.Length /= 2;
            for (int i = 0; i < vector.Length; i++)
            {
                vector.Values[i] = v.Values[i];
            }
            return vector;
        }

        //BONUS FEATURE (extra marks if you implement it)
        //Sort the vector either ascending or descending
        //You may not use any built-in array methods, you
        //have to implement a sort from scratch.  Bubble sort
        //would be ok (ewwwww!), as it's easy to understand.
        //Note that the 2nd parameter determines if you are
        //sorting ascending or descending.
        public static void Sort(Vector vector, bool Descending)
        {
            if (vector.Values == null)
            {
                throw new NullReferenceException();
            }

            if (Descending == false)
            {
                int temp;

                for (int i = 0; i < vector.Length - 1; i++)
                {

                    for (int j = i + 1; j < vector.Length; j++)
                    {
                        if (vector.Values[i] > vector.Values[j])
                        {

                            temp = vector.Values[i];
                            vector.Values[i] = vector.Values[j];
                            vector.Values[j] = temp;

                        }

                    }

                }
            }
            else
            {
                int temp;

                for (int i = 0; i < vector.Length - 1; i++)
                {

                    for (int j = i + 1; j < vector.Length; j++)
                    {
                        if (vector.Values[i] < vector.Values[j])
                        {

                            temp = vector.Values[i];
                            vector.Values[i] = vector.Values[j];
                            vector.Values[j] = temp;

                        }

                    }

                }
            }
        }

        //BONUS FEATURE (extra marks if you implement it)
        //Reverse the vector's order
        public static void Reverse(Vector vector)
        {
            if (vector.Values == null)
            {
                throw new NullReferenceException();
            }
            Vector v = new Vector();
            v.Values = new int[vector.Length];
            int temp = vector.Length - 1;
            for (int i = 0; i < vector.Length; i++)
            {
                v.Values[i] = vector.Values[temp];
                temp -= 1;
            }
            for (int i = 0; i < vector.Length; i++)
            {
                vector.Values[i] = v.Values[i];
            }

        }
    }
}
