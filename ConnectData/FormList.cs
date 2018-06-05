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
    public partial class FormList : Form
    {
        StormEntities db = new StormEntities();
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
            this.lstStudent.DataSource = db.Students.ToList();   
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
                var item = (Student)row.DataBoundItem;
                var edit = new FormEdit(item);
                edit.ShowDialog();
                loadStudent();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var db = new StormEntities();
            if(MessageBox.Show("Are u sure ?", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes){
                for (int i = 0; i < this.lstStudent.SelectedRows.Count; i++)
                {
                    var row = this.lstStudent.SelectedRows[i];
                    var item = (Student)row.DataBoundItem;
                    try
                    {
                        Student student = db.Students.Find(item.Id);
                        db.Students.Remove(student);
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot delete class " + item);
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
