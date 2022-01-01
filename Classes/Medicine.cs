using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Term_Project.User_DB_layer;

namespace Term_Project.Classes
{
    class Medicine
    {
        private int ID;

        public Medicine(int ID)
        {
            this.ID = ID;
        }

        public string medicine { get; set; }

        public void saveUser()
        {
            DisplayMedicine ui3 = new DisplayMedicine();
            ui3.savePatient(this);
        }
    }
}
