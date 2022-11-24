using Microsoft.AspNetCore.Identity;

namespace ProgramowanieObiektoweMVC.Models.Person
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {

        }
        public List<PersonModel> Persons { get; set; }
    }
}
