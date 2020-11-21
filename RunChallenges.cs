using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeekTwoChallenges
{
    public class Greeter
    {
        public void Hello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        public void Goodbye(string name)
        {
            Console.WriteLine($"Goodbye {name}!");
        }

        public void Time(string name)
        {
            //if datetime
        }
    }

    [TestClass]
    public class RunChallenges
    {
        
        [TestMethod]
        public void ChallengeTest()
        {
            Console.WriteLine(DateTime.Now);
            Console.ReadKey();
        }
    }
}
