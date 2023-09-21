using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VacantQueue
    {
        private int iDQueue;
        private Doctors idD;       
        private DateTime date;
        private DateTime hour;
        private bool QueueBusy;

        public int IDQueue { get => iDQueue; set => iDQueue = value; }
        public Doctors IdD { get => idD; set => idD = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime Hour { get => hour; set => hour = value; }
        public bool QueueBusy1 { get => QueueBusy; set => QueueBusy = value; }
    }
}
