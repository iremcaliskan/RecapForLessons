using System;
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        { // Classlar, yapılmak istenen işlemleri gruplara ayırmak, gruplar üzerinden işlemleri yapmak ve gruba ulaşmak için kullanılırı.

            CustomerManager customerManager = new CustomerManager(); // Class'ın bir örneğini, referansını oluşturma
            customerManager.Add();
            customerManager.Update();
            customerManager.Delete();

            ProductManager productManager = new ProductManager(); // Class'ın bir örneğini, referansını oluşturma
            productManager.Add();
            productManager.Update();
            productManager.Delete();
            // İşlemleri gruplamış olduk. En temel özelliktir gruplama: Müşteri ile ilgili işlemler, Ürün ile ilgili işlemler.

            Customer customer1 = new Customer();
            customer1.CustomerId = 0; // set bloğu çalışır
            customer1.FirstName = "İrem"; // set bloğu çalışır
            customer1.LastName = "Çalışkan"; // set bloğu çalışır
            customer1.City = "İstanbul"; // set bloğu çalışır

            Customer customer2 = new Customer() 
            {
                CustomerId = 1, FirstName = "Ceren", LastName = "Çalışkan",
                City = "İstanbul" 
            };

            Console.WriteLine(customer2.FirstName); // get bloğu çalışır

        }
    }
}
