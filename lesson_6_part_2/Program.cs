namespace lesson_6_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("______________________________________1______________________________________");
            int maxInt = MaxNumber(13, 58, 25);
            Console.WriteLine($"Max Number Int: {maxInt}");
            double maxDouble = MaxNumber(9.8, 9.7, 10.1);
            Console.WriteLine($"Max Number Double: {maxDouble}");

            Console.WriteLine("\n______________________________________2______________________________________");
            int minInt = MinNumber(13, 58, 25);
            Console.WriteLine($"Min Number Int: {minInt}");
            double minDouble = MinNumber(9.8, 9.7, 10.1);
            Console.WriteLine($"Min Number Double: {minDouble}");

            Console.WriteLine("\n______________________________________3______________________________________");
            int[] intArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine(SumArray(intArray));
            double[] doubleArray = { 1.1, 2.2, 3.3 };
            Console.WriteLine(SumArray(doubleArray));

            Console.WriteLine("\n______________________________________4______________________________________");
            Stack<double> stack = new Stack<double>(10);
            stack.Push(1.2);
            stack.Push(2.5);
            stack.Push(5.0);
            stack.Push(6.3);
            stack.Push(3.0);
            stack.Push(4.9);

            Console.WriteLine($"Top element is: {stack.Peek()}");
            Console.WriteLine($"Stack count is: {stack.Count}");
            Console.WriteLine($"Popped item is: {stack.Pop()}");
            Console.WriteLine($"Stack count is: {stack.Count}");

            Console.WriteLine("\n______________________________________5______________________________________");
            Queue<int> queue = new Queue<int>(10);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine($"Front element is: {queue.Peek()}");
            Console.WriteLine($"Queue count is: {queue.Count}");
            Console.WriteLine($"Dequeued item is: {queue.Dequeue()}");
            Console.WriteLine($"Queue count is: {queue.Count}");
        }

        public static T MaxNumber<T>(T num1, T num2, T num3) where T : IComparable<T>
        {
            T max = num1;
            if (num2.CompareTo(max) > 0)
            {
                max = num2;
            }
            if (num3.CompareTo(max) > 0)
            {
                max = num3;
            }
            return max;
        }

        public static T MinNumber<T>(T num1, T num2, T num3) where T : IComparable<T>
        {
            T min = num1;
            if (num2.CompareTo(min) < 0)
            {
                min = num2;
            }
            if (num3.CompareTo(min) < 0)
            {
                min = num3;
            }
            return min;
        }

        public static T SumArray<T>(T[] array)
        {
            double sum = 0;

            foreach (var item in array)
            {
                sum += Convert.ToDouble(item);
            }

            return (T)Convert.ChangeType(sum, typeof(T));
        }

    }
}