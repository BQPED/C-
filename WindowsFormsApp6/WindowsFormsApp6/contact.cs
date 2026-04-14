using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class Contact
    {

        private string firstName;
        private string lastName;
        private string phone;
        private string mail;
        private DateTime birthDate;
        private string category;

        public string FirstName { get { return firstName;} set { firstName = value; } }
        public string LastName { get { return lastName;} set { lastName = value; } }
        public string Phone { get { return phone;} set { phone = value; } } 
        public string Mail { get { return mail;}    set { mail = value; } }
        public DateTime BirthDate { get {   return birthDate; } set { birthDate = value; } }
        public string Category { get { return category;} set { category = value; } }

        public override string ToString()
        {
            return $"{LastName} {firstName} - {phone}";
        }
        public Contact()
        {

        }


    }
}
