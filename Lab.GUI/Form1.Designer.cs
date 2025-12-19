namespace Lab.GUI
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
            grbInformation = new GroupBox();
            cbFaculty = new ComboBox();
            txtAvg = new TextBox();
            lblAvg = new Label();
            lblFaculty = new Label();
            txtFullName = new TextBox();
            txtCode = new TextBox();
            lblFullName = new Label();
            lblCode = new Label();
            lblTitle = new Label();
            dgvData = new DataGridView();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            grbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // grbInformation
            // 
            grbInformation.Controls.Add(cbFaculty);
            grbInformation.Controls.Add(txtAvg);
            grbInformation.Controls.Add(lblAvg);
            grbInformation.Controls.Add(lblFaculty);
            grbInformation.Controls.Add(txtFullName);
            grbInformation.Controls.Add(txtCode);
            grbInformation.Controls.Add(lblFullName);
            grbInformation.Controls.Add(lblCode);
            grbInformation.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbInformation.ForeColor = Color.Blue;
            grbInformation.Location = new Point(62, 151);
            grbInformation.Name = "grbInformation";
            grbInformation.Size = new Size(515, 388);
            grbInformation.TabIndex = 5;
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
            // txtFullName
            // 
            txtFullName.Location = new Point(127, 134);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(382, 31);
            txtFullName.TabIndex = 1;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(127, 67);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(382, 31);
            txtCode.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(55, 137);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(66, 25);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Họ tên";
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
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(62, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1258, 139);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Quản lí thông tin Sinh Viên";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(609, 151);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(711, 477);
            dgvData.TabIndex = 10;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1226, 659);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 39);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(483, 557);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 39);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(357, 557);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 39);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(231, 557);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 39);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Thêm";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 707);
            Controls.Add(grbInformation);
            Controls.Add(lblTitle);
            Controls.Add(dgvData);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Name = "Form1";
            Text = "Form1";
            grbInformation.ResumeLayout(false);
            grbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbInformation;
        private ComboBox cbFaculty;
        private TextBox txtAvg;
        private Label lblAvg;
        private Label lblFaculty;
        private TextBox txtFullName;
        private TextBox txtCode;
        private Label lblFullName;
        private Label lblCode;
        private Label lblTitle;
        private DataGridView dgvData;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
    }
}
