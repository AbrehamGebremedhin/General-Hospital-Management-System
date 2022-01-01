using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Term_Project.User_DB_layer;

namespace Term_Project.Classes
{
    class Bill
    {
        private int ID;
        private string Type;
        private int Price;

        public Bill(int ID,string Type,int Price)
        {
            this.ID = ID;
            this.Type = Type;
            this.Price = Price;
        }

        public int id
        {
            get { return ID; }
            set { this.ID = value; }
        }
        public string type
        {
            get { return Type; }
            set { this.Type = value; }
        }
        public int price
        {
            get { return Price; }
            set { this.Price = value; }
        }

        public void saveUser()
        {
            BillDBLayer ui3 = new BillDBLayer();
            ui3.savePatient(this);
        }
    }
}
