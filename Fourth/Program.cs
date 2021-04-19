using System;

namespace Fourth
{
    public class References
    {
        public int value;
        public object reference;
    }

    public class StartProgram
    {
        public static void Main(string[] args)
        {
            References first, second, third, fourth;

            first = new References();
            first.value = 20; 

            second = new References();
            second.value = 50; 

            second = first; 
            Console.WriteLine("first.value = {0}, second.value = {1}", first.value, second.value);

            second.value = 100; 
            Console.WriteLine("first.value = {0}, second.value = {1}", first.value, second.value);

            third = new References();
            third.reference = 15; 

            fourth = new References();
            fourth.reference = 30;

            fourth = third;
            Console.WriteLine("third.reference = {0}, fourth.reference = {1}", third.reference, fourth.reference);

            fourth.reference = 45; 
            Console.WriteLine("third.reference = {0}, fourth.reference = {1}", third.reference, fourth.reference);
        }
    }
}