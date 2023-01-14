using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Services
{
    public class PersonRepository : IPersonRepository
    {
        public IPersonRepository _personRepository;

        public PersonRepository(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Task<int> AddAsync(Person entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Person entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Person>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
