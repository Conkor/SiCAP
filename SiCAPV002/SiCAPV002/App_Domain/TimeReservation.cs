using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiCAP_GrupoCARARA.App_Domain
{
    public class TimeReservation
    {

        private int id;
        private string timeReservation;

        public TimeReservation()
        {
            this.id = 0;
            this.timeReservation = "";
        }
        public TimeReservation(int id, string timeReservation) {
            this.id = id;
            this.timeReservation = timeReservation;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string TimeReservations
        {
            get { return timeReservation; }
            set { timeReservation = value; }
        }

    }
}
