namespace GUI.UC
{
    partial class UCNghiepVu
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
            foreach (System.Windows.Forms.Control ctrl in this.Controls)
            {
                ctrl.Dispose();
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnDocGia = new GUI.ComponentForm.Flat_Button();
            this.pnlUseNghiepVu = new System.Windows.Forms.Panel();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.SystemColors.Control;
            this.pnlToolbar.Controls.Add(this.btnDocGia);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(822, 35);
            this.pnlToolbar.TabIndex = 0;
            // 
            // btnDocGia
            // 
            this.btnDocGia.Active = false;
            this.btnDocGia.BackColor = System.Drawing.Color.Transparent;
            this.btnDocGia.BackgroundColorClick = System.Drawing.Color.Empty;
            this.btnDocGia.BackgroundColorHover = System.Drawing.Color.Empty;
            this.btnDocGia.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnDocGia.IconAlignment = 3;
            this.btnDocGia.IconClick = null;
            this.btnDocGia.IconHover = null;
            this.btnDocGia.IconNormal = null;
            this.btnDocGia.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.btnDocGia.IconSize = new System.Drawing.Size(0, 0);
            this.btnDocGia.LineColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDocGia.LineColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDocGia.LineColorNormal = System.Drawing.Color.Green;
            this.btnDocGia.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.Buttom;
            this.btnDocGia.LineSize = 3;
            this.btnDocGia.Location = new System.Drawing.Point(0, 0);
            this.btnDocGia.MinimumSize = new System.Drawing.Size(23, 23);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(80, 35);
            this.btnDocGia.TabIndex = 0;
            this.btnDocGia.Text = "Độc giả";
            this.btnDocGia.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnDocGia.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnDocGia.TextColorClick = System.Drawing.Color.Empty;
            this.btnDocGia.TextColorHover = System.Drawing.Color.Empty;
            this.btnDocGia.TextColorNormal = System.Drawing.Color.Black;
            this.btnDocGia.UseActive = true;
            this.btnDocGia.UseBackgroundHoverClick = false;
            this.btnDocGia.UseIconHoverClick = false;
            this.btnDocGia.UseLineHoverClick = true;
            this.btnDocGia.UseTextHoverClick = false;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // pnlUseNghiepVu
            // 
            this.pnlUseNghiepVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUseNghiepVu.Location = new System.Drawing.Point(0, 35);
            this.pnlUseNghiepVu.Name = "pnlUseNghiepVu";
            this.pnlUseNghiepVu.Size = new System.Drawing.Size(822, 443);
            this.pnlUseNghiepVu.TabIndex = 1;
            // 
            // UCNghiepVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUseNghiepVu);
            this.Controls.Add(this.pnlToolbar);
            this.Name = "UCNghiepVu";
            this.Size = new System.Drawing.Size(822, 478);
            this.pnlToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private ComponentForm.Flat_Button btnDocGia;
        private System.Windows.Forms.Panel pnlUseNghiepVu;
    }
}
