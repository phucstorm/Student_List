using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectData
{
    public partial class FormAdd : Form
    {
        StormEntities1 db = new StormEntities1();
        public FormAdd()
        {
            InitializeComponent();
        }
        private void FormAdd_Load(object sender, EventArgs e)
        {
            this.cbClass.DataSource = db.Classes.ToList();
            this.cbClass.ValueMember = "Id";
            this.cbClass.DisplayMember = "Name"; 
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            int Class_id = (int)this.cbClass.SelectedValue;
            string code = this.txtCode.Text;
            string name = this.txtName.Text;
            Student newStudent = new Student();
            newStudent.Code = code;
            newStudent.Fullname = name;
            newStudent.Class_id = Class_id;
            newStudent.Birthday = this.dtDob.Value;
            db.Students.Add(newStudent);
            db.SaveChanges();
            this.Close();
            MessageBox.Show("Add student successfull","Notification");
        }

    }
}
