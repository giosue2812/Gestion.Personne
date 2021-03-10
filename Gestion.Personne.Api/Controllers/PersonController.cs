using Gestion.Personne.Api.DContext.Repositories;
using Gestion.Personne.Api.Models;
using Gestion.Personne.Api.Models.Form;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Gestion.Personne.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PersonController : ControllerBase
    {
        private PersonneRepository _repo;
        public PersonController()
        {
            _repo = new PersonneRepository();
        }
        /// <summary>
        /// Action to GetList of Person Or. One person if filter is present
        /// </summary>
        /// <param name="search">sting optional</param>
        /// <returns>IEnumerable of Person</returns>
        [HttpGet("{search?}")]
        public IEnumerable<Person> GetList(string search = default)
        {
            try
            {
                IEnumerable<Person> persons = _repo.Get(search);
                return persons;
            }
            catch
            {
                throw new Exception("An error occurred during the process");
            }

        }
        /// <summary>
        /// Action to Get a person from Guid id
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>Person</returns>
        /// <exception cref="Exception">An error occurred during the process</exception>
        [HttpGet("person/{id}")]
        public Person Get(Guid id)
        {
            try
            {
                Person person = _repo.Get(id);
                return person;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Action to add a new Person
        /// </summary>
        /// <param name="personForm">PersonForm</param>
        /// <returns>Guid from person created</returns>
        [HttpPost]
        public Guid Post(PersonForm personForm)
        {
            try
            {
                Person person = new Person()
                {
                    Id = Guid.NewGuid(),
                    Nom = personForm.Nom,
                    Prenom = personForm.Prenom
                };
                return _repo.Create(person);
            }
            catch
            {
                throw new Exception("An error occurred during the process");
            }

        }
        /// <summary>
        /// Action to edit a person
        /// </summary>
        /// <param name="id">Guid</param>
        /// <param name="personForm">PersonForm</param>
        /// <returns>bool if update is done</returns>
        /// <exception cref="Exception">An error occurred during the process</exception>
        [HttpPut("{id}")]
        public bool Put(Guid id, PersonForm personForm)
        {
            try
            {
                Person person = _repo.Get(id);
                person.Nom = personForm.Nom;
                person.Prenom = personForm.Prenom;
                bool result = _repo.Update(person);
                return result;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Action to delete a Person
        /// </summary>
        /// <param name="id">Guid</param>
        /// <returns>bool if deletion is done</returns>
        /// <exception cref="Exception">An error occurred during the process</exception>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            try
            {
                return _repo.Delete(id);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
