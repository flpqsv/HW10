using System;

namespace Fifth
{
    public class ReferenceType
    {
        public int Reference;
    }

    public struct Values
    {
        public ReferenceType ReferenceType;
    }

    public static class Start
    {
        static void Main(string[] args)
        {
            Values first, second;

            first = new Values();
            first.ReferenceType = new ReferenceType();
            first.ReferenceType.Reference = 20; 

            second = new Values();
            second.ReferenceType = new ReferenceType();
            second.ReferenceType.Reference = 50; 

            second = first; 
            Console.WriteLine("first.referenceType.reference = {0}, second.referenceType.reference = {1}", first.ReferenceType.Reference, second.ReferenceType.Reference);

            second.ReferenceType.Reference = 100; 
            Console.WriteLine("first.referenceType.reference = {0}, second.referenceType.reference = {1}", first.ReferenceType.Reference, second.ReferenceType.Reference);
        }
    }
}