using System;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        { // Inheritance, kalıtım, miras.
            // Interfacelerde bir inheritance örneği gibi çalışır ama değildir.
            // Inheritance'ta base sınıf bir anlam ifade eder, newlenebilir.
            // Bir class bir kez inherit edilebilir, ama birden çok implement alambilir.
            // Inheritance önce yazılır.
            // Multi inheritance yoktur.
            // Interface ve inheritance arasında kalınırsa Inheritance seçilmeli.
            Person[] people = new Person[]
                { 
                    new Customer(){Id = 0, FirstName = "İrem", LastName = "Çalışkan",City = "İstanbul" },
                    new Student() {Id = 0, FirstName = "Ceren", LastName = "Çalışkan",Department = "Management" },
                    new Person() {Id = 0, FirstName = "Beren", LastName = "Çalışer"}
                };
            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}