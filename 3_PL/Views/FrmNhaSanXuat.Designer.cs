namespace _3_PL.Views
{
    partial class FrmNhaSanXuat
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_noisx = new System.Windows.Forms.TextBox();
            this.rbn_hoatdong = new System.Windows.Forms.RadioButton();
            this.rbn_ngunghoatdong = new System.Windows.Forms.RadioButton();
            this.dtg_hienthi = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hienthi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhà Sản Xuất :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nơi Sản Xuất :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng Thái :";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(139, 14);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(271, 27);
            this.txt_ma.TabIndex = 4;
            // 
            // txt_noisx
            // 
            this.txt_noisx.Location = new System.Drawing.Point(139, 47);
            this.txt_noisx.Name = "txt_noisx";
            this.txt_noisx.Size = new System.Drawing.Size(271, 27);
            this.txt_noisx.TabIndex = 5;
            // 
            // rbn_hoatdong
            // 
            this.rbn_hoatdong.AutoSize = true;
            this.rbn_hoatdong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbn_hoatdong.Location = new System.Drawing.Point(139, 82);
            this.rbn_hoatdong.Name = "rbn_hoatdong";
            this.rbn_hoatdong.Size = new System.Drawing.Size(104, 24);
            this.rbn_hoatdong.TabIndex = 6;
            this.rbn_hoatdong.TabStop = true;
            this.rbn_hoatdong.Text = "Hoạt Động";
            this.rbn_hoatdong.UseVisualStyleBackColor = true;
            // 
            // rbn_ngunghoatdong
            // 
            this.rbn_ngunghoatdong.AutoSize = true;
            this.rbn_ngunghoatdong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbn_ngunghoatdong.Location = new System.Drawing.Point(256, 80);
            this.rbn_ngunghoatdong.Name = "rbn_ngunghoatdong";
            this.rbn_ngunghoatdong.Size = new System.Drawing.Size(154, 24);
            this.rbn_ngunghoatdong.TabIndex = 7;
            this.rbn_ngunghoatdong.TabStop = true;
            this.rbn_ngunghoatdong.Text = "Ngừng Hoạt Động";
            this.rbn_ngunghoatdong.UseVisualStyleBackColor = true;
            // 
            // dtg_hienthi
            // 
            this.dtg_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hienthi.Location = new System.Drawing.Point(9, 6);
            this.dtg_hienthi.Name = "dtg_hienthi";
            this.dtg_hienthi.RowHeadersWidth = 51;
            this.dtg_hienthi.RowTemplate.Height = 29;
            this.dtg_hienthi.Size = new System.Drawing.Size(517, 355);
            this.dtg_hienthi.TabIndex = 8;
            this.dtg_hienthi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_hienthi_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_them.Location = new System.Drawing.Point(3, 3);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(90, 30);
            this.btn_them.TabIndex = 9;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sua.Location = new System.Drawing.Point(99, 3);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(90, 30);
            this.btn_sua.TabIndex = 10;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoa.Location = new System.Drawing.Point(191, 3);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(90, 30);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Location = new System.Drawing.Point(547, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 37);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rbn_ngunghoatdong);
            this.panel2.Controls.Add(this.txt_ma);
            this.panel2.Controls.Add(this.rbn_hoatdong);
            this.panel2.Controls.Add(this.txt_noisx);
            this.panel2.Location = new System.Drawing.Point(547, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 119);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtg_hienthi);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 369);
            this.panel3.TabIndex = 14;
            // 
            // FrmNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 400);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmNhaSanXuat";
            this.Text = "Nhà Sản Xuất";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hienthi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_noisx;
        private System.Windows.Forms.RadioButton rbn_hoatdong;
        private System.Windows.Forms.RadioButton rbn_ngunghoatdong;
        private System.Windows.Forms.DataGridView dtg_hienthi;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}