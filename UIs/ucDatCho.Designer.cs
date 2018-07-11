namespace UIs
{
    partial class ucDatCho
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
            this.dgvtuade = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblloaidia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmakhachhang = new System.Windows.Forms.TextBox();
            this.btntieptucdatcho = new System.Windows.Forms.Button();
            this.btndatcho = new System.Windows.Forms.Button();
            this.lbltrangthai = new System.Windows.Forms.Label();
            this.lblsoluongdiaconlai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnoidungtuade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtuade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtuade
            // 
            this.dgvtuade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtuade.Location = new System.Drawing.Point(3, 3);
            this.dgvtuade.MultiSelect = false;
            this.dgvtuade.Name = "dgvtuade";
            this.dgvtuade.ReadOnly = true;
            this.dgvtuade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtuade.Size = new System.Drawing.Size(871, 150);
            this.dgvtuade.TabIndex = 0;
            this.dgvtuade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtuade_CellContentClick);
            this.dgvtuade.SelectionChanged += new System.EventHandler(this.dgvtuade_SelectionChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 461);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.lblloaidia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmakhachhang);
            this.groupBox1.Controls.Add(this.btntieptucdatcho);
            this.groupBox1.Controls.Add(this.btndatcho);
            this.groupBox1.Controls.Add(this.lbltrangthai);
            this.groupBox1.Controls.Add(this.lblsoluongdiaconlai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblnoidungtuade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(338, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 461);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin của tựa đề";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số lượng đặt đĩa";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(217, 278);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(191, 26);
            this.numericUpDown1.TabIndex = 9;
            // 
            // lblloaidia
            // 
            this.lblloaidia.AutoSize = true;
            this.lblloaidia.Location = new System.Drawing.Point(242, 57);
            this.lblloaidia.Name = "lblloaidia";
            this.lblloaidia.Size = new System.Drawing.Size(0, 18);
            this.lblloaidia.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại đĩa";
            // 
            // txtmakhachhang
            // 
            this.txtmakhachhang.Location = new System.Drawing.Point(64, 236);
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new System.Drawing.Size(395, 26);
            this.txtmakhachhang.TabIndex = 6;
            this.txtmakhachhang.Text = "Nhập mã khách hàng";
            this.txtmakhachhang.Visible = false;
            this.txtmakhachhang.Click += new System.EventHandler(this.txtmakhachhang_Click);
            this.txtmakhachhang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtmakhachhang_KeyUp);
            this.txtmakhachhang.Leave += new System.EventHandler(this.txtmakhachhang_Leave);
            this.txtmakhachhang.MouseLeave += new System.EventHandler(this.txtmakhachhang_MouseLeave);
            // 
            // btntieptucdatcho
            // 
            this.btntieptucdatcho.Enabled = false;
            this.btntieptucdatcho.Location = new System.Drawing.Point(268, 328);
            this.btntieptucdatcho.Name = "btntieptucdatcho";
            this.btntieptucdatcho.Size = new System.Drawing.Size(191, 34);
            this.btntieptucdatcho.TabIndex = 5;
            this.btntieptucdatcho.Text = "Tiếp tục đặt chỗ >>";
            this.btntieptucdatcho.UseVisualStyleBackColor = true;
            this.btntieptucdatcho.Visible = false;
            this.btntieptucdatcho.Click += new System.EventHandler(this.btntieptucdatcho_Click);
            // 
            // btndatcho
            // 
            this.btndatcho.Enabled = false;
            this.btndatcho.Location = new System.Drawing.Point(64, 328);
            this.btndatcho.Name = "btndatcho";
            this.btndatcho.Size = new System.Drawing.Size(191, 34);
            this.btndatcho.TabIndex = 5;
            this.btndatcho.Text = ". Đặt chỗ .";
            this.btndatcho.UseVisualStyleBackColor = true;
            this.btndatcho.Click += new System.EventHandler(this.btndatcho_Click);
            // 
            // lbltrangthai
            // 
            this.lbltrangthai.AutoSize = true;
            this.lbltrangthai.Location = new System.Drawing.Point(39, 177);
            this.lbltrangthai.Name = "lbltrangthai";
            this.lbltrangthai.Size = new System.Drawing.Size(0, 18);
            this.lbltrangthai.TabIndex = 4;
            // 
            // lblsoluongdiaconlai
            // 
            this.lblsoluongdiaconlai.AutoSize = true;
            this.lblsoluongdiaconlai.Location = new System.Drawing.Point(242, 124);
            this.lblsoluongdiaconlai.Name = "lblsoluongdiaconlai";
            this.lblsoluongdiaconlai.Size = new System.Drawing.Size(0, 18);
            this.lblsoluongdiaconlai.TabIndex = 3;
            this.lblsoluongdiaconlai.TextChanged += new System.EventHandler(this.lblsoluongdiaconlai_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng đĩa còn lại";
            // 
            // lblnoidungtuade
            // 
            this.lblnoidungtuade.AutoSize = true;
            this.lblnoidungtuade.Location = new System.Drawing.Point(242, 91);
            this.lblnoidungtuade.Name = "lblnoidungtuade";
            this.lblnoidungtuade.Size = new System.Drawing.Size(0, 18);
            this.lblnoidungtuade.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung tựa đề";
            // 
            // ucDatCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvtuade);
            this.Name = "ucDatCho";
            this.Size = new System.Drawing.Size(877, 692);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtuade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtuade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblsoluongdiaconlai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnoidungtuade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmakhachhang;
        private System.Windows.Forms.Button btndatcho;
        private System.Windows.Forms.Label lbltrangthai;
        private System.Windows.Forms.Label lblloaidia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntieptucdatcho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
