namespace C5HashedLinkedListAssertionError
{
    using System;

    using C5;

    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new HashedLinkedList<int>();

            for (int i = 0; i < 5000000; i++)
            {
                list.Add(i);

                if (i % 1000 == 0)
                {
                    Console.WriteLine("List size = " + i);
                }
            }

            Console.ReadLine();
        }
    }
}
