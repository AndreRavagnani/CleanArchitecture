using Domain.Entities;

namespace Application.ViewModels
{
    public class PersonViewModel
    {
        public IEnumerable<Person> People { get; set; }
    }
}
