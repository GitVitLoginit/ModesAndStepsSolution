using Microsoft.VisualBasic.Logging;
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
    public partial class MainForm : Form
    {
        private SQLiteProvider _sQLiteProvider;
        private List<Mode> _modes;
        private List<Step> _steps;
        public MainForm(string login, SQLiteProvider sQLiteProvider)
        {
            InitializeComponent();
            _sQLiteProvider = sQLiteProvider;

            labelForLoginShow.Text = login;


            LoadModesFromDb();
            LoadStepsFromDb();

            IntializeGrid();


            dataGridForModes.CellValueChanged += dataGridForModes_CellValueChanged;
            dataGridForSteps.CellValueChanged += dataGridForSteps_CellValueChanged;
        }

        private void IntializeGrid()
        {
            dataGridForModes.DataSource = _modes.Where(m => !m.IsDeleted).ToList();
            dataGridForModes.Columns["Id"].ReadOnly = true;


            dataGridForSteps.DataSource = _steps.Where(m => !m.IsDeleted).ToList();
            dataGridForSteps.Columns["StepId"].ReadOnly = true;
            dataGridForSteps.Columns["ModeId"].ReadOnly = true;
        }

        private void LoadModesFromDb()
        {
            var modes = _sQLiteProvider.ReadQuery(@"SELECT * FROM Modes", new List<Models.SqlCommandParameter>());

            if (modes?.Rows == null || modes.Rows.Count == 0) { return; }

            _modes = new List<Mode>();
            foreach (DataRow row in modes.Rows)
            {
                _modes.Add(new Mode
                {
                    Id = Int32.Parse(row["ID"].ToString()),
                    Name = row["Name"].ToString(),
                    MaxBottleNumber = Int32.Parse(row["MaxBottleNumber"].ToString()),
                    MaxUsedTips = Int32.Parse(row["MaxUsedTips"].ToString()),
                });
            }

        }


        private void LoadStepsFromDb()
        {
            var steps = _sQLiteProvider.ReadQuery(@"SELECT * FROM Steps", new List<Models.SqlCommandParameter>());

            if (steps?.Rows == null || steps.Rows.Count == 0) { return; }

            _steps = new List<Step>();
            foreach (DataRow row in steps.Rows)
            {
                _steps.Add(new Step
                {
                    Id = Int32.Parse(row["ID"].ToString()),
                    ModeId = Int32.Parse(row["ModeId"].ToString()),
                    Timer = row["Timer"].ToString(),
                    Destination = row["Destination"].ToString(),
                    Speed = row["Speed"].ToString(),
                    Type = row["Type"].ToString(),
                    Volume = row["Volume"].ToString()
                });
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeleteSelectedModes_Click(object sender, EventArgs e)
        {
            if (dataGridForModes.SelectedRows.Count == 0)
                MessageBox.Show("No modes selected ");


            for (var i = 0; i < dataGridForModes.SelectedRows.Count; i++)
            {
                var item = dataGridForModes.SelectedRows[i];

                dataGridForModes.Rows[item.Index].ReadOnly = true;
                dataGridForModes.CurrentCell = null;
                dataGridForModes.Rows[item.Index].Visible = false;

                var deletedMode = item.DataBoundItem as Mode;
                deletedMode.IsDeleted = true;
            }

        }

        private void DeleteSelectedSteps_Click(object sender, EventArgs e)
        {
            if (dataGridForSteps.SelectedRows.Count == 0)
                MessageBox.Show("No modes selected ");


            for (var i = 0; i < dataGridForSteps.SelectedRows.Count; i++)
            {
                var item = dataGridForSteps.SelectedRows[i];

                dataGridForSteps.Rows[item.Index].ReadOnly = true;
                dataGridForSteps.CurrentCell = null;
                dataGridForSteps.Rows[item.Index].Visible = false;

                var deletedStep = item.DataBoundItem as Step;
                deletedStep.IsDeleted = true;
            }
        }

        private void dataGridForModes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var changedMode = dataGridForModes.Rows[e.ColumnIndex].DataBoundItem as Mode;

            changedMode.IsModified = true;
        }

        private void dataGridForSteps_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var changedStep = dataGridForSteps.Rows[e.ColumnIndex].DataBoundItem as Step;

            changedStep.IsModified = true;
        }

        private void AddMode_Click(object sender, EventArgs e)
        {
            AddModeForm form = new AddModeForm(_modes);
            form.ShowDialog();

            dataGridForModes.DataSource = typeof(List<>);
            dataGridForModes.DataSource = _modes.Where(m => !m.IsDeleted).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AddStepsForm form = new AddStepsForm(_modes, _steps);
            form.ShowDialog();

            dataGridForSteps.DataSource = typeof(List<>);
            dataGridForSteps.DataSource = _steps.Where(m => !m.IsDeleted).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (var i=0; i < _modes.Count; i++)
            {
                var mode = _modes[i];

                if (!mode.IsDeleted && !mode.IsNew && !mode.IsModified)
                    continue;

                if (mode.IsDeleted && mode.IsNew)
                {
                    continue;
                }

                if (mode.IsDeleted && !mode.IsNew)
                {
                    _sQLiteProvider.DeleteMode(mode.Id);
                    continue;
                }

                if (mode.IsNew)
                {
                    _sQLiteProvider.AddMode(mode);
                    continue;
                }
                if (mode.IsModified)
                {
                    _sQLiteProvider.UpdateMode(mode);
                    continue;
                }
            }
        }
    }
}
