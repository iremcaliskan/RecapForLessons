using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] {"İrem","Ceren","Kerem","Beren","Seren"};
            Console.WriteLine(names.Length);
            Console.WriteLine(names[0]);
            // Var olan diziyi bozmadan index belirterek ekleme yapmak mümkün değildir.
            // names[5] = "Deren" ile atama yapamayız.
            // newlersekte yeni adres oluşur, önceki elemanları alamayız.

            names = new string[5];
            names[4] = "Deren";
            // Öncesi gelmez!
            // Bundan dolayı arrayler genellikle kullanılmaz! 

            // Çözüm List :)
            List<string> firsNames = new List<string>() { "İrem", "Ceren", "Kerem", "Beren", "Seren"};
            Console.WriteLine(firsNames); // System.Generic.Collection.List yazdırır.
            firsNames.Add("Adem");
            firsNames.Remove("Beren");
            /*
            for (int i = 0; i < firsNames.Count; i++)
            {
                Console.WriteLine(firsNames[i]); 
            }
            Console.WriteLine("------------");
            foreach (var firsName in firsNames)
            {
                Console.WriteLine(firsName);
            }
            */
            // List bir sınıf ve Generic yapıda. Aynısını yazalım.
            // Yazmadan önce Generic yapısını öğrenelim --- <>
        }
    }
}
