using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Human
    {
        public string FirstName;
        public string LastName;
        public string MiddleName;
        public string Contry;
        public string GetFullName()
        {
            var fullname = FirstName + " " + LastName;
            return fullname;
        }
        public string PrintWelcomeMessage(string welcomeMessage)
        {
            var fullname = welcomeMessage + FirstName + " " + LastName;
            return fullname;
        }
        public string PrintWelcomeMessage(string welcomeMessage1="Welcome and ", string welcomeMessag2="Hello! ")
        {
            var fullname = welcomeMessage1+welcomeMessag2 + FirstName + " " + LastName;
            return fullname;
        }
        public bool IsFullNameLongerThanMaxLentgh(int maxLentgh)
            {
            if (FirstName.Length+LastName.Length> maxLentgh)
            {
                return true;
            }
            else
            {
                return false;
            }
            }
        public void Person1 (string firstName, string lastName, string contry)
            {
                firstName = FirstName;
                lastName = LastName;
                contry = Contry;
            }
        public void Person (string firstName, string lastName, string middleName)
            {
                firstName = FirstName;
                lastName = LastName;
                middleName = MiddleName;
            }
    }
}
