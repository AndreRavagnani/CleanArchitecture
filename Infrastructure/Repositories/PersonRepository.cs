using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Context;

namespace Data.Repositories
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(AppDbContext context) : base(context, context.Persons)
        {
        }
    }
}
