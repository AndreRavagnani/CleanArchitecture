using Application.Interfaces;
using Application.ViewModels;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class PersonService : IPersonService
    {
        public IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<int> AddAsync(Person entity)
        {
            return await _personRepository.AddAsync(entity);
        }

        public async Task<bool> DeleteAsync(Person entity)
        {
            return await _personRepository.DeleteAsync(entity);
        }

        public async Task<IReadOnlyList<Person>> GetAllAsync()
        {
            return await _personRepository.GetAllAsync();
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _personRepository.GetByIdAsync(id);
        }

        public PersonViewModel GetPersons()
        {
            return new PersonViewModel()
            {
                People =  _personRepository.GetAllAsync().GetAwaiter().GetResult(),
            };
        }

        public async Task<bool> UpdateAsync(Person entity)
        {
            return await _personRepository.UpdateAsync(entity);
        }
    }
}
