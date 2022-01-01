using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Term_Project.User_DB_layer;

namespace Term_Project.Classes
{
    class LabratoryResults
    {
        private int ID;
        private string Result;

        public LabratoryResults(int ID)
        {
            this.ID = ID;
        }
        public int id
        {
            get { return ID; }
            set { this.ID = value; }
        }
        public string result
        {
            get { return Result; }
            set { this.Result = value; }
        }

        public void saveUser()
        {
            DisplayresultDBLayer ui3 = new DisplayresultDBLayer(); 
            ui3.savePatient(this);
        }
    }
}
