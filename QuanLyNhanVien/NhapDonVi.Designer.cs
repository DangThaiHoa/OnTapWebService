
namespace QuanLyNhanVien
{
    partial class NhapDonVi
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
            this.btn_nhap = new System.Windows.Forms.Button();
            this.dgv_donvi = new System.Windows.Forms.DataGridView();
            this.txt_tendv = new System.Windows.Forms.TextBox();
            this.txt_madv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donvi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_nhap
            // 
            this.btn_nhap.Location = new System.Drawing.Point(31, 153);
            this.btn_nhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_nhap.Name = "btn_nhap";
            this.btn_nhap.Size = new System.Drawing.Size(119, 31);
            this.btn_nhap.TabIndex = 12;
            this.btn_nhap.Text = "Nhập";
            this.btn_nhap.UseVisualStyleBackColor = true;
            this.btn_nhap.Click += new System.EventHandler(this.btn_nhap_Click);
            // 
            // dgv_donvi
            // 
            this.dgv_donvi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_donvi.Location = new System.Drawing.Point(39, 190);
            this.dgv_donvi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_donvi.Name = "dgv_donvi";
            this.dgv_donvi.RowHeadersWidth = 51;
            this.dgv_donvi.Size = new System.Drawing.Size(357, 148);
            this.dgv_donvi.TabIndex = 11;
            this.dgv_donvi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_donvi_CellClick);
            // 
            // txt_tendv
            // 
            this.txt_tendv.Location = new System.Drawing.Point(158, 120);
            this.txt_tendv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.Size = new System.Drawing.Size(197, 22);
            this.txt_tendv.TabIndex = 10;
            // 
            // txt_madv
            // 
            this.txt_madv.Location = new System.Drawing.Point(158, 79);
            this.txt_madv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_madv.Name = "txt_madv";
            this.txt_madv.Size = new System.Drawing.Size(197, 22);
            this.txt_madv.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên Đơn Vị :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Đơn Vị :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập Đơn Vị";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(158, 151);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(119, 31);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(285, 151);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(119, 31);
            this.btn_sua.TabIndex = 14;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // NhapDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 370);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_nhap);
            this.Controls.Add(this.dgv_donvi);
            this.Controls.Add(this.txt_tendv);
            this.Controls.Add(this.txt_madv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NhapDonVi";
            this.Text = "NhapDonVi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donvi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_nhap;
        private System.Windows.Forms.DataGridView dgv_donvi;
        private System.Windows.Forms.TextBox txt_tendv;
        private System.Windows.Forms.TextBox txt_madv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
    }
}