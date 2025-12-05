namespace Day_4
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            lblMSNV = new Label();
            txtMSNV = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            btnAccept = new Button();
            btnSkip = new Button();
            SuspendLayout();
            // 
            // lblMSNV
            // 
            lblMSNV.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMSNV.Location = new Point(99, 67);
            lblMSNV.Name = "lblMSNV";
            lblMSNV.Size = new Size(115, 37);
            lblMSNV.TabIndex = 0;
            lblMSNV.Text = "MSNV:";
            // 
            // txtMSNV
            // 
            txtMSNV.Location = new Point(193, 73);
            txtMSNV.Name = "txtMSNV";
            txtMSNV.Size = new Size(264, 27);
            txtMSNV.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(12, 114);
            lblName.Name = "lblName";
            lblName.Size = new Size(175, 37);
            lblName.TabIndex = 0;
            lblName.Text = "Tên Nhân Viên:";
            // 
            // txtName
            // 
            txtName.Location = new Point(193, 120);
            txtName.Name = "txtName";
            txtName.Size = new Size(264, 27);
            txtName.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(2, 160);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(175, 37);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "Lương Căn Bản:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(193, 166);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(264, 27);
            txtPrice.TabIndex = 3;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(193, 217);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(94, 29);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Đồng ý";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnSkip
            // 
            btnSkip.Location = new Point(363, 217);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(94, 29);
            btnSkip.TabIndex = 5;
            btnSkip.Text = "Bỏ qua";
            btnSkip.UseVisualStyleBackColor = true;
            btnSkip.Click += btnSkip_Click;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 269);
            Controls.Add(btnSkip);
            Controls.Add(btnAccept);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtMSNV);
            Controls.Add(lblMSNV);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Staff";
            Text = "Staff";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMSNV;
        private TextBox txtMSNV;
        private Label lblName;
        private TextBox txtName;
        private Label lblPrice;
        private TextBox txtPrice;
        private Button btnAccept;
        private Button btnSkip;
    }
}