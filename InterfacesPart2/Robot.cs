using System;

namespace InterfacesPart2
{
    public class Robot : ICare, IWork
    {
        public void Maintenance()
        {
            Console.WriteLine("Maintenance time!");
        }

        public void Work()
        {
            Console.WriteLine("Work time!");
        }
    }

}
