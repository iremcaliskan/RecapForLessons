using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Customer
    { // Özellikleri tutmak içinde classlar kullanılır.
        public int CustomerId { get; set; }

        //propfull
        // implementasyon detayının gizlenmesi = encapsulation
        // Single Responsibility'e aykırıdır.
        /*
        private string _firstName;
        public string FirstName { 
            get 
            {
                return "Mrs." + _firstName; // Önünde Mr. olacak şekilde verir
            }
            set 
            {
                _firstName = value; // Set etmeye çalışılan değer = value
            } 
        }
        */
        public string FirstName { get; set; } // Aynı durumu property'e de uygulayabiliriz.
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
/* field:  public string FirstName;
 * property: public string FirstName { get; set; }
 * Encapsulation
 */
