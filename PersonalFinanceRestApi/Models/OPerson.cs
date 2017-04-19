
namespace PersonalFinanceRestApi.Models
{
    public class OPerson
    {
        public OPerson(decimal id, string firstname, string lastname, string city, string filingType, string state)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            City = city;
            FilingType = filingType;
            State = state;
        }

        public decimal Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public string FilingType { get; set; }
       
        public string State { get; set; }

        public static explicit operator OPerson(PERSON person)
        {
            return new OPerson(person.ID, person.FIRSTNAME, person.LASTNAME, person.CITY, person.FILINGTYPE, person.STATE.STATE1);   
        }
    }
}