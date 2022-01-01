using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Term_Project.Forms
{
    public partial class Bill : Form
    {
        private string text1;
        private string text2;
        private string text3;

        public Bill()
        {
            InitializeComponent();
        }

        public Bill(string text1, string text2, string text3)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
        }

        internal void saveUser()
        {
            throw new NotImplementedException();
        }
    }
}
