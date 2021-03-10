using System;
using System.Collections.Generic;
using System.Text;
using MG = Model.Global.Models;
using static Model.Global.Repositories.IRepositoy;
using Model.Global.Models;

namespace Model.Client.Services
{
    public class PersonService : IRepository<MG.Person, Guid>
    {
        private IRepository<MG.Person, Guid> _repo;
        public PersonService(IRepository<MG.Person,Guid> repo)
        {
            _repo = repo;
        }
        public Guid Create(Person entity)
        {
            return _repo.Create(entity);
        }

        public bool Delete(Guid id)
        {
            return _repo.Delete(id);
        }

        public Person Get(Guid id)
        {
            return _repo.Get(id);
        }

        public IEnumerable<Person> Get(string search)
        {
            return _repo.Get(search);
        }

        public bool Update(Person entity)
        {
            return _repo.Update(entity);
        }
    }
}
