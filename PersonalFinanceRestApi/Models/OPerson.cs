using System;

namespace PersonalFinanceRestApi.Models
{
    /// <summary>
    /// Represents a Person in the Personal Finance Database
    /// </summary>
    public class OPerson
    {
         
        #region Constructor

        public OPerson(decimal id, string firstname, string lastname, string city, string filingType, string state)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.city = city;
            this.filingType = filingType;
            this.state = state;
        }

        #endregion

        #region Private

        private readonly decimal id;
        private readonly string firstname;
        private readonly string lastname;
        private readonly string filingType;
        private readonly string city;
        private readonly string state;

        #endregion

        #region Public Getters

        public decimal Id => id;
        public string Firstname => firstname;
        public string Lastname => lastname;
        public string FilingType => filingType;
        public string City => city;
        public string State => state;

        #endregion

        #region Methods

        /// <summary>
        /// Converts the Entity Model PERSON type into a more usable OPerson type
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public static explicit operator OPerson(PERSON person)
        {
            return new OPerson(person.ID, person.FIRSTNAME, person.LASTNAME, person.CITY, person.FILINGTYPE, person.STATE.STATE1);   
        }

        public override string ToString()
        {
            return String.Format("{0}: {1} {2}. {3}. {4}, {5}", Id, Firstname, Lastname, FilingType, City, State);
        }

        #endregion
    }
}