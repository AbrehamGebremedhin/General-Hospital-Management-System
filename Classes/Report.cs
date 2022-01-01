using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Term_Project.User_DB_layer;

namespace Term_Project.Classes
{
    class Report
    {
        private int ID;
        private string Summary;
        private string Medicine;
        private int Recoveryday;
        private string isAdmitted;

        public Report(int ID, string Summary,string Medicine,int Recoveryday, string isAdmitted)
        {
            this.ID = ID;
            this.Summary = Summary;
            this.Medicine = Medicine;
            this.Recoveryday = Recoveryday;
            this.isAdmitted = isAdmitted;
        }

        public int id
        {
            get { return ID; }
            set { this.ID = value; }
        }
        public string summary
        {
            get { return Summary; }
            set { this.Summary = value; }
        }
        public string medicine
        {
            get { return Medicine; }
            set { this.Medicine = value; }
        }
        public int recoverydays
        {
            get { return Recoveryday; }
            set { this.Recoveryday = value; }
        }
        public string isadmitted
        {
            get { return isAdmitted; }
            set { this.isAdmitted = value; }
        }

        public void saveUser()
        {
            PatientDiagnosisDBLayer ui3 = new PatientDiagnosisDBLayer();
            ui3.savePatient(this);
        }
    }
}
