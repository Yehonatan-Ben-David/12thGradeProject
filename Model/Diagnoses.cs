using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Diagnoses
    {
        private int id;
        private int idP;
        private int idD;
        private DateTime date;
        private DateTime hour;
        private string patientComplaints;
        private string theDoctorDiagnosis;

        public int Id { get => id; set => id = value; }
        public int IdP { get => idP; set => idP = value; }
        public int IdD { get => idD; set => idD = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime Hour { get => hour; set => hour = value; }
        public string PatientComplaints { get => patientComplaints; set => patientComplaints = value; }
        public string TheDoctorDiagnosis { get => theDoctorDiagnosis; set => theDoctorDiagnosis = value; }
      
        
    }
}
