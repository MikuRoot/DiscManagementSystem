namespace UIs
{
    partial class ucCapNhatThongTinKhachHang
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
            this.txttenhoacmakhachhang = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmakhachhang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenkhachhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsodienthoai = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttenhoacmakhachhang
            // 
            this.txttenhoacmakhachhang.Location = new System.Drawing.Point(67, 44);
            this.txttenhoacmakhachhang.Name = "txttenhoacmakhachhang";
            this.txttenhoacmakhachhang.Size = new System.Drawing.Size(712, 20);
            this.txttenhoacmakhachhang.TabIndex = 0;
            this.txttenhoacmakhachhang.Click += new System.EventHandler(this.txttenhoacmakhachhang_Click);
            this.txttenhoacmakhachhang.TextChanged += new System.EventHandler(this.txttenhoacmakhachhang_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(869, 197);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 223);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng lấy được";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsodienthoai);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txttenkhachhang);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblmakhachhang);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 105);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin của khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // lblmakhachhang
            // 
            this.lblmakhachhang.AutoSize = true;
            this.lblmakhachhang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmakhachhang.Location = new System.Drawing.Point(182, 43);
            this.lblmakhachhang.Name = "lblmakhachhang";
            this.lblmakhachhang.Size = new System.Drawing.Size(0, 16);
            this.lblmakhachhang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // txttenkhachhang
            // 
            this.txttenkhachhang.Location = new System.Drawing.Point(419, 40);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.Size = new System.Drawing.Size(177, 23);
            this.txttenkhachhang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại";
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsodienthoai.Location = new System.Drawing.Point(724, 40);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(151, 23);
            this.txtsodienthoai.TabIndex = 5;
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(566, 385);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(213, 36);
            this.btnluu.TabIndex = 4;
            this.btnluu.Text = ". Lưu lại thông tin .";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // ucCapNhatThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttenhoacmakhachhang);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucCapNhatThongTinKhachHang";
            this.Size = new System.Drawing.Size(887, 692);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttenhoacmakhachhang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsodienthoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenkhachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmakhachhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnluu;
    }
}
