using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModesAndStepsSolution
{
    public partial class MainForm : Form
    {
        public MainForm(string login)
        {
            InitializeComponent();

            labelForLoginShow.Text = login;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
