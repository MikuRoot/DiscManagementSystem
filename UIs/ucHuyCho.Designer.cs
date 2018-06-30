namespace UIs
{
    partial class ucHuyCho
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
            this.txtmakhachhang = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnhuycho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hủy đặt chỗ tựa đĩa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tựa đĩa muốn hủy";
            // 
            // txtmakhachhang
            // 
            this.txtmakhachhang.AcceptsTab = true;
            this.txtmakhachhang.Location = new System.Drawing.Point(290, 118);
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new System.Drawing.Size(410, 20);
            this.txtmakhachhang.TabIndex = 0;
            this.txtmakhachhang.Click += new System.EventHandler(this.txtmakhachhang_Click);
            this.txtmakhachhang.TextChanged += new System.EventHandler(this.txtmakhachhang_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(290, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(410, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "-Danh sách tựa đĩa mà khách hàng đã đặt chỗ-";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnhuycho
            // 
            this.btnhuycho.Enabled = false;
            this.btnhuycho.Location = new System.Drawing.Point(341, 227);
            this.btnhuycho.Name = "btnhuycho";
            this.btnhuycho.Size = new System.Drawing.Size(172, 33);
            this.btnhuycho.TabIndex = 2;
            this.btnhuycho.Text = "Hủy chỗ";
            this.btnhuycho.UseVisualStyleBackColor = true;
            this.btnhuycho.Click += new System.EventHandler(this.btnhuycho_Click);
            // 
            // ucHuyCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnhuycho);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtmakhachhang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucHuyCho";
            this.Size = new System.Drawing.Size(877, 692);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmakhachhang;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnhuycho;
    }
}
