using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserRegistration
    {
        public bool ValidateFirstName(string firstName)
        {
            Regex firstNamePattern = new Regex("^[A-Z][a-z]{3,}$");
            Match firstNameMatcher = firstNamePattern.Match(firstName);

            return firstNameMatcher.Success;
            
        }

        public bool ValidateLastName(string lastName)
        {
            Regex lastNamePattern = new Regex("^[A-Z][a-z]{3,}$");
            Match lastNameMatcher = lastNamePattern.Match(lastName);

            return lastNameMatcher.Success;
        }

        public bool ValidateEmail(string email)
        {
            Regex emailPattern = new Regex("^[0-9a-zA-Z]+([.]([a-z0-9A-Z]+))*[@][a-zA-Z]+[.][a-z]{2,4}([.][a-z]{2})?$");
            Match emailMatcher = emailPattern.Match(email);

            return emailMatcher.Success;
        }

        public bool ValidatePhoneNumber(string phoneNumber)
        {
            Regex phoneNumberPattern = new Regex("^[+]{1}[0-9]{2}\\s[0-9]{10}$");
            Match phoneNumberMatcher = phoneNumberPattern.Match(phoneNumber);

            return phoneNumberMatcher.Success;
        }

        public bool ValidatePassword(string password)
        {
            Regex passwordPattern = new Regex("^(?=.*[A-Z])(?=.*[0-9])[A-Z+a-z0-9]{8,}$");
            Match passwordMatcher = passwordPattern.Match(password);

            return passwordMatcher.Success;
        }
    }
}
