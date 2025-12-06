namespace Day_5
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
            menuTop = new MenuStrip();
            menuSystem = new ToolStripMenuItem();
            systemNewPage = new ToolStripMenuItem();
            systemOpenfile = new ToolStripMenuItem();
            systemSave = new ToolStripMenuItem();
            systemExit = new ToolStripMenuItem();
            menuFormat = new ToolStripMenuItem();
            formatFont = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnNewPage = new ToolStripButton();
            btnSave = new ToolStripButton();
            cmbFonts = new ToolStripComboBox();
            cmbSizes = new ToolStripComboBox();
            btnBold = new ToolStripButton();
            btnItalic = new ToolStripButton();
            btnUnderLine = new ToolStripButton();
            richText = new RichTextBox();
            menuTop.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuTop
            // 
            menuTop.ImageScalingSize = new Size(20, 20);
            menuTop.Items.AddRange(new ToolStripItem[] { menuSystem, menuFormat });
            menuTop.Location = new Point(0, 0);
            menuTop.Name = "menuTop";
            menuTop.Size = new Size(800, 28);
            menuTop.TabIndex = 0;
            menuTop.Text = "Menu";
            // 
            // menuSystem
            // 
            menuSystem.DropDownItems.AddRange(new ToolStripItem[] { systemNewPage, systemOpenfile, systemSave, systemExit });
            menuSystem.Name = "menuSystem";
            menuSystem.Size = new Size(88, 24);
            menuSystem.Text = "Hệ Thống";
            // 
            // systemNewPage
            // 
            systemNewPage.Name = "systemNewPage";
            systemNewPage.ShortcutKeys = Keys.Control | Keys.N;
            systemNewPage.Size = new Size(285, 26);
            systemNewPage.Text = "Tạo văn bản mới";
            systemNewPage.Click += systemNewPage_Click;
            // 
            // systemOpenfile
            // 
            systemOpenfile.Name = "systemOpenfile";
            systemOpenfile.ShortcutKeys = Keys.Control | Keys.O;
            systemOpenfile.Size = new Size(285, 26);
            systemOpenfile.Text = " Mở tập tin";
            systemOpenfile.Click += systemOpenfile_Click;
            // 
            // systemSave
            // 
            systemSave.Name = "systemSave";
            systemSave.ShortcutKeys = Keys.Control | Keys.S;
            systemSave.Size = new Size(285, 26);
            systemSave.Text = "Lưu nội dung văn bản";
            systemSave.Click += systemSave_Click;
            // 
            // systemExit
            // 
            systemExit.Name = "systemExit";
            systemExit.Size = new Size(285, 26);
            systemExit.Text = "Thoát";
            systemExit.Click += systemExit_Click;
            // 
            // menuFormat
            // 
            menuFormat.DropDownItems.AddRange(new ToolStripItem[] { formatFont });
            menuFormat.Name = "menuFormat";
            menuFormat.Size = new Size(92, 24);
            menuFormat.Text = "Định dạng";
            // 
            // formatFont
            // 
            formatFont.Name = "formatFont";
            formatFont.Size = new Size(121, 26);
            formatFont.Text = "Font";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNewPage, btnSave, cmbFonts, cmbSizes, btnBold, btnItalic, btnUnderLine });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNewPage
            // 
            btnNewPage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNewPage.Image = (Image)resources.GetObject("btnNewPage.Image");
            btnNewPage.ImageTransparentColor = Color.Magenta;
            btnNewPage.Name = "btnNewPage";
            btnNewPage.Size = new Size(29, 25);
            btnNewPage.Text = "Page";
            btnNewPage.Click += btnNewPage_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(29, 25);
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // cmbFonts
            // 
            cmbFonts.Name = "cmbFonts";
            cmbFonts.Size = new Size(121, 28);
            cmbFonts.SelectedIndexChanged += cmbFonts_SelectedIndexChanged;
            // 
            // cmbSizes
            // 
            cmbSizes.Name = "cmbSizes";
            cmbSizes.Size = new Size(121, 28);
            cmbSizes.SelectedIndexChanged += cmbSizes_SelectedIndexChanged;
            // 
            // btnBold
            // 
            btnBold.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBold.Image = (Image)resources.GetObject("btnBold.Image");
            btnBold.ImageTransparentColor = Color.Magenta;
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(29, 25);
            btnBold.Text = "B";
            btnBold.Click += btnBold_Click;
            // 
            // btnItalic
            // 
            btnItalic.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnItalic.Image = (Image)resources.GetObject("btnItalic.Image");
            btnItalic.ImageTransparentColor = Color.Magenta;
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(29, 25);
            btnItalic.Text = "I";
            btnItalic.Click += btnItalic_Click;
            // 
            // btnUnderLine
            // 
            btnUnderLine.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnUnderLine.Image = (Image)resources.GetObject("btnUnderLine.Image");
            btnUnderLine.ImageTransparentColor = Color.Magenta;
            btnUnderLine.Name = "btnUnderLine";
            btnUnderLine.Size = new Size(29, 25);
            btnUnderLine.Text = "U";
            btnUnderLine.Click += btnUnderLine_Click;
            // 
            // richText
            // 
            richText.Dock = DockStyle.Fill;
            richText.Location = new Point(0, 56);
            richText.Name = "richText";
            richText.Size = new Size(800, 394);
            richText.TabIndex = 2;
            richText.Text = "";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richText);
            Controls.Add(toolStrip1);
            Controls.Add(menuTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuTop;
            Name = "frmMain";
            Text = "Word Fake =)";
            Load += frmMain_Load;
            menuTop.ResumeLayout(false);
            menuTop.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuTop;
        private ToolStripMenuItem menuSystem;
        private ToolStripMenuItem menuFormat;
        private ToolStripMenuItem systemNewPage;
        private ToolStripMenuItem systemSave;
        private ToolStripMenuItem systemExit;
        private ToolStripMenuItem formatFont;
        private ToolStrip toolStrip1;
        private ToolStripComboBox cmbFonts;
        private ToolStripComboBox cmbSizes;
        private ToolStripButton btnBold;
        private ToolStripButton btnItalic;
        private ToolStripButton btnUnderLine;
        private ToolStripMenuItem systemOpenfile;
        private ToolStripButton btnNewPage;
        private ToolStripButton btnSave;
        private RichTextBox richText;
    }
}
