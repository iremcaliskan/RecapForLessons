using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // List Generic Class'ı arkaplanda bir array yönetir.
            //MyList names = new MyList(); // Şuan bir sınıf instance'ı oluşturuldu. Generic yapıda değil.
            MyList<string> names = new MyList<string>(); //Generic sınıfın instance'ı oluşturuldu.
            names.Add("İrem");
            names.Add("Ceren");

            Console.WriteLine(names.Length);
            //Console.WriteLine(names.Items);
            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names.Items[i]); //Liste elemanlarının i. elemanını yazdır.
            }
        }
    }
}
