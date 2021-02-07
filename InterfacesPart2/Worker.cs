using System;

namespace InterfacesPart2
{
    public class Worker : IWork, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Meal time!");
        }

        public void GetSalary()
        {
            Console.WriteLine("Salaries are paid.");
        }

        public void Work()
        {
            Console.WriteLine("Work time!");
        }
    }

}
