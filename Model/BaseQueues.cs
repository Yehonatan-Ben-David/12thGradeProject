using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BaseQueues
    { 
        private int id;
        private Doctors idD;
        private Patients idp;
        private Category category;

        public int Id { get => id; set => id = value; }
        public Doctors IdD { get => idD; set => idD = value; }
        public Patients Idp { get => idp; set => idp = value; }
        public Category Category { get => category; set => category = value; }
    }
}
