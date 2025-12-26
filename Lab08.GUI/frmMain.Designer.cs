namespace Lab08.GUI
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
            dgvStudent = new DataGridView();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnAdd = new Button();
            cmbMajor = new ComboBox();
            txtAge = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.584086F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.41592F));
            tableLayoutPanel1.Size = new Size(1249, 752);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel2.Controls.Add(dgvStudent, 1, 0);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 75);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1243, 674);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Dock = DockStyle.Fill;
            dgvStudent.Location = new Point(469, 3);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.Size = new Size(771, 668);
            dgvStudent.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnNext);
            groupBox1.Controls.Add(btnPrevious);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(cmbMajor);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(20, 20);
            groupBox1.Margin = new Padding(20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 634);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveBorder;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(302, 456);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 44);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveBorder;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(174, 456);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 44);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = SystemColors.ActiveBorder;
            btnNext.ForeColor = Color.Black;
            btnNext.Location = new Point(326, 584);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 44);
            btnNext.TabIndex = 3;
            btnNext.Text = ">>>";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = SystemColors.ActiveBorder;
            btnPrevious.ForeColor = Color.Black;
            btnPrevious.Location = new Point(14, 584);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 44);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "<<<";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveBorder;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(39, 456);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 44);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbMajor
            // 
            cmbMajor.FormattingEnabled = true;
            cmbMajor.Items.AddRange(new object[] { "CÔNG NGHỆ THÔNG TIN", "QUẢN TRỊ KINH DOANH", "NGÔNG NGỮ ANH" });
            cmbMajor.Location = new Point(114, 289);
            cmbMajor.Name = "cmbMajor";
            cmbMajor.Size = new Size(269, 33);
            cmbMajor.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(114, 183);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(86, 31);
            txtAge.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 292);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 0;
            label4.Text = "Ngành";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 186);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 0;
            label3.Text = "Tuổi";
            // 
            // txtName
            // 
            txtName.Location = new Point(114, 82);
            txtName.Name = "txtName";
            txtName.Size = new Size(269, 31);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 85);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1243, 72);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ SINH VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 752);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "NGUYEN DINH AN NINH";
            Load += frmMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvStudent;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnAdd;
        private ComboBox cmbMajor;
        private TextBox txtAge;
        private Label label4;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNext;
        private Button btnPrevious;
    }
}