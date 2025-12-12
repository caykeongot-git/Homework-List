using System.Linq;
using System.Windows.Forms;

namespace Day_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDB();
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.MultiSelect = false;
        }

        private void LoadDB()
        {

            using (var db = new StudentContext())
            {
                if (db.Students.Any()) return;

                Student stu1 = new Student()
                {
                    Id = "1611061916",
                    Name = "Nguyễn Trần Hoàng Loan",
                    Faculty = "Công Nghệ Thông Tin",
                    Average = 4.5
                };

                Student stu2 = new Student()
                {
                    Id = "1711060596",
                    Name = "Đàm Minh Đức",
                    Faculty = "Công Nghệ Thông Tin",
                    Average = 2.5
                };
                Student stu3 = new Student()
                {
                    Id = "1711061004",
                    Name = "Nguyễn Quốc An",
                    Faculty = "Ngôn Ngữ Anh",
                    Average = 10
                };

                db.AddRange(stu1, stu2, stu3);
                db.SaveChanges();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new StudentContext())
            {
                dgvData.DataSource = db.Students.ToList();
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = dgvData.SelectedRows[0];
                cbFaculty.Text = row.Cells[2].Value.ToString();
            } 
        }
    }
}
