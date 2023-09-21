using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Queues : BaseQueues
    {
        private int id;      
        private DateTime date;
        private DateTime hour;       
        private bool PatientCameToTheDoctor;
        private bool patientPostponedTheAppointment;
        private bool PaidForMedicalTreatment;

        public int Id { get => id; set => id = value; }        
        public DateTime Date { get => date; set => date = value; }
        public DateTime Hour { get => hour; set => hour = value; }        
        public bool PatientCameToTheDoctor1 { get => PatientCameToTheDoctor; set => PatientCameToTheDoctor = value; }
        public bool PatientPostponedTheAppointment { get => patientPostponedTheAppointment; set => patientPostponedTheAppointment = value; }      
        public bool PaidForMedicalTreatment1 { get => PaidForMedicalTreatment; set => PaidForMedicalTreatment = value; }
    }
}
