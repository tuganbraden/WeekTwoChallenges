using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter helloWorld = new Greeter();

            //Greeting
            helloWorld.Hello("Braden");

            //Farewell
            helloWorld.Goodbye("Braden");

            //Depends on time of day
            helloWorld.Time("Braden");

            Console.ReadKey();
        }
    }
}
