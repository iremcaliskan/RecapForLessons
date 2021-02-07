using System;
using System.Collections.Generic;
using System.Text;

namespace OOPIntro
{
   public class Product // Entity
    { // snippet : hazır kodlar
        public int ProductId { get; set; } // primary key
        public int CategoryId { get; set; } // foreign key
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        // Ürünlerin veritabanı işlemlerine geçilir, CRUD operasyonları
        // Veritabanı kodlama
        // Create Read Update Delete
    }
}
