using System;
using Term_Project.User_DB_layer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_Project.Classes
{
    class Newpatient
    {
        private string Firstname;
        private string Middlename;
        private string Lastname;
        private DateTime DOB;
        private float Weight;
        private string Phonenumber;
        private string Address;
        private string Gender;
        private string AlternativePhonenumber;
        private string Email;
        private string DoctorID;
        private string MartialStatus;

        public Newpatient(string Firstname, string Middlename, string Lastname,DateTime DOB,float Weight, string Phonenumber, string Address, string Gender, string AlternativePhonenumber, string Email, string DoctorID, string MartialStatus)
        {
            this.Firstname = Firstname;
            this.Middlename = Middlename;
            this.Lastname = Lastname;
            this.DOB = DOB;
            this.Weight = Weight;
            this.Phonenumber = Phonenumber;
            this.Address = Address;
            this.Gender = Gender;
            this.AlternativePhonenumber = AlternativePhonenumber;
            this.Email = Email;
            this.DoctorID = DoctorID;
            this.MartialStatus = MartialStatus;
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
        public float weight
        {
            get { return Weight; }
            set { this.Weight = value; }
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
        public string alternativephonenumber
        {
            get { return AlternativePhonenumber; }
            set { this.AlternativePhonenumber = value; }
        }
        public string email
        {
            get { return Email; }
            set { this.Email = value; }
        }
        public string martialstatus
        {
            get { return MartialStatus; }
            set { this.MartialStatus = value; }
        }
        public string doctorid
        {
            get { return DoctorID; }
            set { this.DoctorID = value; }
        }

        public void saveUser()
        {
            PatientDBLayer ui3 = new PatientDBLayer();
            ui3.savePatient(this);
        }
    }
}
