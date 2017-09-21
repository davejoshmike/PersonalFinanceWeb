using System;

namespace PersonalFinanceRestApi.Models
{
    /// <summary>
    /// Represents a Person's Tax Information in the Personal Finance Database
    /// </summary>
    public class OTax
    {
        #region Constructor

        public OTax(decimal personId, string who, string why, decimal? rate, short taxYear)
        {
            this.personId = personId;
            this.who = who;
            this.why = why;
            this.rate = rate;
            this.taxYear = taxYear;
        }

        #endregion

        #region Private

        private decimal personId;
        private string who;
        private string why;
        private decimal? rate;

        private short taxYear;

        #endregion

        #region Public Getters

        public decimal PersonId => personId;
        public string Who => who;
        public string Why => why;
        public decimal? Rate => rate;

        public short TaxYear => taxYear;

        #endregion

        #region Methods

        public static explicit operator OTax(TAX tax)
        {
            return new OTax(tax.PERSONID, tax.WHO, tax.WHY, tax.RATE, tax.TAXYEAR.YEAR);
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}. {2}. {3}. {4}", PersonId, Who, Why, Rate, TaxYear);
        }

        #endregion
    }
}