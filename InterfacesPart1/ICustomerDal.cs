using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesPart1
{
    public interface ICustomerDal
    { // Data Acces Layer : veri işlemleri yapılan sınıf, CRUD
        void Add();
        void Update();
        void Delete();
    }
    // Farklı veritabanları destekleniyorsa veritabanı işlemlerinde.
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated!");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated!");
        }
    }
    // MySql'de istendi diyelim...
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added!");
        }

        public void Delete()
        {
            Console.WriteLine("MySql deleted!");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated!");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal) // Hangi veritabanı istenirse o parametre olarak geçilebilir.
        {
            customerDal.Add(); // Gönderilenin Add()'i çalışır.
        }

    }
}
