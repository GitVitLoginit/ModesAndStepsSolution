namespace ModesAndStepsSolution
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            labelForLoginShow = new Label();
            dataGridForModes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            MaxBottleNumber = new DataGridViewTextBoxColumn();
            MaxUsedTips = new DataGridViewTextBoxColumn();
            modeBindingSource1 = new BindingSource(components);
            modeBindingSource = new BindingSource(components);
            dataGridForSteps = new DataGridView();
            StepId = new DataGridViewTextBoxColumn();
            ModeId = new DataGridViewTextBoxColumn();
            Timer = new DataGridViewTextBoxColumn();
            Destination = new DataGridViewTextBoxColumn();
            Speed = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Volume = new DataGridViewTextBoxColumn();
            stepBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            DeleteSelectedModes = new Button();
            DeleteSelectedSteps = new Button();
            AddMode = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridForModes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridForSteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stepBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "You login:";
            label1.Click += label1_Click;
            // 
            // labelForLoginShow
            // 
            labelForLoginShow.AutoSize = true;
            labelForLoginShow.Location = new Point(92, 9);
            labelForLoginShow.Name = "labelForLoginShow";
            labelForLoginShow.Size = new Size(0, 20);
            labelForLoginShow.TabIndex = 1;
            // 
            // dataGridForModes
            // 
            dataGridForModes.AutoGenerateColumns = false;
            dataGridForModes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridForModes.Columns.AddRange(new DataGridViewColumn[] { Id, Name, MaxBottleNumber, MaxUsedTips });
            dataGridForModes.DataSource = modeBindingSource1;
            dataGridForModes.Location = new Point(12, 50);
            dataGridForModes.Name = "dataGridForModes";
            dataGridForModes.RowHeadersWidth = 51;
            dataGridForModes.RowTemplate.Height = 29;
            dataGridForModes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridForModes.Size = new Size(552, 533);
            dataGridForModes.TabIndex = 2;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // MaxBottleNumber
            // 
            MaxBottleNumber.DataPropertyName = "MaxBottleNumber";
            MaxBottleNumber.HeaderText = "MaxBottleNumber";
            MaxBottleNumber.MinimumWidth = 6;
            MaxBottleNumber.Name = "MaxBottleNumber";
            MaxBottleNumber.Width = 125;
            // 
            // MaxUsedTips
            // 
            MaxUsedTips.DataPropertyName = "MaxUsedTips";
            MaxUsedTips.HeaderText = "MaxUsedTips";
            MaxUsedTips.MinimumWidth = 6;
            MaxUsedTips.Name = "MaxUsedTips";
            MaxUsedTips.Width = 125;
            // 
            // modeBindingSource1
            // 
            modeBindingSource1.DataSource = typeof(Models.Mode);
            // 
            // modeBindingSource
            // 
            modeBindingSource.DataSource = typeof(Models.Mode);
            // 
            // dataGridForSteps
            // 
            dataGridForSteps.AutoGenerateColumns = false;
            dataGridForSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridForSteps.Columns.AddRange(new DataGridViewColumn[] { StepId, ModeId, Timer, Destination, Speed, Type, Volume });
            dataGridForSteps.DataSource = stepBindingSource;
            dataGridForSteps.Location = new Point(608, 50);
            dataGridForSteps.Name = "dataGridForSteps";
            dataGridForSteps.RowHeadersWidth = 51;
            dataGridForSteps.RowTemplate.Height = 29;
            dataGridForSteps.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridForSteps.Size = new Size(713, 533);
            dataGridForSteps.TabIndex = 3;
            // 
            // StepId
            // 
            StepId.DataPropertyName = "Id";
            StepId.HeaderText = "Id";
            StepId.MinimumWidth = 6;
            StepId.Name = "StepId";
            StepId.Width = 125;
            // 
            // ModeId
            // 
            ModeId.DataPropertyName = "ModeId";
            ModeId.HeaderText = "ModeId";
            ModeId.MinimumWidth = 6;
            ModeId.Name = "ModeId";
            ModeId.Width = 125;
            // 
            // Timer
            // 
            Timer.DataPropertyName = "Timer";
            Timer.HeaderText = "Timer";
            Timer.MinimumWidth = 6;
            Timer.Name = "Timer";
            Timer.Width = 125;
            // 
            // Destination
            // 
            Destination.DataPropertyName = "Destination";
            Destination.HeaderText = "Destination";
            Destination.MinimumWidth = 6;
            Destination.Name = "Destination";
            Destination.Width = 125;
            // 
            // Speed
            // 
            Speed.DataPropertyName = "Speed";
            Speed.HeaderText = "Speed";
            Speed.MinimumWidth = 6;
            Speed.Name = "Speed";
            Speed.Width = 125;
            // 
            // Type
            // 
            Type.DataPropertyName = "Type";
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 125;
            // 
            // Volume
            // 
            Volume.DataPropertyName = "Volume";
            Volume.HeaderText = "Volume";
            Volume.MinimumWidth = 6;
            Volume.Name = "Volume";
            Volume.Width = 125;
            // 
            // stepBindingSource
            // 
            stepBindingSource.DataSource = typeof(Models.Step);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(238, 17);
            label2.Name = "label2";
            label2.Size = new Size(80, 30);
            label2.TabIndex = 4;
            label2.Text = "Modes";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(939, 17);
            label3.Name = "label3";
            label3.Size = new Size(65, 30);
            label3.TabIndex = 5;
            label3.Text = "Steps";
            // 
            // DeleteSelectedModes
            // 
            DeleteSelectedModes.Location = new Point(12, 607);
            DeleteSelectedModes.Name = "DeleteSelectedModes";
            DeleteSelectedModes.Size = new Size(134, 48);
            DeleteSelectedModes.TabIndex = 6;
            DeleteSelectedModes.Text = "Delete selected mode";
            DeleteSelectedModes.UseVisualStyleBackColor = true;
            DeleteSelectedModes.Click += DeleteSelectedModes_Click;
            // 
            // DeleteSelectedSteps
            // 
            DeleteSelectedSteps.Location = new Point(617, 607);
            DeleteSelectedSteps.Name = "DeleteSelectedSteps";
            DeleteSelectedSteps.Size = new Size(134, 48);
            DeleteSelectedSteps.TabIndex = 7;
            DeleteSelectedSteps.Text = "Delete selected step";
            DeleteSelectedSteps.UseVisualStyleBackColor = true;
            DeleteSelectedSteps.Click += DeleteSelectedSteps_Click;
            // 
            // AddMode
            // 
            AddMode.Location = new Point(171, 607);
            AddMode.Name = "AddMode";
            AddMode.Size = new Size(134, 48);
            AddMode.TabIndex = 8;
            AddMode.Text = "Add mode";
            AddMode.UseVisualStyleBackColor = true;
            AddMode.Click += AddMode_Click;
            // 
            // button1
            // 
            button1.Location = new Point(794, 607);
            button1.Name = "button1";
            button1.Size = new Size(134, 48);
            button1.TabIndex = 9;
            button1.Text = "Add step";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1136, 611);
            button2.Name = "button2";
            button2.Size = new Size(173, 40);
            button2.TabIndex = 10;
            button2.Text = "Save all changes to db";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 658);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(AddMode);
            Controls.Add(DeleteSelectedSteps);
            Controls.Add(DeleteSelectedModes);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridForSteps);
            Controls.Add(dataGridForModes);
            Controls.Add(labelForLoginShow);
            Controls.Add(label1);
        
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridForModes).EndInit();
            ((System.ComponentModel.ISupportInitialize)modeBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)modeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridForSteps).EndInit();
            ((System.ComponentModel.ISupportInitialize)stepBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelForLoginShow;
        private DataGridView dataGridForModes;
        private BindingSource modeBindingSource1;
        private BindingSource modeBindingSource;
        private DataGridView dataGridForSteps;
        private BindingSource stepBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn MaxBottleNumber;
        private DataGridViewTextBoxColumn MaxUsedTips;
        private DataGridViewTextBoxColumn StepId;
        private DataGridViewTextBoxColumn ModeId;
        private DataGridViewTextBoxColumn Timer;
        private DataGridViewTextBoxColumn Destination;
        private DataGridViewTextBoxColumn Speed;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Volume;
        private Label label2;
        private Label label3;
        private Button DeleteSelectedModes;
        private Button DeleteSelectedSteps;
        private Button AddMode;
        private Button button1;
        private Button button2;
    }
}