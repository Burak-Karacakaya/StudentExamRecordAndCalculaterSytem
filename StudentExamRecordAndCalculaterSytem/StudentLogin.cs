using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExamRecordAndCalculaterSytem
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDetail studentDetail = new StudentDetail();
            studentDetail.number = StudentNumberEntryText.Text;
            studentDetail.Show();

        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }

        private void StudentNumberEntryText_TextChanged(object sender, EventArgs e)
        {
            if (StudentNumberEntryText.Text == "1111")
            {
                StudentExamEntry studentExamEntry = new StudentExamEntry();
                studentExamEntry.Show();
            }
        }
    }
}
