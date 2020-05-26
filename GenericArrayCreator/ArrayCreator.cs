using System;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            var myArray = new T[length];
            Console.WriteLine("Myarray" + myArray);
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Här är vårat i:" + i);
                myArray[i] = item;
            }
            Console.WriteLine("innan return:" + myArray);
            return myArray;
        }
    }
}
