using System;

namespace OOPIntro
{
    class Program
    { // Classlar ikiye ayrılır : 
        // 1- Özellik barındıran classlar 2- Operasyon, metot barındıran classlar
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            productManager.Add(new Product() {ProductId = 1, CategoryId = 1, ProductName = "Masa", UnitPrice = 500, UnitsInStock = 3 });
            productManager.Update(new Product() {ProductId = 2, CategoryId = 2, ProductName = "Bardak", UnitPrice = 20, UnitsInStock = 16 });
            productManager.Delete(new Product() { ProductId = 3, CategoryId = 3, ProductName = "Kalem", UnitPrice = 62, UnitsInStock = 23 });

            // Referans tip ile ilgili soru, Uzmanlık sorusu!
            // int, long, float, double, decimal, char, bool, byte, short, struct, enum --- değer tip
            int num = 100;
            DoSomething(num); // Sayının sadece değeri yollanır.
            DoSomething(100); // Her ikisi aynıdır, isim benzerliği var sadece.
            Console.WriteLine(num); // Output: 100
            // ref out keywordleri ile yollanabilir!

            // Object, Class, Interface, Array, Delegate, Pointer, Abstract class --- referans tip
            string[] names = new string[] { "İrem" }; // Bir adress oluşturulup listenin değerleri kaydedilir. Stack-Heap
            DoSomething2(names); // names'in adresini referan olarak yolla demektir.
            Console.WriteLine(names); // Output: Referans Tip

            // Bir referans türü olan String* ile ilgili bir istisna vardır. 
            // String referans türü olmasına rağmen metotlara geçirilirken değer tipiymiş gibi kopyalanırlar.
            
            // ref out keyworlerini referans tipler için kullanmak saçmadır, string dışında!
            // ref keyword'ü hem metodun bildiriminde, hemde metodun çağrılmasında kullanılmak zorundadır.
            // ref keyword'ünü içeeren metodu çağırmak için ref ile gönderilecek argümanın tanımlanması, değer atanması gerekir.
            // out keyword'ünün tek farkı başlangıç değerinin atanma zorunluluğu yoktur. b bool;
            // out keyword'ü için değer metot tarafından atanır. if() b=true else b=false
            // out keyword'ü bir metottan birden fazla geri dönüş beklenirse kullanılır. Örneğin bool, true yada false.

            
            SumVoid(5, 6);
            //int result = SumVoid(5, 6); //Değeri kullanamazsın
            SumInt(5, 6);
            int result = SumInt(5, 6);
            Console.WriteLine(result); //Değeri kullanabiliriz, sonuçla ilgilenmek istiyoruz!

        }

        static void DoSomething(int num) 
        {
            num = 99; // Gelen 100 değeri 99 olur.
            // Maindeki ile bağlantısızdır.
        }

        static void DoSomething2(string[] names) // ref string name
        {
            names[0] = "Referans Tip"; // Addresi parametre olarak yolladığımız için değişim Main'i etkiler.
        }

        static int SumInt(int num1, int num2)
        {
            return num1 + num2; // Döndür
        }

        static void SumVoid(int num1, int num2)
        {
            Console.WriteLine(num1 + num2); // Ekrana yaz
        }

    }
}

/*Encapsulation nedir? 
 * Bir nesnenin belirli özellik ve metodlarının saklanması, erişiminin kısıtlanmasıdır.
 * Erişime kısıtladığımız bu özellik ve metodları zaten kullanıcının görmemesi veya kullanmaması gerekiyordur.
 * Kontrolsüz veri girişini ve kötü amaçlı kullanımı önler.
 * Public: Öğenin kod içerisinde herhangi bir yerden erişilebilir olduğunu belirtir. Herhangi bir kısıtlama vs. bulunmamaktadır.
 * Private: Öğenin sadece tanımladığı sınıf içerisinde erişilebilir olduğunu belirtir.
 * Protected: Öğenin tanımlandığı sınıf içerisinde ve o sınıftan türeyen sınıflardan erişilebilir olduğunu belirtir.
 * Internal: Öğenin tanımlandığı assembly içerisinde erişilebilir olduğunu belirtir. O .dll içerisinde öğeye erişim konusunda kısıtlama yoktur fakat dışarıdan bu öğeye erişilemez.
 */