namespace GUI.UC
{
    partial class UCSach
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
            this.btnTuaSach = new GUI.ComponentForm.Flat_Button();
            this.pnlUseSach = new System.Windows.Forms.Panel();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.SystemColors.Control;
            this.pnlToolbar.Controls.Add(this.btnTuaSach);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(822, 35);
            this.pnlToolbar.TabIndex = 0;
            // 
            // btnTuaSach
            // 
            this.btnTuaSach.Active = false;
            this.btnTuaSach.BackColor = System.Drawing.Color.Transparent;
            this.btnTuaSach.BackgroundColorClick = System.Drawing.Color.Empty;
            this.btnTuaSach.BackgroundColorHover = System.Drawing.Color.Empty;
            this.btnTuaSach.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.btnTuaSach.IconAlignment = 3;
            this.btnTuaSach.IconClick = null;
            this.btnTuaSach.IconHover = null;
            this.btnTuaSach.IconNormal = null;
            this.btnTuaSach.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.btnTuaSach.IconSize = new System.Drawing.Size(0, 0);
            this.btnTuaSach.LineColorClick = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTuaSach.LineColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTuaSach.LineColorNormal = System.Drawing.Color.Green;
            this.btnTuaSach.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.Buttom;
            this.btnTuaSach.LineSize = 3;
            this.btnTuaSach.Location = new System.Drawing.Point(0, 0);
            this.btnTuaSach.MinimumSize = new System.Drawing.Size(23, 23);
            this.btnTuaSach.Name = "btnTuaSach";
            this.btnTuaSach.Size = new System.Drawing.Size(80, 35);
            this.btnTuaSach.TabIndex = 0;
            this.btnTuaSach.TabStop = false;
            this.btnTuaSach.Text = "Tựa Sách";
            this.btnTuaSach.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btnTuaSach.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btnTuaSach.TextColorClick = System.Drawing.Color.Empty;
            this.btnTuaSach.TextColorHover = System.Drawing.Color.Empty;
            this.btnTuaSach.TextColorNormal = System.Drawing.Color.Black;
            this.btnTuaSach.UseActive = true;
            this.btnTuaSach.UseBackgroundHoverClick = false;
            this.btnTuaSach.UseIconHoverClick = false;
            this.btnTuaSach.UseLineHoverClick = true;
            this.btnTuaSach.UseTextHoverClick = false;
            this.btnTuaSach.Click += new System.EventHandler(this.btnTuaSach_Click);
            // 
            // pnlUseSach
            // 
            this.pnlUseSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUseSach.Location = new System.Drawing.Point(0, 35);
            this.pnlUseSach.Name = "pnlUseSach";
            this.pnlUseSach.Size = new System.Drawing.Size(822, 443);
            this.pnlUseSach.TabIndex = 1;
            // 
            // UCSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUseSach);
            this.Controls.Add(this.pnlToolbar);
            this.Name = "UCSach";
            this.Size = new System.Drawing.Size(822, 478);
            this.pnlToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private ComponentForm.Flat_Button btnTuaSach;
        private System.Windows.Forms.Panel pnlUseSach;
    }
}
