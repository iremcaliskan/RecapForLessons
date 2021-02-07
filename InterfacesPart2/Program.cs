namespace InterfacesPart2
{
    public class Program
    {
        static void Main(string[] args)
        { // Bir class birden fazla interface implement edebilir.
            // Interface Segregation, SOLID - I
            // Arayüz ayrımı
            IWork[] workers = new IWork[]
                { 
                    new Manager(),
                    new Worker(),
                    new Robot()
                };
            foreach (var worker in workers)
            {
                worker.Work(); // Tüm çalışanlara çalışma emri gönderildi.
            }
            IEat[] eats = new IEat[]
                { 
                    new Manager(),
                    new Worker()
                };
            foreach (var eat in eats)
            {
                eat.Eat(); // Tüm çalışanlara yemek vakti anonsu gönderildi.
            }
            ISalary[] getPaid = new ISalary[]
                {
                    new Manager(),
                    new Worker()
                };
            foreach (var pay in getPaid)
            {
                pay.GetSalary(); // Tüm çalışanlara ödeme gönderildi.
            }
        }
    }
}
