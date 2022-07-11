namespace StudentExamRecordAndCalculaterSytem
{
    partial class StudentLogin
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
            this.LblStudentNumber = new System.Windows.Forms.Label();
            this.StudentNumberEntryText = new System.Windows.Forms.MaskedTextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblStudentNumber
            // 
            this.LblStudentNumber.AutoSize = true;
            this.LblStudentNumber.Location = new System.Drawing.Point(12, 61);
            this.LblStudentNumber.Name = "LblStudentNumber";
            this.LblStudentNumber.Size = new System.Drawing.Size(140, 18);
            this.LblStudentNumber.TabIndex = 0;
            this.LblStudentNumber.Text = "Student Number : ";
            this.LblStudentNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // StudentNumberEntryText
            // 
            this.StudentNumberEntryText.Location = new System.Drawing.Point(146, 58);
            this.StudentNumberEntryText.Mask = "0000";
            this.StudentNumberEntryText.Name = "StudentNumberEntryText";
            this.StudentNumberEntryText.Size = new System.Drawing.Size(100, 26);
            this.StudentNumberEntryText.TabIndex = 1;
            this.StudentNumberEntryText.ValidatingType = typeof(int);
//            this.StudentNumberEntryText.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.StudentNumberEntryText_MaskInputRejected);
            this.StudentNumberEntryText.TextChanged += new System.EventHandler(this.StudentNumberEntryText_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(146, 90);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(104, 27);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(311, 143);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.StudentNumberEntryText);
            this.Controls.Add(this.LblStudentNumber);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentLogin";
            this.Text = "Student Login";
            this.Load += new System.EventHandler(this.StudentLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblStudentNumber;
        private System.Windows.Forms.MaskedTextBox StudentNumberEntryText;
        private System.Windows.Forms.Button BtnLogin;
    }
}

