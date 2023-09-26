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
    public partial class AddStepsForm : Form
    {

        private List<Mode> _modes;
        private List<Step> _steps;
        public AddStepsForm(List<Mode> modes, List<Step> steps)
        {
            InitializeComponent();

            _modes = modes;
            _steps = steps;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text.Trim())
                || String.IsNullOrEmpty(textBox2.Text.Trim())
                || String.IsNullOrEmpty(textBox3.Text.Trim())
                || String.IsNullOrEmpty(textBox4.Text.Trim())
                || String.IsNullOrEmpty(textBox5.Text.Trim())
                || String.IsNullOrEmpty(textBox6.Text.Trim()))
            {
                MessageBox.Show("Fill in all fields");
                return;
            }

            if (!Int32.TryParse((textBox1.Text), out int modeId))
            {
                MessageBox.Show("Smth with modeid, sorry");
                return;
            }

            if (_modes.Where(m => m.Id == modeId).Count()==0 || modeId==0)
            {
                MessageBox.Show("No suitable mode, sorry");
                return;
            }

            try
            {
                Step step = new Step();
                step.ModeId =modeId;
                step.Timer = textBox2.Text.Trim();
                step.Destination = textBox3.Text.Trim();
                step.Speed = textBox4.Text.Trim();
                step.Type = textBox5.Text.Trim();
                step.Volume = textBox6.Text.Trim();

                step.IsNew = true;

                _steps.Add(step);
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
