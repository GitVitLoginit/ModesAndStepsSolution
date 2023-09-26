namespace ModesAndStepsSolution
{
    partial class AddStepsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ModeId = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // ModeId
            // 
            ModeId.AutoSize = true;
            ModeId.Location = new Point(30, 37);
            ModeId.Name = "ModeId";
            ModeId.Size = new Size(61, 20);
            ModeId.TabIndex = 0;
            ModeId.Text = "ModeId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 85);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Timer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 138);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Destination";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 197);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 3;
            label4.Text = "Speed";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 251);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 4;
            label5.Text = "Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 304);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 5;
            label6.Text = "Volume";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(202, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(202, 138);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(202, 197);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(202, 251);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(202, 304);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(30, 426);
            button1.Name = "button1";
            button1.Size = new Size(105, 31);
            button1.TabIndex = 12;
            button1.Text = "Add step";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddStepsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 488);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ModeId);
            Name = "AddStepsForm";
            Text = "AddStepsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ModeId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
    }
}