namespace GUI.UC
{
    partial class UCTimKiem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comtl = new System.Windows.Forms.ComboBox();
            this.txttesach = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flat_Button1 = new GUI.ComponentForm.Flat_Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thư Viện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(277, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm Kiếm Sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(20, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thể Loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(340, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên Sách";
            // 
            // comtl
            // 
            this.comtl.FormattingEnabled = true;
            this.comtl.Location = new System.Drawing.Point(118, 137);
            this.comtl.Name = "comtl";
            this.comtl.Size = new System.Drawing.Size(155, 21);
            this.comtl.TabIndex = 7;
            // 
            // txttesach
            // 
            this.txttesach.Location = new System.Drawing.Point(446, 138);
            this.txttesach.Name = "txttesach";
            this.txttesach.Size = new System.Drawing.Size(142, 20);
            this.txttesach.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(819, 219);
            this.dataGridView1.TabIndex = 10;
            // 
            // flat_Button1
            // 
            this.flat_Button1.Active = false;
            this.flat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.flat_Button1.BackgroundColorClick = System.Drawing.Color.Yellow;
            this.flat_Button1.BackgroundColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flat_Button1.BackgroundColorNormal = System.Drawing.Color.Transparent;
            this.flat_Button1.IconAlignment = 3;
            this.flat_Button1.IconClick = null;
            this.flat_Button1.IconHover = null;
            this.flat_Button1.IconNormal = null;
            this.flat_Button1.IconPositions = GUI.ComponentForm.Flat_Button.IconPosition.OnlyText;
            this.flat_Button1.IconSize = new System.Drawing.Size(0, 0);
            this.flat_Button1.LineColorClick = System.Drawing.Color.Empty;
            this.flat_Button1.LineColorHover = System.Drawing.Color.Empty;
            this.flat_Button1.LineColorNormal = System.Drawing.Color.Green;
            this.flat_Button1.LineLayout = GUI.ComponentForm.Flat_Button.LinePosition.None;
            this.flat_Button1.LineSize = 0;
            this.flat_Button1.Location = new System.Drawing.Point(744, 223);
            this.flat_Button1.MinimumSize = new System.Drawing.Size(23, 23);
            this.flat_Button1.Name = "flat_Button1";
            this.flat_Button1.Size = new System.Drawing.Size(75, 27);
            this.flat_Button1.TabIndex = 11;
            this.flat_Button1.Text = "Tìm Kiếm";
            this.flat_Button1.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.flat_Button1.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.flat_Button1.TextColorClick = System.Drawing.Color.Empty;
            this.flat_Button1.TextColorHover = System.Drawing.Color.Empty;
            this.flat_Button1.TextColorNormal = System.Drawing.Color.Black;
            this.flat_Button1.UseActive = false;
            this.flat_Button1.UseBackgroundHoverClick = true;
            this.flat_Button1.UseIconHoverClick = false;
            this.flat_Button1.UseLineHoverClick = false;
            this.flat_Button1.UseTextHoverClick = false;
            
            // 
            // UCTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flat_Button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttesach);
            this.Controls.Add(this.comtl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCTimKiem";
            this.Size = new System.Drawing.Size(822, 478);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comtl;
        private System.Windows.Forms.TextBox txttesach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ComponentForm.Flat_Button flat_Button1;
    }
}
