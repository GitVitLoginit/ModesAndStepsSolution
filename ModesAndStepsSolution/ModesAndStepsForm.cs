namespace ModesAndStepsSolution
{
    public partial class ModesAndStepsForm : Form
    {
        private SQLiteProvider sQLiteProvider;

        public ModesAndStepsForm()
        {
            InitializeComponent();

            sQLiteProvider = new SQLiteProvider();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text.Trim();
            var password = textBoxPassword.Text.Trim();
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                labelValidationHint.Text = "Fill in both fields";
                return;
            }


            bool loginIsOk = sQLiteProvider.Login(login, password);

            if (loginIsOk)
            {
                MainForm mainForm = new MainForm(login, sQLiteProvider);
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login failed. Check login info");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text.Trim();
            var password = textBoxPassword.Text.Trim();
            const byte passwMinLength = 6;

            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                labelValidationHint.Text = "Fill in both fields";
                return;
            }

            if (password.Length < passwMinLength || !password.Any(char.IsDigit) || !password.Any(char.IsLetter))
            {
                labelValidationHint.Text = "Incorrect password format. " + "\n" +
                    "It must contain at least 1 digit and 1 letter.";

                return;
            }

            bool registerIsOk = sQLiteProvider.AddNewUser(login, password);

            if (registerIsOk)
            {
                MainForm mainForm = new MainForm(login, sQLiteProvider);
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Registration  failed. Check registrtation info");
            }


        }

        private void ModesAndStepsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sQLiteProvider.Dispose();
        }
    }
}