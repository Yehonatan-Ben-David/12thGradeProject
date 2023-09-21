using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Queuing : BaseQueues
    {
        private int id;      
        private DateTime preferenceForDay;
        private DateTime preferenceForHour;
        private City preferenceForTheCityOfTheClinicOrHospital;
        private bool backToThePatient;

        public int Id { get => id; set => id = value; }
        public DateTime PreferenceForDay { get => preferenceForDay; set => preferenceForDay = value; }
        public DateTime PreferenceForHour { get => preferenceForHour; set => preferenceForHour = value; }
        public City PreferenceForTheCityOfTheClinicOrHospital { get => preferenceForTheCityOfTheClinicOrHospital; set => preferenceForTheCityOfTheClinicOrHospital = value; }
        public bool BackToThePatient { get => backToThePatient; set => backToThePatient = value; }
    }
}
