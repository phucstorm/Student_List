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
        StormEntities db = new StormEntities();
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
            // gán trường dữ liệu trên design
            int Class_id = (int)this.cbClass.SelectedValue;
            string code = this.txtCode.Text;
            string name = this.txtName.Text;

            // khai báo SQL và gán dữ liệu trên design vào các cột trên bảng std của data
            Student newStudent = new Student();
            newStudent.Code = code;
            newStudent.Fullname = name;
            newStudent.Class_id = Class_id;
            newStudent.Birthday = this.dtDob.Value; // .value lấy giá trị ngày tháng năm của datatimepicker trên design
            
            // lưu dữ liệu đã nhập vào bảng std
            db.Students.Add(newStudent);
            db.SaveChanges();
            this.Close();
            // show tin nhắn thông báo fuck u
            MessageBox.Show("Thêm cmn thành công");
        }

    }
}
