namespace Day_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            grbInformation = new GroupBox();
            cbFaculty = new ComboBox();
            txtAvg = new TextBox();
            lblAvg = new Label();
            lblFaculty = new Label();
            txtName = new TextBox();
            lblName = new Label();
            txtCode = new TextBox();
            lblCode = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            dgvData = new DataGridView();
            grbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1258, 139);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lí thông tin Sinh Viên";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbInformation
            // 
            grbInformation.Controls.Add(cbFaculty);
            grbInformation.Controls.Add(txtAvg);
            grbInformation.Controls.Add(lblAvg);
            grbInformation.Controls.Add(lblFaculty);
            grbInformation.Controls.Add(txtName);
            grbInformation.Controls.Add(lblName);
            grbInformation.Controls.Add(txtCode);
            grbInformation.Controls.Add(lblCode);
            grbInformation.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbInformation.ForeColor = Color.Blue;
            grbInformation.Location = new Point(12, 151);
            grbInformation.Name = "grbInformation";
            grbInformation.Size = new Size(515, 388);
            grbInformation.TabIndex = 1;
            grbInformation.TabStop = false;
            grbInformation.Text = "Thông tinh sinh viên";
            // 
            // cbFaculty
            // 
            cbFaculty.FormattingEnabled = true;
            cbFaculty.Items.AddRange(new object[] { "Công Nghệ Thông Tinh", "Ngôn Ngữ Anh" });
            cbFaculty.Location = new Point(127, 196);
            cbFaculty.Name = "cbFaculty";
            cbFaculty.Size = new Size(382, 33);
            cbFaculty.TabIndex = 2;
            cbFaculty.Text = "Công Nghệ Thông Tin";
            // 
            // txtAvg
            // 
            txtAvg.Location = new Point(127, 252);
            txtAvg.Name = "txtAvg";
            txtAvg.Size = new Size(112, 31);
            txtAvg.TabIndex = 1;
            // 
            // lblAvg
            // 
            lblAvg.AutoSize = true;
            lblAvg.Location = new Point(43, 252);
            lblAvg.Name = "lblAvg";
            lblAvg.Size = new Size(78, 25);
            lblAvg.TabIndex = 0;
            lblAvg.Text = "Điểm TB";
            // 
            // lblFaculty
            // 
            lblFaculty.AutoSize = true;
            lblFaculty.Location = new Point(69, 196);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(52, 25);
            lblFaculty.TabIndex = 0;
            lblFaculty.Text = "Khoa";
            // 
            // txtName
            // 
            txtName.Location = new Point(127, 134);
            txtName.Name = "txtName";
            txtName.Size = new Size(382, 31);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Location = new Point(55, 134);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Họ tên";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(127, 67);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(382, 31);
            txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(34, 67);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(87, 25);
            lblCode.TabIndex = 0;
            lblCode.Text = "Mã số SV";
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(181, 557);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 39);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Thêm";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(307, 557);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 39);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(433, 557);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 39);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1176, 659);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 39);
            btnExit.TabIndex = 2;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(559, 151);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(711, 477);
            dgvData.TabIndex = 3;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 710);
            Controls.Add(dgvData);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(grbInformation);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Quản lý thông tin Sinh Viên";
            Load += Form1_Load;
            grbInformation.ResumeLayout(false);
            grbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private GroupBox grbInformation;
        private Label lblCode;
        private ComboBox cbFaculty;
        private TextBox txtAvg;
        private Label lblAvg;
        private Label lblFaculty;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtCode;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private DataGridView dgvData;
    }
}
