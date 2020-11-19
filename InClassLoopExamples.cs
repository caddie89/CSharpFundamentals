using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class InClassLoopExamples
    {
        [TestMethod]
        public void Loops()
        {
            int studentCount = 10;

            //For loop
            for (int i = 0; i <= studentCount; i++) //i stands for index (common naming convention)
            {
                Console.WriteLine(i);
            }

            string[] names = { "Michael", "Simon", "Peyton", "Casey" }; //Michael is an item in the collection (array of strings is called "names"
            Console.WriteLine(names); //doesn't give us individual strings

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(names.Length); //number of items in this array

            while (studentCount >= 0)
            {
                Console.WriteLine(studentCount);
                studentCount --;
            }
        }
    }
}
