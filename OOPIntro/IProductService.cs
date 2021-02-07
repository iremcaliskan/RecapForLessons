using System;
using System.Collections.Generic;
using System.Text;

namespace OOPIntro
{
    public interface IProductService
    { // Veritabanı işlemleri için Service ismi kullanılır. (DAL)
        void Add(Product product); // Ürün ver
        void Update(Product product);
        void Delete(Product product);

    }
}
