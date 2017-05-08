namespace GUI.UC.Tab
{
    partial class ThemSachMuon
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.labErr = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCTM = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMCS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTM)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.labErr);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.dgvCTM);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnFinish);
            this.panel2.Controls.Add(this.txtTienCoc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMCS);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 437);
            this.panel2.TabIndex = 51;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(262, 121);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 25);
            this.btnDel.TabIndex = 54;
            this.btnDel.TabStop = false;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // labErr
            // 
            this.labErr.AutoSize = true;
            this.labErr.ForeColor = System.Drawing.Color.Red;
            this.labErr.Location = new System.Drawing.Point(259, 101);
            this.labErr.Name = "labErr";
            this.labErr.Size = new System.Drawing.Size(0, 14);
            this.labErr.TabIndex = 53;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(378, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvCTM
            // 
            this.dgvCTM.AllowUserToAddRows = false;
            this.dgvCTM.AllowUserToDeleteRows = false;
            this.dgvCTM.AllowUserToResizeRows = false;
            this.dgvCTM.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCTM.Location = new System.Drawing.Point(3, 152);
            this.dgvCTM.MultiSelect = false;
            this.dgvCTM.Name = "dgvCTM";
            this.dgvCTM.ReadOnly = true;
            this.dgvCTM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCTM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTM.Size = new System.Drawing.Size(478, 232);
            this.dgvCTM.TabIndex = 49;
            this.dgvCTM.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(284, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(378, 402);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 25);
            this.btnFinish.TabIndex = 47;
            this.btnFinish.TabStop = false;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Enabled = false;
            this.txtTienCoc.Location = new System.Drawing.Point(35, 118);
            this.txtTienCoc.MaxLength = 10;
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(191, 20);
            this.txtTienCoc.TabIndex = 1;
            this.txtTienCoc.TextChanged += new System.EventHandler(this.txtTienCoc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 43;
            this.label4.Text = "Tiền cọc";
            // 
            // txtMCS
            // 
            this.txtMCS.Location = new System.Drawing.Point(35, 69);
            this.txtMCS.MaxLength = 10;
            this.txtMCS.Name = "txtMCS";
            this.txtMCS.Size = new System.Drawing.Size(191, 20);
            this.txtMCS.TabIndex = 0;
            this.txtMCS.TextChanged += new System.EventHandler(this.txtMCS_TextChanged);
            this.txtMCS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMCS_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 14);
            this.label12.TabIndex = 37;
            this.label12.Text = "Mã cuốn sách";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(148, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 25);
            this.label13.TabIndex = 36;
            this.label13.Text = "THÊM SÁCH MƯỢN";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(167, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 14);
            this.label14.TabIndex = 35;
            // 
            // ThemSachMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ThemSachMuon";
            this.Size = new System.Drawing.Size(484, 437);
            this.Load += new System.EventHandler(this.ThemSachMuon_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvCTM;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMCS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labErr;
        private System.Windows.Forms.Button btnDel;
    }
}
