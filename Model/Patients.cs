using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Patients : BaesTbl
    {
        private int id;
        private DateTime yearOfBirth;
        private string address;
        private HMO hMO;
        private string email;
        private DateTime dateOfJoiningTheApp;

        public int Id { get => id; set => id = value; }
        public DateTime YearOfBirth { get => yearOfBirth; set => yearOfBirth = value; }       
        public string Address { get => address; set => address = value; }        
        public HMO HMO { get => hMO; set => hMO = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DateOfJoiningTheApp { get => dateOfJoiningTheApp; set => dateOfJoiningTheApp = value; }
    }
}
