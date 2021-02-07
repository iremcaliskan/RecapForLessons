using System;

namespace InterfacesPart3
{
    public interface IPersonManager
    {
        // Unimplemented operation, içi boş, doldurulmamış operasyon
        // Implement eden sınıf metodu doldurur.
        // Imza herkes için aynı, ama kullanım şekilleri değişkenlik gösterir.
        void Add();
        void Update();
    }
}
