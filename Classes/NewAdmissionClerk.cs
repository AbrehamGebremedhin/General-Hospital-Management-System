using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Term_Project.User_DB_layer;

namespace Term_Project.Classes
{
    class NewAdmissionClerk
    {
        private string Firstname;
        private string Middlename;
        private string Lastname;
        private DateTime DOB;
        private string Phonenumber;
        private string Address;
        private string Gender;
        private string Position;
        private string Qualification;
        private int Salary;
        private DateTime JoinDate;

        public NewAdmissionClerk(string Firstname, string Middlename, string Lastname, DateTime DOB, string Phonenumber, string Address, string Gender, string Position, string Qualification, int Salary, DateTime Joindate)
        {
            this.Firstname = Firstname;
            this.Middlename = Middlename;
            this.Lastname = Lastname;
            this.DOB = DOB;
            this.Phonenumber = Phonenumber;
            this.Address = Address;
            this.Gender = Gender;
            this.Position = Position;
            this.Qualification = Qualification;
            this.Salary = Salary;
            this.JoinDate = Joindate;
        }
        public string firstname
        {
            get { return Firstname; }
            set { this.Firstname = value; }
        }

        public string middlename
        {
            get { return Middlename; }
            set { this.Middlename = value; }
        }
        public string lastname
        {
            get { return Lastname; }
            set { this.Lastname = value; }
        }
        public DateTime dob
        {
            get { return DOB; }
            set { this.DOB = value; }
        }
        public string phonenumber
        {
            get { return Phonenumber; }
            set { this.Phonenumber = value; }
        }

        public string address
        {
            get { return Address; }
            set { this.Address = value; }
        }
        public string gender
        {
            get { return Gender; }
            set { this.Gender = value; }
        }
        public string position
        {
            get { return Position; }
            set { this.Position = value; }
        }
        public string qualification
        {
            get { return Qualification; }
            set { this.Qualification = value; }
        }
        public int salary
        {
            get { return Salary; }
            set { this.Salary = value; }
        }
        public DateTime joindate
        {
            get { return JoinDate; }
            set { this.JoinDate = value; }
        }

        public void saveUser()
        {
            AdmissionDBLayer ui3 = new AdmissionDBLayer();
            ui3.savePatient(this);
        }
    }
}
