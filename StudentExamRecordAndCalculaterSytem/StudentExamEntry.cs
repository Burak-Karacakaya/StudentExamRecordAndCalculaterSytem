using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentExamRecordAndCalculaterSytem
{
    public partial class StudentExamEntry : Form
    {
        public StudentExamEntry()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbNotKayit;Integrated Security=True");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudentExamEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.Lesson' table. You can move, or remove it, as needed.
            this.lessonTableAdapter.Fill(this.dbNotKayitDataSet.Lesson);

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into Lesson (StudentNumber, StudentName, StudentSurname) values (@p1,@p2, @p3)", connection);
            sqlCommand.Parameters.AddWithValue("@p1", LblStudentNumberEntryFromTeacher.Text);
            sqlCommand.Parameters.AddWithValue("@p2", LblStudentNameCreateForTeacher.Text);
            sqlCommand.Parameters.AddWithValue("@p3", LblStudentSurnameCreateForTeacher.Text);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Student Create to System.");
            this.lessonTableAdapter.Fill(this.dbNotKayitDataSet.Lesson);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int select = dataGridView1.SelectedCells[0].RowIndex;

            LblStudentNumberEntryFromTeacher.Text = dataGridView1.Rows[select].Cells[1].Value.ToString();
            LblStudentNameCreateForTeacher.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            LblStudentSurnameCreateForTeacher.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();


            Exam1EntryFromTeacher.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            Exam2EntryFromTeacher.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();
            Exam3EntryFromTeacher.Text = dataGridView1.Rows[select].Cells[6].Value.ToString();            

        }

        private void ExamsRegisterButton_Click(object sender, EventArgs e)
        {
            double avarage, e1, e2, e3;
            string status;
            e1 = Convert.ToDouble(Exam1EntryFromTeacher.Text);
            e2 = Convert.ToDouble(Exam2EntryFromTeacher.Text);
            e3 = Convert.ToDouble(Exam2EntryFromTeacher.Text);

            avarage = (e1 + e2 + e3) / 3;
            LblAvarage.Text = avarage.ToString();

            if (avarage >= 55)
            {
                status = "True";
            }
            else
            {
                status = "False";
            }
                

            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Lesson set StudentExam1=@p1, StudentExam2=@p2, StudentExam3=@p3, ExamAvarage=@p4, Status=@p5 where StudentNumber=@p6", connection);
            sqlCommand.Parameters.AddWithValue("@p1", Exam1EntryFromTeacher.Text);
            sqlCommand.Parameters.AddWithValue("@p2", Exam2EntryFromTeacher.Text);
            sqlCommand.Parameters.AddWithValue("@p3", Exam3EntryFromTeacher.Text);
            sqlCommand.Parameters.AddWithValue("@p4", decimal.Parse(LblAvarage.Text));
            sqlCommand.Parameters.AddWithValue("@p5", status);
            sqlCommand.Parameters.AddWithValue("@p6", LblStudentNumberEntryFromTeacher.Text);
            sqlCommand.ExecuteNonQuery();
            
            
            LblAvarage.Text = this.dbNotKayitDataSet.Lesson.Sum(y => y.ExamAvarage / dataGridView1.RowCount).ToString("00.00");
            SuccessStudent.Text = this.dbNotKayitDataSet.Lesson.Count(x => x.Status == true).ToString();
            PassStudent.Text = this.dbNotKayitDataSet.Lesson.Count(x => x.Status == false).ToString();
            connection.Close();
            MessageBox.Show("Student Exam point Updated.");
            this.lessonTableAdapter.Fill(this.dbNotKayitDataSet.Lesson);

        }            
            
        
    }
}
