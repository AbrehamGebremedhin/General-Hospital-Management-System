using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Term_Project.User_DB_layer;

namespace Term_Project.Classes
{
    class LabratoryRequest
    {
        private int ID;
        private string Request;

        public LabratoryRequest(int ID)
        {
            this.ID = ID;
        }

        public int id
        {
            get { return ID; }
            set { this.ID = value; }
        }

        public string request
        {
            get { return Request; }
            set { this.Request = value; }
        }

        public void saveUser()
        {
            DisplayLabRequest ui3 = new DisplayLabRequest();
            ui3.savePatient(this);
        }
    }
}
