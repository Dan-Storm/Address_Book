using System.Collections.Generic;

namespace Address_Book
{
    class AddressBook
    {
        public string EmployeeName { get; set; }
        public string LastName { get; set; }
        public string EmployeeTitle { get; set; }
        public string StartDate { get; set; }

        public Dictionary<string, Contact> allContacts = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            allContacts.Add(contact.Email, contact);
        }

        public Contact GetByEmail(string email) 
        { 
           try
           {
               Contact returnContact = allContacts[email];
               return returnContact;
           }
           catch (KeyNotFoundException)
           {
               return null;
           }
         }
    }
}
