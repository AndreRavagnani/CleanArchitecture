using Application.ViewModels;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IPersonService : IGenericService<Person>
    {
        PersonViewModel GetPersons();
    }
}
