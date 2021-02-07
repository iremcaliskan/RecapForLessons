using System;

namespace InterfacesPart3
{
    public class EmployeeManager : IPersonManager
    { // implements
        public void Add()
        {
            Console.WriteLine("Employee is added");
            //  Ekleme kodları yazılır.
        }

        public void Update()
        {
            Console.WriteLine("Employee is updated");
        }
    }
}
