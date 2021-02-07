using System;

namespace InterfacesPart3
{
    public class ProjectManager
    {
        public void Add(IPersonManager personManager) // Parametre olarak implement eden her sınıfı tutan Interface'i yazarız.
        {
            personManager.Add();
        }

        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
