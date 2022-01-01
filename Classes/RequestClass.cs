using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Term_Project.User_DB_layer;

namespace Term_Project.Classes
{
    class RequestClass
    {
        private string MedicineName;
        private string Manufactrer;
        private int Quantity;

        public RequestClass(string MedicineName, string Manufactrer, int Quantity)
        {
            this.MedicineName = MedicineName;
            this.Manufactrer = Manufactrer;
            this.Quantity = Quantity;
        }

        public string medicinename
        {
            get { return MedicineName; }
            set { this.MedicineName = value; }
        }
        public string manufactrer
        {
            get { return Manufactrer; }
            set { this.Manufactrer = value; }
        }
        public int quantity
        {
            get { return Quantity; }
            set { this.Quantity = value; }
        }

        public void saveUser()
        {
            MedicineRequestDBLayer ui3 = new MedicineRequestDBLayer();
            ui3.savePatient(this);
        }
    }
}
