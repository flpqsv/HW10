using System;

namespace Third
{
    public class Reference
    {
        public float reference;
    }
    
    public class StartProgram
    {
        static void Main(string[] args)
        {
            float first, second;
            first = 10;

            second = first; 
            Console.WriteLine("first = {0}, second = {1}", first, second);

            first = 20; 
            Console.WriteLine("first = {0}, second = {1}", first, second);

            Reference third, fourth;
            
            third = new Reference();
            third.reference = 30;
            
            fourth = third;
            Console.WriteLine("third = {0}, fourth = {1}", third.reference, fourth.reference);
            
            third.reference = 40; 
            Console.WriteLine("third = {0}, fourth = {1}", third.reference, fourth.reference);
        }
    }
}