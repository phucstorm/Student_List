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
    public partial class StudentView
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Fullname { get; set; }
        public System.DateTime Birthday { get; set; }
        public int Class_id { get; set; }

        public virtual Class Class { get; set; }
        public string ClassName
        {
            get
            {
                if (this.Class != null)
                    return this.Class.Name;
                else
                    return null;
            }
        }
    }

    public partial class FormList : Form
    {
        StormEntities1 db = new StormEntities1();
        public FormList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadStudent();
        }
        private void loadStudent()
        {
            this.lstStudent.DataSource = db.Students.Select(s => new StudentView
            {
                Id = s.Id,
                Code = s.Code,
                Fullname = s.Fullname,
                Birthday = s.Birthday,
                Class = s.Class
            }).ToList();
            this.lstStudent.Columns["Id"].Visible = false;
            this.lstStudent.Columns["Class"].Visible = false;
            this.lstStudent.Columns["Class_id"].Visible = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAdd add = new FormAdd();
            add.ShowDialog();
            loadStudent();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if(this.lstStudent.SelectedRows.Count == 1){
                var row = this.lstStudent.SelectedRows[0];
                var item = (StudentView)row.DataBoundItem;
                var edit = new FormEdit(new Student
                {
                    Id = item.Id,
                    Code = item.Code,
                    Fullname = item.Fullname,
                    Birthday = item.Birthday,
                    Class = item.Class
                });
                edit.ShowDialog();
                loadStudent();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var db = new StormEntities1();
            if(MessageBox.Show("Are u sure ?", "Warning!!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes){
                for (int i = 0; i < this.lstStudent.SelectedRows.Count; i++)
                {
                    var row = this.lstStudent.SelectedRows[i];
                    var item = (StudentView)row.DataBoundItem;
                    try
                    {
                        Student student = db.Students.Find(item.Id);
                        db.Students.Remove(student);
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot delete student " + item);
                    }
                    
                }
            }
            loadStudent();
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            loadStudent();
        }
    }
}
