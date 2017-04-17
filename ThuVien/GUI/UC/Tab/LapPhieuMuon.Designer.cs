namespace GUI.UC.Tab
{
    partial class LapPhieuMuon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labErr = new System.Windows.Forms.Label();
            this.txtMDG = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateHtra = new System.Windows.Forms.DateTimePicker();
            this.dateLap = new System.Windows.Forms.DateTimePicker();
            this.txtMTT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoPMT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labErr);
            this.panel1.Controls.Add(this.txtMDG);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateHtra);
            this.panel1.Controls.Add(this.dateLap);
            this.panel1.Controls.Add(this.txtMTT);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSoPMT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 406);
            this.panel1.TabIndex = 2;
            // 
            // labErr
            // 
            this.labErr.AutoSize = true;
            this.labErr.ForeColor = System.Drawing.Color.Red;
            this.labErr.Location = new System.Drawing.Point(32, 314);
            this.labErr.Name = "labErr";
            this.labErr.Size = new System.Drawing.Size(0, 13);
            this.labErr.TabIndex = 51;
            // 
            // txtMDG
            // 
            this.txtMDG.Enabled = false;
            this.txtMDG.Location = new System.Drawing.Point(35, 126);
            this.txtMDG.MaxLength = 10;
            this.txtMDG.Name = "txtMDG";
            this.txtMDG.Size = new System.Drawing.Size(191, 20);
            this.txtMDG.TabIndex = 50;
            this.txtMDG.TabStop = false;
            this.txtMDG.TextChanged += new System.EventHandler(this.txtSoPMT_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Mã độc giả";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.TabStop = false;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.TabStop = false;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateHtra
            // 
            this.dateHtra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHtra.Location = new System.Drawing.Point(35, 219);
            this.dateHtra.Name = "dateHtra";
            this.dateHtra.Size = new System.Drawing.Size(191, 20);
            this.dateHtra.TabIndex = 46;
            this.dateHtra.TabStop = false;
            this.dateHtra.ValueChanged += new System.EventHandler(this.txtSoPMT_TextChanged);
            // 
            // dateLap
            // 
            this.dateLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateLap.Location = new System.Drawing.Point(35, 172);
            this.dateLap.Name = "dateLap";
            this.dateLap.Size = new System.Drawing.Size(191, 20);
            this.dateLap.TabIndex = 45;
            this.dateLap.TabStop = false;
            this.dateLap.ValueChanged += new System.EventHandler(this.txtSoPMT_TextChanged);
            // 
            // txtMTT
            // 
            this.txtMTT.Location = new System.Drawing.Point(35, 264);
            this.txtMTT.MaxLength = 10;
            this.txtMTT.Name = "txtMTT";
            this.txtMTT.Size = new System.Drawing.Size(191, 20);
            this.txtMTT.TabIndex = 1;
            this.txtMTT.TextChanged += new System.EventHandler(this.txtSoPMT_TextChanged);
            this.txtMTT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMTT_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Mã thủ thư";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Ngày hẹn trả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Ngày lập";
            // 
            // txtSoPMT
            // 
            this.txtSoPMT.Enabled = false;
            this.txtSoPMT.Location = new System.Drawing.Point(35, 80);
            this.txtSoPMT.MaxLength = 10;
            this.txtSoPMT.Name = "txtSoPMT";
            this.txtSoPMT.Size = new System.Drawing.Size(191, 20);
            this.txtSoPMT.TabIndex = 0;
            this.txtSoPMT.TabStop = false;
            this.txtSoPMT.TextChanged += new System.EventHandler(this.txtSoPMT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Số phiếu mượn trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(139, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "LẬP PHIẾU MƯỢN TRẢ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 35;
            // 
            // LapPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "LapPhieuMuon";
            this.Size = new System.Drawing.Size(484, 406);
            this.Load += new System.EventHandler(this.LapPhieuMuon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateHtra;
        private System.Windows.Forms.DateTimePicker dateLap;
        private System.Windows.Forms.TextBox txtMTT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoPMT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMDG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labErr;
    }
}
