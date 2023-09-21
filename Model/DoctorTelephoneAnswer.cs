using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class DoctorTelephoneAnswer
    {
        private int id;
        private Doctors idD;
        private string answerDay;
        private string answerStartHour;
        private string answerEndHour;

        public int Id { get => id; set => id = value; }
        public Doctors IdD { get => idD; set => idD = value; }
        public string AnswerDay { get => answerDay; set => answerDay = value; }
        public string AnswerStartHour { get => answerStartHour; set => answerStartHour = value; }
        public string AnswerEndHour { get => answerEndHour; set => answerEndHour = value; }
    }
}
