using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONTI_2023
{
    public partial class Popice : Form
    { 
        private string _email;
        public Popice(string email)
        {
            InitializeComponent();
            _email = email;
        }
    }
}
