namespace Day_7.GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            grpThongTinXetNghiem = new GroupBox();
            btnCapNhat = new Button();
            cboCongTy = new ComboBox();
            radDuongTinh = new RadioButton();
            radAmTinh = new RadioButton();
            txtSoLanXN = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtHoTen = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnTim = new Button();
            txtID = new TextBox();
            label2 = new Label();
            dgvNhanVien = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colSL = new DataGridViewTextBoxColumn();
            colKQ = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            chứcNăngToolStripMenuItem = new ToolStripMenuItem();
            danhSáchNVDươngTínhToolStripMenuItem = new ToolStripMenuItem();
            danhSáchCtyĐãTestTheoYCToolStripMenuItem = new ToolStripMenuItem();
            xuấtBáoCáoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            grpThongTinXetNghiem.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8776007F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.1224F));
            tableLayoutPanel1.Size = new Size(1390, 783);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvNhanVien, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 119);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1384, 661);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(grpThongTinXetNghiem, 0, 1);
            tableLayoutPanel4.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 24.242424F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 75.757576F));
            tableLayoutPanel4.Size = new Size(409, 655);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // grpThongTinXetNghiem
            // 
            grpThongTinXetNghiem.Controls.Add(btnCapNhat);
            grpThongTinXetNghiem.Controls.Add(cboCongTy);
            grpThongTinXetNghiem.Controls.Add(radDuongTinh);
            grpThongTinXetNghiem.Controls.Add(radAmTinh);
            grpThongTinXetNghiem.Controls.Add(txtSoLanXN);
            grpThongTinXetNghiem.Controls.Add(label6);
            grpThongTinXetNghiem.Controls.Add(label5);
            grpThongTinXetNghiem.Controls.Add(label4);
            grpThongTinXetNghiem.Controls.Add(txtHoTen);
            grpThongTinXetNghiem.Controls.Add(label3);
            grpThongTinXetNghiem.Dock = DockStyle.Top;
            grpThongTinXetNghiem.Enabled = false;
            grpThongTinXetNghiem.Location = new Point(20, 178);
            grpThongTinXetNghiem.Margin = new Padding(20);
            grpThongTinXetNghiem.Name = "grpThongTinXetNghiem";
            grpThongTinXetNghiem.Size = new Size(369, 454);
            grpThongTinXetNghiem.TabIndex = 2;
            grpThongTinXetNghiem.TabStop = false;
            grpThongTinXetNghiem.Text = "Thông tin xét nghiệm";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(95, 354);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(105, 29);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // cboCongTy
            // 
            cboCongTy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCongTy.FormattingEnabled = true;
            cboCongTy.Location = new Point(95, 270);
            cboCongTy.Name = "cboCongTy";
            cboCongTy.Size = new Size(236, 31);
            cboCongTy.TabIndex = 3;
            // 
            // radDuongTinh
            // 
            radDuongTinh.AutoSize = true;
            radDuongTinh.Location = new Point(95, 214);
            radDuongTinh.Name = "radDuongTinh";
            radDuongTinh.Size = new Size(121, 27);
            radDuongTinh.TabIndex = 2;
            radDuongTinh.Text = "Dương Tính";
            radDuongTinh.UseVisualStyleBackColor = true;
            // 
            // radAmTinh
            // 
            radAmTinh.AutoSize = true;
            radAmTinh.Checked = true;
            radAmTinh.Location = new Point(95, 167);
            radAmTinh.Name = "radAmTinh";
            radAmTinh.Size = new Size(95, 27);
            radAmTinh.TabIndex = 2;
            radAmTinh.TabStop = true;
            radAmTinh.Text = "Âm Tính";
            radAmTinh.UseVisualStyleBackColor = true;
            // 
            // txtSoLanXN
            // 
            txtSoLanXN.Location = new Point(95, 109);
            txtSoLanXN.Name = "txtSoLanXN";
            txtSoLanXN.ReadOnly = true;
            txtSoLanXN.Size = new Size(105, 30);
            txtSoLanXN.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 273);
            label6.Name = "label6";
            label6.Size = new Size(72, 23);
            label6.TabIndex = 0;
            label6.Text = "Công Ty";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 167);
            label5.Name = "label5";
            label5.Size = new Size(33, 23);
            label5.TabIndex = 0;
            label5.Text = "KQ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 112);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 0;
            label4.Text = "SLXN";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(95, 58);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(268, 30);
            txtHoTen.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 61);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 0;
            label3.Text = "Họ tên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTim);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(20, 20);
            groupBox1.Margin = new Padding(20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 118);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(316, 61);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(55, 29);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(134, 58);
            txtID.Name = "txtID";
            txtID.Size = new Size(176, 30);
            txtID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 61);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 0;
            label2.Text = "CCCD/CMND";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colSL, colKQ });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(418, 3);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(963, 655);
            dgvNhanVien.TabIndex = 1;
            dgvNhanVien.CellFormatting += dgvNhanVien_CellFormatting;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "CMND/CCCD";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colName
            // 
            colName.DataPropertyName = "HoTen";
            colName.HeaderText = "Họ và Tên";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            // 
            // colSL
            // 
            colSL.DataPropertyName = "SoLanXN";
            colSL.HeaderText = "Số Lần XN";
            colSL.MinimumWidth = 6;
            colSL.Name = "colSL";
            // 
            // colKQ
            // 
            colKQ.DataPropertyName = "AmTinh";
            colKQ.HeaderText = "Kết Quả";
            colKQ.MinimumWidth = 6;
            colKQ.Name = "colKQ";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.Size = new Size(1384, 110);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chứcNăngToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1384, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { danhSáchNVDươngTínhToolStripMenuItem, danhSáchCtyĐãTestTheoYCToolStripMenuItem, xuấtBáoCáoToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new Size(96, 24);
            chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // danhSáchNVDươngTínhToolStripMenuItem
            // 
            danhSáchNVDươngTínhToolStripMenuItem.Name = "danhSáchNVDươngTínhToolStripMenuItem";
            danhSáchNVDươngTínhToolStripMenuItem.ShortcutKeys = Keys.F1;
            danhSáchNVDươngTínhToolStripMenuItem.Size = new Size(323, 26);
            danhSáchNVDươngTínhToolStripMenuItem.Text = "Danh Sách NV Dương Tính";
            danhSáchNVDươngTínhToolStripMenuItem.Click += danhSáchNVDươngTínhToolStripMenuItem_Click;
            // 
            // danhSáchCtyĐãTestTheoYCToolStripMenuItem
            // 
            danhSáchCtyĐãTestTheoYCToolStripMenuItem.Name = "danhSáchCtyĐãTestTheoYCToolStripMenuItem";
            danhSáchCtyĐãTestTheoYCToolStripMenuItem.ShortcutKeys = Keys.F2;
            danhSáchCtyĐãTestTheoYCToolStripMenuItem.Size = new Size(323, 26);
            danhSáchCtyĐãTestTheoYCToolStripMenuItem.Text = "Danh Sách Cty đã Test theo Y/C";
            danhSáchCtyĐãTestTheoYCToolStripMenuItem.Click += danhSáchCtyĐãTestTheoYCToolStripMenuItem_Click;
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            xuấtBáoCáoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            xuấtBáoCáoToolStripMenuItem.Size = new Size(323, 26);
            xuấtBáoCáoToolStripMenuItem.Text = "Xuất Báo cáo";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(14, 24);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(3, 33);
            label1.Name = "label1";
            label1.Size = new Size(1378, 77);
            label1.TabIndex = 3;
            label1.Text = "THÔNG TIN XÉT NGHIỆM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 783);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ XÉT NGHIỆM";
            Load += frmMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            grpThongTinXetNghiem.ResumeLayout(false);
            grpThongTinXetNghiem.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chứcNăngToolStripMenuItem;
        private ToolStripMenuItem danhSáchNVDươngTínhToolStripMenuItem;
        private ToolStripMenuItem danhSáchCtyĐãTestTheoYCToolStripMenuItem;
        private ToolStripMenuItem xuấtBáoCáoToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox grpThongTinXetNghiem;
        private RadioButton radDuongTinh;
        private RadioButton radAmTinh;
        private TextBox txtSoLanXN;
        private Label label5;
        private Label label4;
        private TextBox txtHoTen;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnTim;
        private TextBox txtID;
        private Label label2;
        private Button btnCapNhat;
        private ComboBox cboCongTy;
        private Label label6;
        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSL;
        private DataGridViewTextBoxColumn colKQ;
    }
}