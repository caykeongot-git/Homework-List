using System.Security.Cryptography;

namespace Day_4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        List<NhanVien> nhanViens = new List<NhanVien>();
        BindingSource source = new BindingSource();

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();

            if (staff.ShowDialog() == DialogResult.OK)
            {
                grvData.Rows.Add(staff.MSNV, staff.Name, staff.Price);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grvData.SelectedRows.Count > 0)
            {
                DataGridViewRow row = grvData.SelectedRows[0];
                Staff stf = new Staff();

                stf.SetData (
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString()
                );
                if (stf.ShowDialog() == DialogResult.OK)
                {
                    row.Cells[1].Value = stf.Name;
                    row.Cells[2].Value = stf.Price;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grvData.SelectedRows.Count > 0)
            {
                DialogResult check = MessageBox.Show("Muốn xóa à ?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    grvData.Rows.Remove(grvData.SelectedRows[0]);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muốn thoát à ?, Bye bye", "SEE YA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
