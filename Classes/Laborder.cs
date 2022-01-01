using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Term_Project.User_DB_layer;

namespace Term_Project.Classes
{
    class Laborder
    {
        private int ID;
        private string Symptoms;
        private string Order;

        public Laborder(int ID, string Symptoms,string Order)
        {
            this.ID = ID;
            this.Symptoms = Symptoms;
            this.Order = Order;
        }

        public int id
        {
            get { return ID; }
            set { this.ID = value; }
        }
        public string symptoms
        {
            get { return Symptoms; }
            set { this.Symptoms = value; }
        }
        public string order
        {
            get { return Order; }
            set { this.Order = value; }
        }

        public void saveUser()
        {
            LaborderDBLayer ui3 = new LaborderDBLayer();
            ui3.savePatient(this);
        }
    }
}
