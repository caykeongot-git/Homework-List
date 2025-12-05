namespace Day_4
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            grvData = new DataGridView();
            clmMSNV = new DataGridViewTextBoxColumn();
            clmName = new DataGridViewTextBoxColumn();
            clmPrice = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)grvData).BeginInit();
            SuspendLayout();
            // 
            // grvData
            // 
            grvData.AllowUserToAddRows = false;
            grvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grvData.Columns.AddRange(new DataGridViewColumn[] { clmMSNV, clmName, clmPrice });
            grvData.Location = new Point(12, 12);
            grvData.Name = "grvData";
            grvData.ReadOnly = true;
            grvData.RowHeadersWidth = 51;
            grvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grvData.Size = new Size(620, 426);
            grvData.TabIndex = 0;
            // 
            // clmMSNV
            // 
            clmMSNV.HeaderText = "MSNV";
            clmMSNV.MinimumWidth = 6;
            clmMSNV.Name = "clmMSNV";
            clmMSNV.ReadOnly = true;
            clmMSNV.Width = 125;
            // 
            // clmName
            // 
            clmName.HeaderText = "Tên NV";
            clmName.MinimumWidth = 6;
            clmName.Name = "clmName";
            clmName.ReadOnly = true;
            clmName.Width = 125;
            // 
            // clmPrice
            // 
            clmPrice.HeaderText = "Lương CB";
            clmPrice.MinimumWidth = 6;
            clmPrice.Name = "clmPrice";
            clmPrice.ReadOnly = true;
            clmPrice.Width = 125;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(658, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 45);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(658, 85);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 45);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(658, 146);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 45);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(658, 211);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(130, 45);
            btnExit.TabIndex = 4;
            btnExit.Text = "Đóng";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(grvData);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "MEW MEW APP";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)grvData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grvData;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private DataGridViewTextBoxColumn clmMSNV;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmPrice;
    }
}
