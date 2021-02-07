using System;

namespace InterfacesPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 0;
            customer.FirstName = "Kerem";
            customer.LastName = "Yılmaz";
            customer.Address = "İstanbul";

            Student student = new Student();
            student.Id = 0;
            student.FirstName = "Hatice";
            student.LastName = "Ateş";
            student.Department = "Computer Science";
            
            Worker worker = new Worker();
            worker.Id = 0;
            worker.FirstName = "Beren";
            worker.LastName = "Çalışer";
            worker.Department = "IT";

            IPerson person1 = new Customer();
            person1.Id = 0;
            person1.FirstName = "Ceren";
            person1.LastName = "Çalışkan";

            //IPerson person = new IPerson();
            // Cannot create an instance of the abstract type or interface.
            // Interfaceler newlenemez, içi boş soyut bir sınıftır. Anlamsız.

            PersonManager personManager = new PersonManager();
            personManager.Add(new Student() { Id = 0, FirstName = "İrem", LastName = "Çalışkan", Department = "Computer Engineering"});
            personManager.Add(customer);
            personManager.Add(student);
            personManager.Add(worker);

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
            // Uygulamanın bağımlılıklarını minimize etmek amacımız!

            // Polymorphism : çok biçimlilik, bir nesneyi farklı amaçlarla implemente edip, o implementasyonlara ulaşmak.
            // ICustomerDal bir çok biçimlilik örneğidir.

            // Her iki veritabanınında kullanılması istenirse.
            // MySql'de istenirse:
            ICustomerDal[] customerDals = new ICustomerDal[] 
            { 
                new SqlServerCustomerDal(), new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add(); // Herbiri için Add çağırıldı.
            }

            for (int i = 0; i < customerDals.Length; i++)
            {
                customerDals[i].Add();
            }
        }
    }

    interface IPerson
    { // Interfaceler, temel operasyon oluşturup, kullanacak sınıflar için şablon oluşturmaktır.
        // Soyut nesnelerdir.
        int Id { get; set; } // imza kullanılır.
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson
    { // Somut nesne
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; } // Özel
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; } // Özel

    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; } // Özel
    }

    class PersonManager
    { // İş katmanı
        public void Add(IPerson person) // IPerson verilerek, onu implement eden sınıflar için referans tutucu oluşturmuş oluruz.
        {
            Console.WriteLine(person.FirstName);
        }

    }
}
