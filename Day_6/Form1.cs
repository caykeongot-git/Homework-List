using System.ComponentModel.Design.Serialization;
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
                dgvData.DataSource = db.Students.ToList();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDB();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvData.SelectedRows[0];
                txtCode.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                cbFaculty.Text = row.Cells[2].Value.ToString();
                txtAvg.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new StudentContext())
                {
                    if (db.Students.Find(txtCode.Text) != null)
                    {
                        MessageBox.Show("Sinh viên này có thông tin rồi, nhập lại đê!", "CẢNH BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Student stu = new Student()
                    {
                        Id = txtCode.Text,
                        Name = txtName.Text,
                        Faculty = cbFaculty.Text,
                        Average = double.Parse(txtAvg.Text)
                    };
                    db.Students.Add(stu);
                    db.SaveChanges();
                    MessageBox.Show("Thêm sinh viên thành công", "NGON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDB();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new StudentContext())
            {
                var stu = db.Students.Find(txtCode.Text);

                if (stu != null)
                {
                    stu.Name = txtName.Text;
                    stu.Faculty = cbFaculty.Text;
                    stu.Average = double.Parse(txtAvg.Text);
                    db.SaveChanges();
                    MessageBox.Show("Sửa sinh viên thành công", "NGON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDB();

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Muốn xóa dòng này thật à ?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                using (var db = new StudentContext())
                {
                    var book = db.Students.Find(txtCode.Text);

                    if (book != null)
                    {
                        db.Students.Remove(book);
                        db.SaveChanges();
                        MessageBox.Show("Đã xóa sổ!");
                        LoadDB();
                        txtName.Text = "";
                        txtCode.Text = "";
                        txtAvg.Text = "";
                        cbFaculty.Text = "Công Nghệ Thông Tin";
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
