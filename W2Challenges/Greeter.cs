using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2Challenges
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
            DateTime current = DateTime.Now;
            if (current.Hour < 12)
            {
                Console.WriteLine($"Good morning, {name}!");
            }
            else if(current.Hour < 16)
            {
                Console.WriteLine($"Good afternoon, {name}!");
            }
            else if(current.Hour < 20)
            {
                Console.WriteLine($"Good evening, {name}!");
            }
            else
            {
                Console.WriteLine($"Good night, {name}!");
            }
        }
    }
}
