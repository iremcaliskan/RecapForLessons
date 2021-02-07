using System;

namespace InterfacesPart3
{
    public class CustomerManager : IPersonManager
    { // implements
        public void Add()
        {
            Console.WriteLine("Customer is added");
            //  Ekleme kodları yazılır.
        }

        public void Update()
        {
            Console.WriteLine("Customer is updated");
        }
    }
}
