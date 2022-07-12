namespace StudentExamRecordAndCalculaterSytem
{
    partial class StudentExamEntry
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblStudentSurnameCreateForTeacher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblStudentNameCreateForTeacher = new System.Windows.Forms.TextBox();
            this.LblStudentNumberEntryFromTeacher = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Exam1EntryFromTeacher = new System.Windows.Forms.TextBox();
            this.ExamsRegisterButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Exam3EntryFromTeacher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Exam2EntryFromTeacher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PassStudent = new System.Windows.Forms.Label();
            this.SuccessStudent = new System.Windows.Forms.Label();
            this.LblAvarage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentExam1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentExam2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentExam3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examAvarageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSet = new StudentExamRecordAndCalculaterSytem.DbNotKayitDataSet();
            this.lessonTableAdapter = new StudentExamRecordAndCalculaterSytem.DbNotKayitDataSetTableAdapters.LessonTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblStudentSurnameCreateForTeacher);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblStudentNameCreateForTeacher);
            this.groupBox1.Controls.Add(this.LblStudentNumberEntryFromTeacher);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(288, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Register";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Student Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname :";
            // 
            // LblStudentSurnameCreateForTeacher
            // 
            this.LblStudentSurnameCreateForTeacher.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStudentSurnameCreateForTeacher.Location = new System.Drawing.Point(144, 99);
            this.LblStudentSurnameCreateForTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.LblStudentSurnameCreateForTeacher.Name = "LblStudentSurnameCreateForTeacher";
            this.LblStudentSurnameCreateForTeacher.Size = new System.Drawing.Size(136, 26);
            this.LblStudentSurnameCreateForTeacher.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name :";
            // 
            // LblStudentNameCreateForTeacher
            // 
            this.LblStudentNameCreateForTeacher.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblStudentNameCreateForTeacher.Location = new System.Drawing.Point(144, 65);
            this.LblStudentNameCreateForTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.LblStudentNameCreateForTeacher.Name = "LblStudentNameCreateForTeacher";
            this.LblStudentNameCreateForTeacher.Size = new System.Drawing.Size(136, 26);
            this.LblStudentNameCreateForTeacher.TabIndex = 2;
            // 
            // LblStudentNumberEntryFromTeacher
            // 
            this.LblStudentNumberEntryFromTeacher.Location = new System.Drawing.Point(144, 29);
            this.LblStudentNumberEntryFromTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.LblStudentNumberEntryFromTeacher.Mask = "0000";
            this.LblStudentNumberEntryFromTeacher.Name = "LblStudentNumberEntryFromTeacher";
            this.LblStudentNumberEntryFromTeacher.Size = new System.Drawing.Size(94, 26);
            this.LblStudentNumberEntryFromTeacher.TabIndex = 1;
            this.LblStudentNumberEntryFromTeacher.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Number : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Exam1EntryFromTeacher);
            this.groupBox2.Controls.Add(this.ExamsRegisterButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Exam3EntryFromTeacher);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Exam2EntryFromTeacher);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 189);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(288, 168);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exam Points";
            // 
            // Exam1EntryFromTeacher
            // 
            this.Exam1EntryFromTeacher.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Exam1EntryFromTeacher.Location = new System.Drawing.Point(79, 38);
            this.Exam1EntryFromTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.Exam1EntryFromTeacher.Name = "Exam1EntryFromTeacher";
            this.Exam1EntryFromTeacher.Size = new System.Drawing.Size(136, 26);
            this.Exam1EntryFromTeacher.TabIndex = 7;
            // 
            // ExamsRegisterButton
            // 
            this.ExamsRegisterButton.Location = new System.Drawing.Point(79, 127);
            this.ExamsRegisterButton.Name = "ExamsRegisterButton";
            this.ExamsRegisterButton.Size = new System.Drawing.Size(136, 23);
            this.ExamsRegisterButton.TabIndex = 6;
            this.ExamsRegisterButton.Text = "Exam Register";
            this.ExamsRegisterButton.UseVisualStyleBackColor = true;
            this.ExamsRegisterButton.Click += new System.EventHandler(this.ExamsRegisterButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exam 3 :";
            // 
            // Exam3EntryFromTeacher
            // 
            this.Exam3EntryFromTeacher.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Exam3EntryFromTeacher.Location = new System.Drawing.Point(79, 94);
            this.Exam3EntryFromTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.Exam3EntryFromTeacher.Name = "Exam3EntryFromTeacher";
            this.Exam3EntryFromTeacher.Size = new System.Drawing.Size(136, 26);
            this.Exam3EntryFromTeacher.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Exam 2 :";
            // 
            // Exam2EntryFromTeacher
            // 
            this.Exam2EntryFromTeacher.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Exam2EntryFromTeacher.Location = new System.Drawing.Point(79, 65);
            this.Exam2EntryFromTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.Exam2EntryFromTeacher.Name = "Exam2EntryFromTeacher";
            this.Exam2EntryFromTeacher.Size = new System.Drawing.Size(136, 26);
            this.Exam2EntryFromTeacher.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Exam 1 :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PassStudent);
            this.groupBox3.Controls.Add(this.SuccessStudent);
            this.groupBox3.Controls.Add(this.LblAvarage);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(13, 377);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(288, 111);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generally Info For Class";
            // 
            // PassStudent
            // 
            this.PassStudent.AutoSize = true;
            this.PassStudent.Location = new System.Drawing.Point(147, 81);
            this.PassStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PassStudent.Name = "PassStudent";
            this.PassStudent.Size = new System.Drawing.Size(28, 18);
            this.PassStudent.TabIndex = 8;
            this.PassStudent.Text = "00";
            //this.PassStudent.Click += new System.EventHandler(this.PassStudent_Click);
            // 
            // SuccessStudent
            // 
            this.SuccessStudent.AutoSize = true;
            this.SuccessStudent.Location = new System.Drawing.Point(147, 54);
            this.SuccessStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SuccessStudent.Name = "SuccessStudent";
            this.SuccessStudent.Size = new System.Drawing.Size(28, 18);
            this.SuccessStudent.TabIndex = 7;
            this.SuccessStudent.Text = "00";
            //this.SuccessStudent.Click += new System.EventHandler(this.SuccessStudent_Click);
            // 
            // LblAvarage
            // 
            this.LblAvarage.AutoSize = true;
            this.LblAvarage.Location = new System.Drawing.Point(147, 27);
            this.LblAvarage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAvarage.Name = "LblAvarage";
            this.LblAvarage.Size = new System.Drawing.Size(28, 18);
            this.LblAvarage.TabIndex = 6;
            this.LblAvarage.Text = "00";
            //this.LblAvarage.Click += new System.EventHandler(this.LblAvarage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Pass Student :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Success Student :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Avarage :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(308, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(754, 475);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exam Point";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.studentNumberDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.studentExam1DataGridViewTextBoxColumn,
            this.studentExam2DataGridViewTextBoxColumn,
            this.studentExam3DataGridViewTextBoxColumn,
            this.examAvarageDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.lessonBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIdDataGridViewTextBoxColumn.Width = 105;
            // 
            // studentNumberDataGridViewTextBoxColumn
            // 
            this.studentNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.HeaderText = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.Name = "studentNumberDataGridViewTextBoxColumn";
            this.studentNumberDataGridViewTextBoxColumn.Width = 148;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 131;
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "StudentSurname";
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            this.studentSurnameDataGridViewTextBoxColumn.Width = 153;
            // 
            // studentExam1DataGridViewTextBoxColumn
            // 
            this.studentExam1DataGridViewTextBoxColumn.DataPropertyName = "StudentExam1";
            this.studentExam1DataGridViewTextBoxColumn.HeaderText = "StudentExam1";
            this.studentExam1DataGridViewTextBoxColumn.Name = "studentExam1DataGridViewTextBoxColumn";
            this.studentExam1DataGridViewTextBoxColumn.Width = 138;
            // 
            // studentExam2DataGridViewTextBoxColumn
            // 
            this.studentExam2DataGridViewTextBoxColumn.DataPropertyName = "StudentExam2";
            this.studentExam2DataGridViewTextBoxColumn.HeaderText = "StudentExam2";
            this.studentExam2DataGridViewTextBoxColumn.Name = "studentExam2DataGridViewTextBoxColumn";
            this.studentExam2DataGridViewTextBoxColumn.Width = 139;
            // 
            // studentExam3DataGridViewTextBoxColumn
            // 
            this.studentExam3DataGridViewTextBoxColumn.DataPropertyName = "StudentExam3";
            this.studentExam3DataGridViewTextBoxColumn.HeaderText = "StudentExam3";
            this.studentExam3DataGridViewTextBoxColumn.Name = "studentExam3DataGridViewTextBoxColumn";
            this.studentExam3DataGridViewTextBoxColumn.Width = 139;
            // 
            // examAvarageDataGridViewTextBoxColumn
            // 
            this.examAvarageDataGridViewTextBoxColumn.DataPropertyName = "ExamAvarage";
            this.examAvarageDataGridViewTextBoxColumn.HeaderText = "ExamAvarage";
            this.examAvarageDataGridViewTextBoxColumn.Name = "examAvarageDataGridViewTextBoxColumn";
            this.examAvarageDataGridViewTextBoxColumn.Width = 133;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.Width = 59;
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataMember = "Lesson";
            this.lessonBindingSource.DataSource = this.dbNotKayitDataSet;
            // 
            // dbNotKayitDataSet
            // 
            this.dbNotKayitDataSet.DataSetName = "DbNotKayitDataSet";
            this.dbNotKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lessonTableAdapter
            // 
            this.lessonTableAdapter.ClearBeforeFill = true;
            // 
            // StudentExamEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1074, 501);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentExamEntry";
            this.Text = "Student Exam Entry";
            this.Load += new System.EventHandler(this.StudentExamEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LblStudentSurnameCreateForTeacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LblStudentNameCreateForTeacher;
        private System.Windows.Forms.MaskedTextBox LblStudentNumberEntryFromTeacher;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Exam1EntryFromTeacher;
        private System.Windows.Forms.Button ExamsRegisterButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Exam3EntryFromTeacher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Exam2EntryFromTeacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label PassStudent;
        private System.Windows.Forms.Label SuccessStudent;
        private System.Windows.Forms.Label LblAvarage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbNotKayitDataSet dbNotKayitDataSet;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private DbNotKayitDataSetTableAdapters.LessonTableAdapter lessonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentExam1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentExam2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentExam3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examAvarageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}