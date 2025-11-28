namespace Day_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            grpInformation = new GroupBox();
            btnAddName = new Button();
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            lvInformation = new ListView();
            clmLastName = new ColumnHeader();
            clmFirstName = new ColumnHeader();
            clmPhone = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            fileOpen = new ToolStripMenuItem();
            menuView = new ToolStripMenuItem();
            viewDetails = new ToolStripMenuItem();
            menuFormatListView = new ToolStripMenuItem();
            formatGridLines = new ToolStripMenuItem();
            formatSort = new ToolStripMenuItem();
            sortLastName = new ToolStripMenuItem();
            firstNameToolStripMenuItem = new ToolStripMenuItem();
            grpInformation.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grpInformation
            // 
            grpInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grpInformation.Controls.Add(btnAddName);
            grpInformation.Controls.Add(txtPhone);
            grpInformation.Controls.Add(lblPhone);
            grpInformation.Controls.Add(txtFirstName);
            grpInformation.Controls.Add(lblFirstName);
            grpInformation.Controls.Add(txtLastName);
            grpInformation.Controls.Add(lblLastName);
            grpInformation.Location = new Point(482, 74);
            grpInformation.Name = "grpInformation";
            grpInformation.Size = new Size(287, 364);
            grpInformation.TabIndex = 0;
            grpInformation.TabStop = false;
            // 
            // btnAddName
            // 
            btnAddName.Location = new Point(157, 329);
            btnAddName.Name = "btnAddName";
            btnAddName.Size = new Size(124, 29);
            btnAddName.TabIndex = 6;
            btnAddName.Text = "Add Name";
            btnAddName.UseVisualStyleBackColor = true;
            btnAddName.Click += btnAddName_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(31, 279);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 27);
            txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(31, 232);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(71, 28);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(31, 178);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 27);
            txtFirstName.TabIndex = 3;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(31, 134);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(115, 28);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(31, 74);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 27);
            txtLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(31, 34);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(112, 28);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name";
            // 
            // lvInformation
            // 
            lvInformation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lvInformation.Columns.AddRange(new ColumnHeader[] { clmLastName, clmFirstName, clmPhone });
            lvInformation.FullRowSelect = true;
            lvInformation.GridLines = true;
            lvInformation.Location = new Point(12, 74);
            lvInformation.Name = "lvInformation";
            lvInformation.Size = new Size(446, 364);
            lvInformation.TabIndex = 1;
            lvInformation.UseCompatibleStateImageBehavior = false;
            lvInformation.View = View.Details;
            lvInformation.Click += lvInformation_Click;
            // 
            // clmLastName
            // 
            clmLastName.Text = "Last Name";
            // 
            // clmFirstName
            // 
            clmFirstName.Text = "First Name";
            // 
            // clmPhone
            // 
            clmPhone.Text = "Phone";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuView, menuFormatListView });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { fileOpen });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(46, 24);
            menuFile.Text = "File";
            // 
            // fileOpen
            // 
            fileOpen.Name = "fileOpen";
            fileOpen.Size = new Size(155, 26);
            fileOpen.Text = "Open File";
            fileOpen.Click += fileOpen_Click;
            // 
            // menuView
            // 
            menuView.DropDownItems.AddRange(new ToolStripItem[] { viewDetails });
            menuView.Name = "menuView";
            menuView.Size = new Size(55, 24);
            menuView.Text = "View";
            // 
            // viewDetails
            // 
            viewDetails.Name = "viewDetails";
            viewDetails.Size = new Size(138, 26);
            viewDetails.Text = "Details";
            viewDetails.Click += viewDetails_Click;
            // 
            // menuFormatListView
            // 
            menuFormatListView.DropDownItems.AddRange(new ToolStripItem[] { formatGridLines, formatSort });
            menuFormatListView.Name = "menuFormatListView";
            menuFormatListView.Size = new Size(128, 24);
            menuFormatListView.Text = "Format ListView";
            // 
            // formatGridLines
            // 
            formatGridLines.Name = "formatGridLines";
            formatGridLines.Size = new Size(157, 26);
            formatGridLines.Text = "Grid Lines";
            formatGridLines.Click += formatGridLines_Click;
            // 
            // formatSort
            // 
            formatSort.DropDownItems.AddRange(new ToolStripItem[] { sortLastName, firstNameToolStripMenuItem });
            formatSort.Name = "formatSort";
            formatSort.Size = new Size(157, 26);
            formatSort.Text = "Sort";
            // 
            // sortLastName
            // 
            sortLastName.Name = "sortLastName";
            sortLastName.Size = new Size(163, 26);
            sortLastName.Text = "Last Name";
            sortLastName.Click += sortLastName_Click;
            // 
            // firstNameToolStripMenuItem
            // 
            firstNameToolStripMenuItem.Name = "firstNameToolStripMenuItem";
            firstNameToolStripMenuItem.Size = new Size(163, 26);
            firstNameToolStripMenuItem.Text = "First Name";
            firstNameToolStripMenuItem.Click += firstNameToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(lvInformation);
            Controls.Add(grpInformation);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "ListView Demo";
            grpInformation.ResumeLayout(false);
            grpInformation.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpInformation;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private Button btnAddName;
        private ListView lvInformation;
        private ColumnHeader clmLastName;
        private ColumnHeader clmFirstName;
        private ColumnHeader clmPhone;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem fileOpen;
        private ToolStripMenuItem menuView;
        private ToolStripMenuItem menuFormatListView;
        private ToolStripMenuItem viewDetails;
        private ToolStripMenuItem formatGridLines;
        private ToolStripMenuItem formatSort;
        private ToolStripMenuItem sortLastName;
        private ToolStripMenuItem firstNameToolStripMenuItem;
    }
}
