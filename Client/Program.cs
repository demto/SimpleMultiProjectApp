using BusinessLogic.ServiceLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            var service = new PersonServices();

            service.AddNewPerson("Name1", "NickName1", "002512651651");
            service.AddNewPerson("Name2", "NickName2", "002512651652");

            Console.ReadLine();

            var persons = service.GetAllPersons();
            service.DeletePerson(1);

            Console.ReadLine();
        }
    }
}
