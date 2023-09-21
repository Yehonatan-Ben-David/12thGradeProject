using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HoursOfDoctors
    {
        private int id;
        private Doctors idD;
        private string workDay;
        private string workStartHour;
        private string workEndHour;

        public int Id { get => id; set => id = value; }
        public Doctors IdD { get => idD; set => idD = value; }
        public string WorkDay { get => workDay; set => workDay = value; }
        public string WorkStartHour { get => workStartHour; set => workStartHour = value; }
        public string WorkEndHour { get => workEndHour; set => workEndHour = value; }
    }
}
