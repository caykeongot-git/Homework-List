using Hotel.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Day_7.BLL;
using DAy_7.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Day_7.GUI
{
    public partial class frmMain : Form
    {
        private readonly NhanVienService nvService = new NhanVienService();
        private readonly CongTyService ctService = new CongTyService();
        public frmMain()
        {
            InitializeComponent();
            GUIHelper.DecorateDataGridView(dgvNhanVien);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvNhanVien.AutoGenerateColumns = false;
            try
            {
                LoadDataToGrid(nvService.GetAll());
                LoadCombobox();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
            }
        }

        private void LoadDataToGrid(List<NhanVien> list)
        {
            dgvNhanVien.DataSource = list;
        }

        private void LoadCombobox()
        {
            cboCongTy.DataSource = ctService.GetAll();
            cboCongTy.DisplayMember = "TenCty";
            cboCongTy.ValueMember = "MaCty";
        }

        private void ResetForm()
        {
            grpThongTinXetNghiem.Enabled = false;
            txtID.Text = "";
            txtHoTen.Text = "";
            txtSoLanXN.Text = "";
            radAmTinh.Checked = true;
            if (cboCongTy.Items.Count > 0) cboCongTy.SelectedIndex = 0;
            txtID.Focus();
        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNhanVien.Columns[e.ColumnIndex].DataPropertyName == "AmTinh" && e.Value != null)
            {
                bool isAmTinh = (bool)e.Value;
                e.Value = isAmTinh ? "Âm Tính" : "+";
                e.FormattingApplied = true;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();

            if (id.Length != 9 && id.Length != 12) { MessageBox.Show("Vui lòng nhập CCCD hoặc CMND (9/12 số)"); return; }
            if (!long.TryParse(id, out _)) { MessageBox.Show("ID chỉ là các kí tự số"); return; }

            var nv = nvService.FindById(id);

            grpThongTinXetNghiem.Enabled = true;  

            if (nv == null)  
            {
                txtHoTen.Text = "";
                txtSoLanXN.Text = "1";  
                txtSoLanXN.ReadOnly = true;
                radAmTinh.Checked = true;  
                if (cboCongTy.Items.Count > 0) cboCongTy.SelectedIndex = 0;  
            }
            else  
            {
                txtHoTen.Text = nv.HoTen;  
                txtSoLanXN.Text = (nv.SoLanXN + 1).ToString();  
                txtSoLanXN.ReadOnly = true;

                if (nv.AmTinh) radAmTinh.Checked = true; else radDuongTinh.Checked = true;
                cboCongTy.SelectedValue = nv.MaCty;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text)) { MessageBox.Show("Chưa nhập họ tên!"); return; }

            NhanVien nv = new NhanVien
            {
                ID = txtID.Text.Trim(),
                HoTen = txtHoTen.Text,
                SoLanXN = int.Parse(txtSoLanXN.Text),
                AmTinh = radAmTinh.Checked,
                MaCty = cboCongTy.SelectedValue.ToString()
            };

            var checkExist = nvService.FindById(nv.ID);
            string msg = (checkExist == null) ? "Thêm mới thành công!" : "Cập nhật thành công!";

            nvService.AddOrUpdate(nv);

            MessageBox.Show(msg);

            LoadDataToGrid(nvService.GetAll());
            ResetForm();
        }

        private void danhSáchNVDươngTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataToGrid(nvService.GetDuongTinh());
        }

        private void danhSáchCtyĐãTestTheoYCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = ctService.GetCongTyDuYeuCau();
            string s = "Các Công Ty đã test đủ Y/C:\n";
            for (int i = 0; i < list.Count; i++)
            {
                s += $"{i + 1}. {list[i].TenCty}\n";
            }
            MessageBox.Show(s, "Thông Báo");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                danhSáchNVDươngTínhToolStripMenuItem_Click(null, null);
                return true;
            }
            if (keyData == Keys.F2)
            {
                danhSáchCtyĐãTestTheoYCToolStripMenuItem_Click(null, null);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
