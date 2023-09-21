using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BaesTbl
    {
        private int id;
        private string firstName;
        private string lastName;
        private string gender;
        private City city;
        private string phoneNumber;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public City City { get => city; set => city = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
