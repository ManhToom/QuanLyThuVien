namespace GUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.domainUse = new GUI.ComponentForm.DomainUse();
            this.pnlUse = new System.Windows.Forms.Panel();
            this.pnlMenu = new GUI.ComponentForm.Panel_Simple();
            this.btnSeach = new GUI.ComponentForm.Flat_Button();
            this.ptrHome = new System.Windows.Forms.PictureBox();
            this.btnThongKe = new GUI.ComponentForm.Flat_Button();
            this.btnNghiepVu = new GUI.ComponentForm.Flat_Button();
            this.btnMuonTra = new GUI.ComponentForm.Flat_Button();
            this.btnSach = new GUI.ComponentForm.Flat_Button();
            this.btnMenu = new GUI.ComponentForm.Flat_Button();
            this.bxForm = new GUI.ComponentForm.BoxFrom();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domainUse.SuspendLayout();
            this.pnlUse.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrHome)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // domainUse
            // 
            this.domainUse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.domainUse.Controls.Add(this.pnlUse);
            this.domainUse.Controls.Add(this.pnlMenu);
            this.domainUse.FormState = System.Windows.Forms.FormWindowState.Normal;
            this.domainUse.Location = new System.Drawing.Point(1, 1);
            this.domainUse.Name = "domainUse";
            this.domainUse.Size = new System.Drawing.Size(1022, 478);
            this.domainUse.TabIndex = 0;
            // 
            // pnlUse
            // 
            this.pnlUse.BackColor = System.Drawing.SystemColors.Control;
            this.pnlUse.Controls.Add(this.menuStrip1);
            this.pnlUse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUse.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnlUse.Location = new System.Drawing.Point(200, 0);
            this.pnlUse.Name = "pnlUse";
            this.pnlUse.Size = new System.Drawing.Size(822, 478);
            this.pnlUse.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BotRightColor = System.Drawing.Color.DarkMagenta;
            this.pnlMenu.BottomLeftColor = System.Drawing.Color.DarkViolet;
            this.pnlMenu.Controls.Add(this.btnSeach);
            this.pnlMenu.Controls.Add(this.ptrHome);
            this.pnlMenu.Controls.Add(this.btnThongKe);
            this.pnlMenu.Controls.Add(this.btnNghiepVu);
            this.pnlMenu.Controls.Add(this.btnMuonTra);
            this.pnlMenu.Controls.Add(this.btnSach);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Controls.Add(this.bxForm);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 478);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.TopLeftColor = System.Drawing.Color.MediumTurquoise;
            this.pnlMenu.TopRightColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // btnSeach
            // 
            this.btnSeach.Active = false;
            this.btnSeach.BackColor = System.Drawing.Color.Transparent;
            this.btnSeach.BackgroundColorClick = System.Drawing.Color.Purple;
            this.btnSeach.BackgroundColorHover = System.Drawing.Color.Violet;
            this.btnSeach.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeach.IconAlignment = 11;
            this.btnSeach.IconClick = null;
            this.btnSeach.IconHover = null;
            this.btnSeach.IconNormal = ((System.Drawing.Image)(resources.GetObject("btnSeach.IconNormal")));
            this.btnSeach.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.LeftOfText;
            this.btnSeach.IconSize = new System.Drawing.Size(20, 20);
            this.btnSeach.LineColorClick = System.Drawing.Color.Empty;
            this.btnSeach.LineColorHover = System.Drawing.Color.Empty;
            this.btnSeach.LineColorNormal = System.Drawing.Color.Green;
            this.btnSeach.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.None;
            this.btnSeach.LineSize = 0;
            this.btnSeach.Location = new System.Drawing.Point(4, 177);
            this.btnSeach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeach.MinimumSize = new System.Drawing.Size(23, 23);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(199, 43);
            this.btnSeach.TabIndex = 7;
            this.btnSeach.TabStop = false;
            this.btnSeach.Text = "         Tìm kiếm sách";
            this.btnSeach.TextAlignmentHorizontal = System.Drawing.StringAlignment.Near;
            this.btnSeach.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnSeach.TextColorClick = System.Drawing.Color.Empty;
            this.btnSeach.TextColorHover = System.Drawing.Color.Empty;
            this.btnSeach.TextColorNormal = System.Drawing.Color.White;
            this.btnSeach.UseActive = true;
            this.btnSeach.UseBackgroundHoverClick = true;
            this.btnSeach.UseIconHoverClick = false;
            this.btnSeach.UseLineHoverClick = false;
            this.btnSeach.UseTextHoverClick = false;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // ptrHome
            // 
            this.ptrHome.BackColor = System.Drawing.Color.Transparent;
            this.ptrHome.Image = ((System.Drawing.Image)(resources.GetObject("ptrHome.Image")));
            this.ptrHome.Location = new System.Drawing.Point(67, 36);
            this.ptrHome.Name = "ptrHome";
            this.ptrHome.Size = new System.Drawing.Size(70, 63);
            this.ptrHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrHome.TabIndex = 6;
            this.ptrHome.TabStop = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Active = false;
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.BackgroundColorClick = System.Drawing.Color.Purple;
            this.btnThongKe.BackgroundColorHover = System.Drawing.Color.Violet;
            this.btnThongKe.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.IconAlignment = 11;
            this.btnThongKe.IconClick = null;
            this.btnThongKe.IconHover = null;
            this.btnThongKe.IconNormal = ((System.Drawing.Image)(resources.GetObject("btnThongKe.IconNormal")));
            this.btnThongKe.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.LeftOfText;
            this.btnThongKe.IconSize = new System.Drawing.Size(20, 20);
            this.btnThongKe.LineColorClick = System.Drawing.Color.Empty;
            this.btnThongKe.LineColorHover = System.Drawing.Color.Empty;
            this.btnThongKe.LineColorNormal = System.Drawing.Color.Green;
            this.btnThongKe.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.None;
            this.btnThongKe.LineSize = 0;
            this.btnThongKe.Location = new System.Drawing.Point(4, 377);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThongKe.MinimumSize = new System.Drawing.Size(23, 23);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(199, 43);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.TabStop = false;
            this.btnThongKe.Text = "         Thống kê";
            this.btnThongKe.TextAlignmentHorizontal = System.Drawing.StringAlignment.Near;
            this.btnThongKe.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnThongKe.TextColorClick = System.Drawing.Color.Empty;
            this.btnThongKe.TextColorHover = System.Drawing.Color.Empty;
            this.btnThongKe.TextColorNormal = System.Drawing.Color.White;
            this.btnThongKe.UseActive = true;
            this.btnThongKe.UseBackgroundHoverClick = true;
            this.btnThongKe.UseIconHoverClick = false;
            this.btnThongKe.UseLineHoverClick = false;
            this.btnThongKe.UseTextHoverClick = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnNghiepVu
            // 
            this.btnNghiepVu.Active = false;
            this.btnNghiepVu.BackColor = System.Drawing.Color.Transparent;
            this.btnNghiepVu.BackgroundColorClick = System.Drawing.Color.Purple;
            this.btnNghiepVu.BackgroundColorHover = System.Drawing.Color.Violet;
            this.btnNghiepVu.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnNghiepVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNghiepVu.IconAlignment = 11;
            this.btnNghiepVu.IconClick = null;
            this.btnNghiepVu.IconHover = null;
            this.btnNghiepVu.IconNormal = ((System.Drawing.Image)(resources.GetObject("btnNghiepVu.IconNormal")));
            this.btnNghiepVu.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.LeftOfText;
            this.btnNghiepVu.IconSize = new System.Drawing.Size(20, 20);
            this.btnNghiepVu.LineColorClick = System.Drawing.Color.Empty;
            this.btnNghiepVu.LineColorHover = System.Drawing.Color.Empty;
            this.btnNghiepVu.LineColorNormal = System.Drawing.Color.Green;
            this.btnNghiepVu.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.None;
            this.btnNghiepVu.LineSize = 0;
            this.btnNghiepVu.Location = new System.Drawing.Point(0, 326);
            this.btnNghiepVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNghiepVu.MinimumSize = new System.Drawing.Size(23, 23);
            this.btnNghiepVu.Name = "btnNghiepVu";
            this.btnNghiepVu.Size = new System.Drawing.Size(199, 43);
            this.btnNghiepVu.TabIndex = 4;
            this.btnNghiepVu.TabStop = false;
            this.btnNghiepVu.Text = "         Quản lý nghiệp vụ";
            this.btnNghiepVu.TextAlignmentHorizontal = System.Drawing.StringAlignment.Near;
            this.btnNghiepVu.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnNghiepVu.TextColorClick = System.Drawing.Color.Empty;
            this.btnNghiepVu.TextColorHover = System.Drawing.Color.Empty;
            this.btnNghiepVu.TextColorNormal = System.Drawing.Color.White;
            this.btnNghiepVu.UseActive = true;
            this.btnNghiepVu.UseBackgroundHoverClick = true;
            this.btnNghiepVu.UseIconHoverClick = false;
            this.btnNghiepVu.UseLineHoverClick = false;
            this.btnNghiepVu.UseTextHoverClick = false;
            this.btnNghiepVu.Click += new System.EventHandler(this.btnNghiepVu_Click);
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.Active = false;
            this.btnMuonTra.BackColor = System.Drawing.Color.Transparent;
            this.btnMuonTra.BackgroundColorClick = System.Drawing.Color.Purple;
            this.btnMuonTra.BackgroundColorHover = System.Drawing.Color.Violet;
            this.btnMuonTra.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnMuonTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuonTra.IconAlignment = 11;
            this.btnMuonTra.IconClick = null;
            this.btnMuonTra.IconHover = null;
            this.btnMuonTra.IconNormal = ((System.Drawing.Image)(resources.GetObject("btnMuonTra.IconNormal")));
            this.btnMuonTra.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.LeftOfText;
            this.btnMuonTra.IconSize = new System.Drawing.Size(20, 20);
            this.btnMuonTra.LineColorClick = System.Drawing.Color.Empty;
            this.btnMuonTra.LineColorHover = System.Drawing.Color.Empty;
            this.btnMuonTra.LineColorNormal = System.Drawing.Color.Green;
            this.btnMuonTra.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.None;
            this.btnMuonTra.LineSize = 0;
            this.btnMuonTra.Location = new System.Drawing.Point(4, 275);
            this.btnMuonTra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMuonTra.MinimumSize = new System.Drawing.Size(23, 23);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(199, 43);
            this.btnMuonTra.TabIndex = 3;
            this.btnMuonTra.TabStop = false;
            this.btnMuonTra.Text = "         Mượn trả sách";
            this.btnMuonTra.TextAlignmentHorizontal = System.Drawing.StringAlignment.Near;
            this.btnMuonTra.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnMuonTra.TextColorClick = System.Drawing.Color.Empty;
            this.btnMuonTra.TextColorHover = System.Drawing.Color.Empty;
            this.btnMuonTra.TextColorNormal = System.Drawing.Color.White;
            this.btnMuonTra.UseActive = true;
            this.btnMuonTra.UseBackgroundHoverClick = true;
            this.btnMuonTra.UseIconHoverClick = false;
            this.btnMuonTra.UseLineHoverClick = false;
            this.btnMuonTra.UseTextHoverClick = false;
            this.btnMuonTra.Click += new System.EventHandler(this.btnMuonTra_Click);
            // 
            // btnSach
            // 
            this.btnSach.Active = false;
            this.btnSach.BackColor = System.Drawing.Color.Transparent;
            this.btnSach.BackgroundColorClick = System.Drawing.Color.Purple;
            this.btnSach.BackgroundColorHover = System.Drawing.Color.Violet;
            this.btnSach.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.IconAlignment = 11;
            this.btnSach.IconClick = null;
            this.btnSach.IconHover = null;
            this.btnSach.IconNormal = ((System.Drawing.Image)(resources.GetObject("btnSach.IconNormal")));
            this.btnSach.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.LeftOfText;
            this.btnSach.IconSize = new System.Drawing.Size(20, 20);
            this.btnSach.LineColorClick = System.Drawing.Color.Empty;
            this.btnSach.LineColorHover = System.Drawing.Color.Empty;
            this.btnSach.LineColorNormal = System.Drawing.Color.Green;
            this.btnSach.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.None;
            this.btnSach.LineSize = 0;
            this.btnSach.Location = new System.Drawing.Point(1, 224);
            this.btnSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSach.MinimumSize = new System.Drawing.Size(23, 23);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(199, 43);
            this.btnSach.TabIndex = 2;
            this.btnSach.TabStop = false;
            this.btnSach.Text = "         Quản lý sách";
            this.btnSach.TextAlignmentHorizontal = System.Drawing.StringAlignment.Near;
            this.btnSach.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnSach.TextColorClick = System.Drawing.Color.Empty;
            this.btnSach.TextColorHover = System.Drawing.Color.Empty;
            this.btnSach.TextColorNormal = System.Drawing.Color.White;
            this.btnSach.UseActive = true;
            this.btnSach.UseBackgroundHoverClick = true;
            this.btnSach.UseIconHoverClick = false;
            this.btnSach.UseLineHoverClick = false;
            this.btnSach.UseTextHoverClick = false;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Active = false;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundColorClick = System.Drawing.Color.Purple;
            this.btnMenu.BackgroundColorHover = System.Drawing.Color.Violet;
            this.btnMenu.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.IconAlignment = 11;
            this.btnMenu.IconClick = null;
            this.btnMenu.IconHover = null;
            this.btnMenu.IconNormal = ((System.Drawing.Image)(resources.GetObject("btnMenu.IconNormal")));
            this.btnMenu.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.LeftOfText;
            this.btnMenu.IconSize = new System.Drawing.Size(20, 20);
            this.btnMenu.LineColorClick = System.Drawing.Color.Empty;
            this.btnMenu.LineColorHover = System.Drawing.Color.Empty;
            this.btnMenu.LineColorNormal = System.Drawing.Color.Green;
            this.btnMenu.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.None;
            this.btnMenu.LineSize = 0;
            this.btnMenu.Location = new System.Drawing.Point(1, 126);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenu.MinimumSize = new System.Drawing.Size(23, 23);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(199, 43);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Text = "         Menu";
            this.btnMenu.TextAlignmentHorizontal = System.Drawing.StringAlignment.Near;
            this.btnMenu.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnMenu.TextColorClick = System.Drawing.Color.Empty;
            this.btnMenu.TextColorHover = System.Drawing.Color.Empty;
            this.btnMenu.TextColorNormal = System.Drawing.Color.White;
            this.btnMenu.UseActive = false;
            this.btnMenu.UseBackgroundHoverClick = true;
            this.btnMenu.UseIconHoverClick = false;
            this.btnMenu.UseLineHoverClick = false;
            this.btnMenu.UseTextHoverClick = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // bxForm
            // 
            this.bxForm.BackColor = System.Drawing.Color.Transparent;
            this.bxForm.BoxStyle = GUI.ComponentForm.BoxFrom.BxStyle.Row;
            this.bxForm.FormMain = null;
            this.bxForm.Location = new System.Drawing.Point(13, 2);
            this.bxForm.Name = "bxForm";
            this.bxForm.Size = new System.Drawing.Size(55, 15);
            this.bxForm.TabIndex = 0;
            this.bxForm.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.helpToolStripMenuItem.Text = "Help(F1)";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1024, 480);
            this.Controls.Add(this.domainUse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1024, 480);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.domainUse.ResumeLayout(false);
            this.pnlUse.ResumeLayout(false);
            this.pnlUse.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrHome)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentForm.DomainUse domainUse;
        private ComponentForm.Panel_Simple pnlMenu;
        private ComponentForm.Flat_Button btnMenu;
        private ComponentForm.BoxFrom bxForm;
        private ComponentForm.Flat_Button btnThongKe;
        private ComponentForm.Flat_Button btnNghiepVu;
        private ComponentForm.Flat_Button btnMuonTra;
        private ComponentForm.Flat_Button btnSach;
        private System.Windows.Forms.PictureBox ptrHome;
        private ComponentForm.Flat_Button btnSeach;
        private System.Windows.Forms.Panel pnlUse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}