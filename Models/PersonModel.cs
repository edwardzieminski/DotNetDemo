using System;

namespace Models
{
    public class PersonModel
    {
        private string _firstName;

        public PersonModel()
        {
            
        }
        
        public string FirstName 
        {
            get 
            {
                return _firstName;
            }
            set 
            {
                _firstName = value;
            }
        }

        public string LastName { get; set; }

        public string GetFirstName() 
        {
            return _firstName;
        }
    }
}
