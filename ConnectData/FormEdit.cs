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
    public partial class FormEdit : Form
    {
        StormEntities1 db;
        Student std;
        public FormEdit(Student std)
        {
            InitializeComponent();
            this.std = std;
            db = new StormEntities1();
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            var db = new StormEntities1();
            var newStudent = db.Students.Find(this.std.Id);
            newStudent.Fullname = this.txtName.Text;
            newStudent.Code = this.txtCode.Text;
            newStudent.Class_id = (int)this.cbClass.SelectedValue;
            newStudent.Birthday = this.dtDob.Value;
            db.Entry(newStudent).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            this.Close();
            MessageBox.Show("Edit student successfully");
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            this.txtCode.Text = this.std.Code;
            this.txtName.Text = this.std.Fullname;
            this.dtDob.Value = this.std.Birthday;
            this.cbClass.Text = this.std.Code;
            this.cbClass.DataSource = db.Classes.ToList();
            this.cbClass.ValueMember = "Id";
            this.cbClass.DisplayMember = "Name";
            this.cbClass.SelectedValue = this.std.Class_id;
        }

    }
}
