namespace ModesAndStepsSolution
{
    partial class ModesAndStepsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginButton = new Button();
            registerButton = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxLogin = new MaskedTextBox();
            textBoxPassword = new MaskedTextBox();
            labelValidationHint = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(37, 495);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(164, 51);
            loginButton.TabIndex = 5;
            loginButton.Text = "Вход";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(285, 495);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(164, 51);
            registerButton.TabIndex = 1;
            registerButton.Text = "Регистрация";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 60);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 187);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 3;
            label2.Text = "Пароль:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(37, 92);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(188, 27);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(37, 228);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(188, 27);
            textBoxPassword.TabIndex = 1;
            // 
            // labelValidationHint
            // 
            labelValidationHint.AutoSize = true;
            labelValidationHint.Location = new Point(42, 283);
            labelValidationHint.Name = "labelValidationHint";
            labelValidationHint.Size = new Size(0, 20);
            labelValidationHint.TabIndex = 6;
            // 
            // ModesAndStepsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 592);
            Controls.Add(labelValidationHint);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Name = "ModesAndStepsForm";
            FormClosed += ModesAndStepsForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Button registerButton;
        private Label label1;
        private Label label2;
        private MaskedTextBox textBoxLogin;
        private MaskedTextBox textBoxPassword;
        private Label labelValidationHint;
    }
}