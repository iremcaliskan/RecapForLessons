using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        { // Bir sınıfı newlediğimin zaman çalışan blok Constructor'dır.
            // Bir Class'ın Constructor'ı ilk kez oluştuğu zaman bir kere çalışır, bir daha çalışmaz.
            Customer customer = new Customer(); // newledik, instance oluşturduk.
            // Customer() bir metotmuş gibi, metot gibi çalışır. Constructor yazılmazsa default çalışır.
            //Method(2, " ", " ", " ");

            // Parametresiz/Default Constructor
            Customer customer1 = new Customer() { Id = 1, FirstName = "İrem", LastName = "Çalışkan", City = "İstanbul" }; // Parametresiz Constructor
            // Parametreli Constructor
            Customer customer2 = new Customer(2, "Ceren", "Çalışkan", "Ankara"); // Parametreli Constructor

        }

        static void Method(int id, string firstName, string lastName, string city) 
        {

        }
    }
    class Customer
    {
        // Default constructor = yapıcı blok
        // Method overloading for parameterized and not parameterized!
        public Customer()
        {
            Console.WriteLine("Customer class' Constructor ran without parameters!");
        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Console.WriteLine("Parameterized Customer class' Constructor ran!");
            // Değerleri set etme:
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city; // Gelen City = oluşturulan city
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
