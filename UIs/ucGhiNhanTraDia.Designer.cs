namespace UIs
{
    partial class ucGhiNhanTraDia
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btngetlist = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbltua = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdnotgood = new System.Windows.Forms.RadioButton();
            this.rdgood = new System.Windows.Forms.RadioButton();
            this.lbltinhtrangdia = new System.Windows.Forms.Label();
            this.lbltongtienquykhachphaitra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltiendatcoc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnkhongthanhtoanphitre = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbltientralaichokhach = new System.Windows.Forms.Label();
            this.btnluudulieu = new System.Windows.Forms.Button();
            this.grbgiucho = new System.Windows.Forms.GroupBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnext = new System.Windows.Forms.Label();
            this.lblsoluongdat = new System.Windows.Forms.Label();
            this.lblsodienthoai = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbgiucho.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(646, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Mã khách hàng";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btngetlist
            // 
            this.btngetlist.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetlist.Location = new System.Drawing.Point(688, 12);
            this.btngetlist.Name = "btngetlist";
            this.btngetlist.Size = new System.Drawing.Size(157, 23);
            this.btngetlist.TabIndex = 1;
            this.btngetlist.Text = "Lấy danh sách thuê đĩa";
            this.btngetlist.UseVisualStyleBackColor = true;
            this.btngetlist.Click += new System.EventHandler(this.btngetlist_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 251);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 291);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thuê đĩa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbltua);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rdnotgood);
            this.groupBox2.Controls.Add(this.rdgood);
            this.groupBox2.Controls.Add(this.lbltinhtrangdia);
            this.groupBox2.Controls.Add(this.lbltongtienquykhachphaitra);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbltiendatcoc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(555, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 291);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // lbltua
            // 
            this.lbltua.AutoSize = true;
            this.lbltua.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltua.Location = new System.Drawing.Point(101, 22);
            this.lbltua.Name = "lbltua";
            this.lbltua.Size = new System.Drawing.Size(0, 14);
            this.lbltua.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đĩa";
            // 
            // rdnotgood
            // 
            this.rdnotgood.AutoSize = true;
            this.rdnotgood.Location = new System.Drawing.Point(175, 233);
            this.rdnotgood.Name = "rdnotgood";
            this.rdnotgood.Size = new System.Drawing.Size(71, 17);
            this.rdnotgood.TabIndex = 7;
            this.rdnotgood.TabStop = true;
            this.rdnotgood.Text = "Không tốt";
            this.rdnotgood.UseVisualStyleBackColor = true;
            // 
            // rdgood
            // 
            this.rdgood.AutoSize = true;
            this.rdgood.Location = new System.Drawing.Point(67, 233);
            this.rdgood.Name = "rdgood";
            this.rdgood.Size = new System.Drawing.Size(41, 17);
            this.rdgood.TabIndex = 7;
            this.rdgood.TabStop = true;
            this.rdgood.Text = "Tốt";
            this.rdgood.UseVisualStyleBackColor = true;
            // 
            // lbltinhtrangdia
            // 
            this.lbltinhtrangdia.AutoSize = true;
            this.lbltinhtrangdia.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltinhtrangdia.Location = new System.Drawing.Point(52, 197);
            this.lbltinhtrangdia.Name = "lbltinhtrangdia";
            this.lbltinhtrangdia.Size = new System.Drawing.Size(97, 17);
            this.lbltinhtrangdia.TabIndex = 6;
            this.lbltinhtrangdia.Text = "Tình trạng đĩa";
            // 
            // lbltongtienquykhachphaitra
            // 
            this.lbltongtienquykhachphaitra.AutoSize = true;
            this.lbltongtienquykhachphaitra.ForeColor = System.Drawing.Color.Crimson;
            this.lbltongtienquykhachphaitra.Location = new System.Drawing.Point(108, 170);
            this.lbltongtienquykhachphaitra.Name = "lbltongtienquykhachphaitra";
            this.lbltongtienquykhachphaitra.Size = new System.Drawing.Size(0, 13);
            this.lbltongtienquykhachphaitra.TabIndex = 5;
            this.lbltongtienquykhachphaitra.TextChanged += new System.EventHandler(this.lbltongtienquykhachphaitra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng tiền khách phải trả (bao gồm \r\ncả phí trễ nếu có)";
            // 
            // lbltiendatcoc
            // 
            this.lbltiendatcoc.AutoSize = true;
            this.lbltiendatcoc.ForeColor = System.Drawing.Color.Green;
            this.lbltiendatcoc.Location = new System.Drawing.Point(108, 98);
            this.lbltiendatcoc.Name = "lbltiendatcoc";
            this.lbltiendatcoc.Size = new System.Drawing.Size(0, 13);
            this.lbltiendatcoc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiền đặt cọc của khách hàng";
            // 
            // btnkhongthanhtoanphitre
            // 
            this.btnkhongthanhtoanphitre.Enabled = false;
            this.btnkhongthanhtoanphitre.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkhongthanhtoanphitre.Location = new System.Drawing.Point(563, 333);
            this.btnkhongthanhtoanphitre.Name = "btnkhongthanhtoanphitre";
            this.btnkhongthanhtoanphitre.Size = new System.Drawing.Size(149, 37);
            this.btnkhongthanhtoanphitre.TabIndex = 5;
            this.btnkhongthanhtoanphitre.Text = "Không thanh toán phí trễ";
            this.btnkhongthanhtoanphitre.UseVisualStyleBackColor = true;
            this.btnkhongthanhtoanphitre.Click += new System.EventHandler(this.btnkhongthanhtoanphitre_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbltientralaichokhach);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(864, 87);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiền phải trả cho khách hàng";
            // 
            // lbltientralaichokhach
            // 
            this.lbltientralaichokhach.AutoSize = true;
            this.lbltientralaichokhach.ForeColor = System.Drawing.Color.Green;
            this.lbltientralaichokhach.Location = new System.Drawing.Point(335, 39);
            this.lbltientralaichokhach.Name = "lbltientralaichokhach";
            this.lbltientralaichokhach.Size = new System.Drawing.Size(0, 18);
            this.lbltientralaichokhach.TabIndex = 0;
            // 
            // btnluudulieu
            // 
            this.btnluudulieu.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluudulieu.Location = new System.Drawing.Point(718, 333);
            this.btnluudulieu.Name = "btnluudulieu";
            this.btnluudulieu.Size = new System.Drawing.Size(149, 37);
            this.btnluudulieu.TabIndex = 5;
            this.btnluudulieu.Text = "Ghi nhận đã trả đĩa";
            this.btnluudulieu.UseVisualStyleBackColor = true;
            this.btnluudulieu.Click += new System.EventHandler(this.btnluudulieu_Click);
            // 
            // grbgiucho
            // 
            this.grbgiucho.Controls.Add(this.btncancel);
            this.grbgiucho.Controls.Add(this.button1);
            this.grbgiucho.Controls.Add(this.label1);
            this.grbgiucho.Controls.Add(this.lblnext);
            this.grbgiucho.Controls.Add(this.lblsoluongdat);
            this.grbgiucho.Controls.Add(this.lblsodienthoai);
            this.grbgiucho.Controls.Add(this.lblname);
            this.grbgiucho.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbgiucho.Location = new System.Drawing.Point(3, 469);
            this.grbgiucho.Name = "grbgiucho";
            this.grbgiucho.Size = new System.Drawing.Size(864, 148);
            this.grbgiucho.TabIndex = 7;
            this.grbgiucho.TabStop = false;
            this.grbgiucho.Text = "Thông tin khách hàng đã đặt chỗ cho tựa đĩa này";
            this.grbgiucho.Visible = false;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(348, 82);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(224, 44);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Hủy đặt chỗ";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(578, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giữ lại chỗ cho khách hàng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chỉ có một khách hàng trong hàng đợi";
            this.label1.Visible = false;
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnext
            // 
            this.lblnext.AutoSize = true;
            this.lblnext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblnext.Location = new System.Drawing.Point(252, 75);
            this.lblnext.Name = "lblnext";
            this.lblnext.Size = new System.Drawing.Size(26, 17);
            this.lblnext.TabIndex = 3;
            this.lblnext.Text = ">>";
            this.lblnext.Click += new System.EventHandler(this.lblnext_Click);
            // 
            // lblsoluongdat
            // 
            this.lblsoluongdat.AutoSize = true;
            this.lblsoluongdat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoluongdat.Location = new System.Drawing.Point(150, 109);
            this.lblsoluongdat.Name = "lblsoluongdat";
            this.lblsoluongdat.Size = new System.Drawing.Size(0, 16);
            this.lblsoluongdat.TabIndex = 2;
            // 
            // lblsodienthoai
            // 
            this.lblsodienthoai.AutoSize = true;
            this.lblsodienthoai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsodienthoai.Location = new System.Drawing.Point(150, 72);
            this.lblsodienthoai.Name = "lblsodienthoai";
            this.lblsodienthoai.Size = new System.Drawing.Size(81, 16);
            this.lblsodienthoai.TabIndex = 2;
            this.lblsodienthoai.Text = "SoDienThoai";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(150, 34);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 17);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // ucGhiNhanTraDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnluudulieu);
            this.Controls.Add(this.btnkhongthanhtoanphitre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btngetlist);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbgiucho);
            this.Name = "ucGhiNhanTraDia";
            this.Size = new System.Drawing.Size(877, 692);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbgiucho.ResumeLayout(false);
            this.grbgiucho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btngetlist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnkhongthanhtoanphitre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbltongtienquykhachphaitra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltiendatcoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltientralaichokhach;
        private System.Windows.Forms.Button btnluudulieu;
        private System.Windows.Forms.RadioButton rdnotgood;
        private System.Windows.Forms.RadioButton rdgood;
        private System.Windows.Forms.Label lbltinhtrangdia;
        private System.Windows.Forms.GroupBox grbgiucho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblnext;
        private System.Windows.Forms.Label lblsodienthoai;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label lblsoluongdat;
        private System.Windows.Forms.Label lbltua;
        private System.Windows.Forms.Label label4;
    }
}
