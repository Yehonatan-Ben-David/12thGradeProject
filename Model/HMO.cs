using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HMO
    {
        private int iD;
        private string hMOName;

        public int ID { get => iD; set => iD = value; }
        public string HMOName { get => hMOName; set => hMOName = value; }
    }
}
