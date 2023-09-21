using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Doctors : BaesTbl
    {         
        private int id;
        private int SpecializationCategory;
        private string ClinicOrHospital;
        private string ClinicCityName;
        private DateTime workingDaysAndHours;
        private double YearsOfMedicalExperience;
        private bool AcceptingPatientsForTelephoneConsultation;
        private string phoneReceptionHours;


        public int Id { get => id; set => id = value; }
        public int SpecializationCategory1 { get => SpecializationCategory; set => SpecializationCategory = value; }      
        public string ClinicOrHospital1 { get => ClinicOrHospital; set => ClinicOrHospital = value; }
        public string ClinicCityName1 { get => ClinicCityName; set => ClinicCityName = value; }
        public DateTime WorkingDaysAndHours { get => workingDaysAndHours; set => workingDaysAndHours = value; }
        public double YearsOfMedicalExperience1 { get => YearsOfMedicalExperience; set => YearsOfMedicalExperience = value; }
        public bool AcceptingPatientsForTelephoneConsultation1 { get => AcceptingPatientsForTelephoneConsultation; set => AcceptingPatientsForTelephoneConsultation = value; }    
        public string PhoneReceptionHours { get => phoneReceptionHours; set => phoneReceptionHours = value; }
    }
}
