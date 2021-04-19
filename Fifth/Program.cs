using System;

namespace Fifth
{
    public class ReferenceType
    {
        public int reference;
    }

    public struct Values
    {
        public ReferenceType referenceType;
    }
    
    class Start
    {
        static void Main(string[] args)
        {
            Values first, second;

            first = new Values();
            first.referenceType = new ReferenceType();
            first.referenceType.reference = 20; 

            second = new Values();
            second.referenceType = new ReferenceType();
            second.referenceType.reference = 50; 

            second = first; 
            Console.WriteLine("first.referenceType.reference = {0}, second.referenceType.reference = {1}", first.referenceType.reference, second.referenceType.reference);

            second.referenceType.reference = 100; 
            Console.WriteLine("first.referenceType.reference = {0}, second.referenceType.reference = {1}", first.referenceType.reference, second.referenceType.reference);
        }
    }
}