using Hotel.GUI;
using Lab08.DAL;
using Lab08.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08.GUI
{
    public partial class frmMain : Form
    {
        SchoolContext db = new SchoolContext();

        BindingSource bindingSource = new BindingSource();

        public frmMain()
        {
            InitializeComponent();
            GUIHelper.DecorateDataGridView(dgvStudent);
        }



        private void LoadData()
        {
            var list = db.Students.ToList();
            bindingSource.DataSource = list;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            db.Database.EnsureCreated();

            LoadData();

            txtName.DataBindings.Add("Text", bindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAge.DataBindings.Add("Text", bindingSource, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbMajor.DataBindings.Add("Text", bindingSource, "Major", true, DataSourceUpdateMode.OnPropertyChanged);

            dgvStudent.DataSource = bindingSource;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.FullName = txtName.Text;
            s.Age = int.Parse(txtAge.Text);
            s.Major = cmbMajor.Text;

            db.Students.Add(s);
            db.SaveChanges();

            LoadData();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student currentStudent = bindingSource.Current as Student;

            if (currentStudent != null)
            {
                var s = db.Students.Find(currentStudent.StudentId);
                s.FullName = txtName.Text;
                s.Age = int.Parse(txtAge.Text);
                s.Major = cmbMajor.Text;

                db.SaveChanges();
                LoadData();
                MessageBox.Show("Sửa thành công!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student currentStudent = bindingSource.Current as Student;
            if (currentStudent != null)
            {
                var s = db.Students.Find(currentStudent.StudentId);
                db.Students.Remove(s);
                db.SaveChanges();

                bindingSource.RemoveCurrent();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
        }
    }
}
