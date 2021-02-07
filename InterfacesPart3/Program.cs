using System;

namespace InterfacesPart3
{
    class Program
    {
        static void Main(string[] args)
        { // Interface, onu implemente eden sınıfın referansını tutabilir.
            /*
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            employeeManager.Update();
            */

            // Projeyi tek noktadan yöneteceğiz.
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());
            projectManager.Update(new EmployeeManager());
            projectManager.Add(new InternManager());


        }
    }

    class PersonManager
    {
        // Implemented operation, içi doldurulmuş, tamamlanmış operasyon
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
    class WorkerManager : PersonManager
    { // inherits

    }

    // Yazılımda yeni bir şey eklemek için var olan kodlara dokunulmaz.
    // Yazılım sürekli değişen bir yapıdır. Sürekli değişime ayık uyduracak yapılar kurulmak zorundadır.
    public class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern is added");
        }

        public void Update()
        {
            Console.WriteLine("Intern is updated");
        }
    }
}
