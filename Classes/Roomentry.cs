using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Term_Project.User_DB_layer;

namespace Term_Project.Classes
{
    class Roomentry
    {
        private string Name;
        private string Roomnumber;
        private string Roomtype;
        private int Roomfee;

        public Roomentry(string Name, string Roomnumber, string Roomtype, int Roomfee)
        {
            this.Name = Name;
            this.Roomnumber = Roomnumber;
            this.Roomtype = Roomtype;
            this.Roomfee = Roomfee;
        }

        public string name
        {
            get { return Name; }
            set { this.Name = value; }
        }
        public string roomnumber
        {
            get { return Roomnumber; }
            set { this.Roomnumber = value; }
        }
        public string roomtype
        {
            get { return Roomtype; }
            set { this.Roomtype = value; }
        }
        public int roomfee
        {
            get { return Roomfee; }
            set { this.Roomfee = value; }
        }

        public void saveUser()
        {
            RoomEntryDBLayer ui3 = new RoomEntryDBLayer();
            ui3.savePatient(this);
        }
    }
}