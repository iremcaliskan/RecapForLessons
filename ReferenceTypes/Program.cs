using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            num1 = num2; // num1 ve num2 20
            num2 = 100; // num2 100
            Console.WriteLine(num1); //20
            Console.WriteLine(num2); //100
            // int, long, float, double, decimal, char, bool, byte, short, struct, enum değer tiptir.
            // Değer tipler stack ile çalışır. 
            // Stackte adresleme olmadığı için sadece adresleme ile çalışır.

            Console.WriteLine("----------------");

            string[] names1 = new string[] {"İrem","Ceren", "Kerem" };
            string[] names2 = new string[] { "Deren", "Beren", "Seren" };

            names1 = names2; // Her ikiside Deren Beren ve Seren oldu!
            names2[0] = "Adem"; // Adem Deren Beren şekline dönüştü.

            Console.WriteLine(names1[0]);
            Console.WriteLine(names2[0]);
            // String, Object, Array, Class, Abstract Class, Interface,, Delegate, Pointer referans tiptir.
            // Referans tipler stack ve heap ile çalışır.
            // Değişkenler stackte değerleri Heapte bir adres oluşturularak tutulur.
            // Eşitlenen iki elemanın adresleri aynı olduğu için değişim her ikisi içinde geçerli olacaktır.

            Console.WriteLine("----------------");

            string surname1 = "Çalışkan";
            string surname2 = "Caliskan";

            surname1 = surname2; // Her ikiside Caliskan oldu.
            surname2 = "Callisskan"; // Sadece surname2 Callisskan oldu.

            Console.WriteLine(surname1);
            Console.WriteLine(surname2);
            // String referans türü olmasına rağmen metotlara geçirilirken değer tipiymiş gibi kopyalanırlar.
            // Adresleme yapılmadığı sürece değer tip gibi davranır.
            // Adresleme ise ref ve out keyword'ü ile yapılır.

            Console.WriteLine("----------------");

            double r = 1.6; // Ref keyword'ünde ilk değer atanması zorunludur. Değer parametreye ilişkilendirilecektir.
            Console.WriteLine("Double sayı : {0}", r); // 1.6
            Square(ref r); // 1.6**2
            Console.WriteLine("Karesi alınmış değeri : {0}", r); // 1.6**2 yazdırılır.
            // ref r göndermek değişimin yansıtılmasını, değerinin adreslenmesini sağlar.

            bool b; // Out keyword'ünde ilk değer ataması zorunlu değildir. Çünkü metottan birden fazla değer dönsün isteriz.
            int max = Max(9, 2, out b);
            Console.WriteLine(b);

            Console.WriteLine("----------------");

            Person person1 = new Person();
            person1.FirstName = "İrem";

            Person person2 = new Person();
            person2 = person1;
            person1.FirstName = "Derin"; // Adresler aynı, değerleri de eşitlenir.
            Console.WriteLine(person2.FirstName + " " + person1.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "12345678923";
            Employee employee = new Employee();
            employee.FirstName = "Ali";
            //customer = employee; // int = string gibi typlerı farklı

            Person person3 = customer; // Person miras alınan sınıf, yer tutucu olduğu için üzerinde onu miras alanları tutabilir.
            //customer = Person person4; // Customer is a Person'dur. Person is Customer değil!
            person3.FirstName = "Ahmet";

            Console.WriteLine(customer.FirstName + " " + person3.FirstName);

            Console.WriteLine(((Customer)person3).CreditCardNumber); // Boxing uygulayarak ulaşılamayan özelliklere ulaşılır.

            PersonManager personManager = new PersonManager();
            personManager.Add(customer); // Ahmet döner
            personManager.Add(person1);  // Derin döner
            personManager.Add(employee); // Ali

        }
        static void Square(ref double d)
        {
            d = d * d;
        }

        static int Max(int x, int y, out bool b) 
        {
            if (x > y)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return Math.Max(x, y);
        }
    }

    // Inheritance
    class Person // Base Class, Parent Class
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; } // Ek özellikleri
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person) // Miras alan her sınıfı parametre olarak gönderebiliriz.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
