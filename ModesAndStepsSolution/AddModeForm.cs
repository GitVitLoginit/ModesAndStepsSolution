using ModesAndStepsSolution.Models;
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
    public partial class AddModeForm : Form
    {
        private List<Mode> _modes;
        public AddModeForm(List<Mode> modes)
        {
            InitializeComponent();

            _modes = modes;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty( textBox1.Text.Trim()) 
                || String.IsNullOrEmpty(textBox2.Text.Trim())
                ||String.IsNullOrEmpty(textBox3.Text.Trim()))
            {
                MessageBox.Show("Fill in all fields");
                return;
            }

            try
            {
                Mode mode=new Mode();
                mode.Name = textBox1.Text.Trim();
                mode.MaxBottleNumber = Int32.Parse(textBox2.Text.Trim());
                mode.MaxUsedTips = Int32.Parse(textBox3.Text.Trim());
                mode.IsNew = true;
                _modes.Add(mode);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Check format");
                return;
            }


        }
    }
}
