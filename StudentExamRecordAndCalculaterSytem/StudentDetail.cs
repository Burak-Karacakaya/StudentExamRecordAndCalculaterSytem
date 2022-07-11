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
    public partial class StudentDetail : Form
    {
        public StudentDetail()
        {
            InitializeComponent();
        }

        public string number;
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbNotKayit;Integrated Security=True");
        
        private void StudentDetail_Load(object sender, EventArgs e)
        {
            LblNumberInfo.Text = number;
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Lesson where StudentNumber=@p1", connection);
            command.Parameters.AddWithValue("@p1", number);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                LblNameInfo.Text = sqlDataReader[2].ToString() + " " + sqlDataReader[3].ToString();
                LblExam1.Text = sqlDataReader[4].ToString();
                LblExam2.Text = sqlDataReader[5].ToString();
                LblExam3.Text = sqlDataReader[6].ToString();
                LblAvarage.Text = sqlDataReader[7].ToString();
                LblStatus.Text = sqlDataReader[8].ToString();

            }
            connection.Close();
        }
    }
}
