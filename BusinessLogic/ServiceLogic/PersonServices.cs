using DataAccess;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ServiceLogic
{
    public class PersonServices
    {
        public void AddNewPerson(string name, string nickName, string tel){
            using(var context = new SimpleAppContext()){
                var newPerson = new PersonDto()
                {
                    Name = name,
                    NickName = nickName,
                    TelephoneNumber = tel,
                };
                context.Persons.Add(newPerson);
                context.SaveChanges();
            }
        }

        public List<PersonDto> GetAllPersons()
        {
            using (var context = new SimpleAppContext())
            {
                return context.Persons.ToList();
            }
        }

        public void DeletePerson(int id){
            using(var context = new SimpleAppContext()){
                var personToDelete = context.Persons.Find(id);

            if(personToDelete != null){
                    context.Persons.Remove(personToDelete);
                }
            }
        }
    }
}
