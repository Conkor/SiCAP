using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiCAPV002.App_Domain
{
    class Major
    {
        private int idMajor;
        private string mainMajor;
        private string faculty;

        public int IdMajor
        {
            get { return idMajor; }
            set { idMajor = value; }
        }
        public string MainMajor
        {
            get { return mainMajor; }
            set { mainMajor = value; }
        }
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }
        public Major(int idMajor, string mainMajor)
        {
            this.idMajor = idMajor;
            this.mainMajor = mainMajor;
        }
    }
}
