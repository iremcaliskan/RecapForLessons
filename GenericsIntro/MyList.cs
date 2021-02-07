using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    public class MyList<T> // T : string, int, bool, class, istenilen her şey olabilir.
    { // T type'tan geliyor. MyList'te T ile çalışılacak. 
        // T : bir tip gönder onunla çalışayım demektir.
        T[] items;  //T tipinde bir array oluşturuldu, yönetmek için. Herkes ulaşabilsin diye global olarak tanımlandı.
        // T[] items Array'ini Class'ı newlediğimde oluşturmam gerekir. 0 elemanlı dahi olsa.
        // Array referans tip, newlenme zorunluluğu vardır.
        public MyList() // ctor olduğunu aynı isminden anlarsın.
        { // Class newlendiği an çalışır.
            // Constructor class newlendiği an otomatik çalışır.
            items = new T[0]; // newlendiği an 0 elemanlı olarak oluşturuldu.
        }
        public void Add(T item) // T türünde bir eleman ver
        {
            T[] tempArray = items; // items'ın referansı seninde referansın.
            items = new T[items.Length + 1]; // Dizinin eleman sayısını bir attırıcam.
            // Yeni newleme yeni referans demektir. Eski listenin referans numarasını yeni listeye atamamız gerekiyor.
            // Elemanlarını geri alma:
            for (int i = 0; i < tempArray.Length; i++) //tempArray'in tüm elemanlarını items'a geri atama
            {
                items[i] = tempArray[i];
            }
            // Değerler geri alındı.
            // Yeni gelen eleman eklenecek.
            items[items.Length - 1] = item; // Uzunluk 4 ise son index 3'tür. -1 o yüzden.
            // Bellekteki yönetimler üzerinden gidilir.

        }

        public int Length // MyList ile oluşturulan listenin uzunluğu, property şeklinde
        {
            get { return items.Length; }
        }

        public T[] Items // MyList ile oluşturulan listenin elemanları
        {
            get { return items; }
        }

    }
}
