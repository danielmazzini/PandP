using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactList.Models
{
    public class ContactGridItemViewModel
    {
        public ContactGridItemViewModel(string firstName, string lastName, string email, string address, string stateName, string countryName)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Address = address;
            StateName = stateName;
            CountryName = countryName;
        }

        public string FirstName { get; }
        public string LastName { get; }

        public string Email { get; }

        public string Address { get; }
        public string StateName { get; }
        public string CountryName { get; }
   
    }
}
