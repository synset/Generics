using System;

namespace GenericScale
{
    public class Scale<T> where T : IComparable<T>
    {
        private T left;
        private T right;

        public Scale(T left, T right) {
            Left = left;
            Right = right;
        }

        public T Left { get => left; set => left = value; }
        public T Right { get => right; set => right = value; }

        public T GetHeavier()
        {
            var comparison = left.CompareTo(right);
            Console.WriteLine(comparison);

            if (comparison > 0)
            {
                return right;
            }
            else if (comparison < 0)
            {
                return left;
            }
            return default(T);
        }
    }
}
