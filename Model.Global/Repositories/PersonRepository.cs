using Model.Global.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Model.Global.Repositories.IRepositoy;

namespace Model.Global.Repositories
{
    public class PersonRepository:IRepository<Person,Guid>
    {
        private DataContext EF;
        public PersonRepository()
        {
            EF = new DataContext();
        }
        /// <summary>
        /// Method to create a new Person
        /// </summary>
        /// <param name="entity">Person</param>
        /// <returns>Guid of person created</returns>
        public Guid Create(Person entity)
        {
            EF.ListPersons.Add(entity);
            EF.SaveChanges();
            return entity.Id;
        }
        /// <summary>
        /// Method to delete a Person who exist
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>Return true if deltion is done</returns>
        /// <exception cref="Exception">Return an Exception : An error occurred during the process</exception>
        public bool Delete(Guid id)
        {
            if (EF.ListPersons.Select(p => p.Id).Contains(id))
            {
                Person personToRemove = EF.ListPersons.Where(p => p.Id == id).SingleOrDefault();
                EF.ListPersons.Remove(personToRemove);
                EF.SaveChanges();
                return true;
            }
            else
            {
                throw new Exception("An error occurred during the process");
            }
        }
        /// <summary>
        /// Method to get a Person who exist
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>If Person exist return a Person</returns>
        /// <exception cref="Exception">Return an Exception : Person not exist</exception>
        public Person Get(Guid id)
        {
            if (EF.ListPersons.Select(p => p.Id).Contains(id))
            {
                return EF.ListPersons.Where(p => p.Id == id).SingleOrDefault();
            }
            else
            {
                throw new Exception("Person not exist");
            }
        }

        /// <summary>
        /// Method to get a list of Person.
        /// If parameter search is present return a person. This method should be improve.
        /// </summary>
        /// <param name="search">string</param>
        /// <returns>IEnumerable of Person</returns>
        public IEnumerable<Person> Get(string search)
        {
            if (search != null)
            {
                string searchWord = search.ToUpper();
                if (EF.ListPersons.Select(p => p.Nom.ToUpper()).Contains(searchWord))
                {
                    return EF.ListPersons.Where(p => p.Nom.ToUpper().Contains(searchWord));
                }
                else
                {
                    return EF.ListPersons.Where(p => p.Prenom.ToUpper().Contains(searchWord));
                }
            }
            else
            {
                return EF.ListPersons;
            }
        }
        /// <summary>
        /// Methot to update a person
        /// </summary>
        /// <param name="entity">Person</param>
        /// <returns>True if Updae is done</returns>
        /// <exception cref="Exception">Return Exception : An error occurred during the process</exception>
        public bool Update(Person entity)
        {
            if (EF.ListPersons.Select(p => p.Id).Contains(entity.Id))
            {
                Person oldPerson = EF.ListPersons.Where(p => p.Id == entity.Id).SingleOrDefault();
                EF.ListPersons.Update(entity);
                EF.SaveChanges();
                return true;
            }
            else
            {
                throw new Exception("An error occurred during the process");
            }
        }
    }
}
