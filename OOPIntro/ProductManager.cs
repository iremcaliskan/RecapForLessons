using System;
using System.Collections.Generic;
using System.Text;

namespace OOPIntro
{
    public class ProductManager : IProductService
    {
        // Encapsulation
        public void Add(Product entity)
        {
            Console.WriteLine("{0} ürünü eklendi", entity.ProductName);
        }

        public void Delete(Product entity)
        {
            Console.WriteLine("{0} ürünü silindi", entity.ProductName);
        }

        public void Update(Product entity)
        {
            Console.WriteLine("{0} ürünü güncellendi", entity.ProductName);
        }
        // void metotları emir kipleri gibidir. Ekle, Sil, Güncelle gibi emirler.
        // Emrettiğin işlem sonucuna ihtiyacın yoksa void tanımlanır,
        // Sonuçla ilgilenilmeyen tüm metotlar void olur.
    }
}
