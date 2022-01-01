using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Term_Project.User_DB_layer;

namespace Term_Project.Classes
{
    class Findings
    {
        private int ID;
        private string Result;

        public Findings(int ID,String Order)
        {
            this.ID = ID;
            this.Result = Order;
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
            LabresultDBLayer ui3 = new LabresultDBLayer();
            ui3.savePatient(this);
        }
    }
}
