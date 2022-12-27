using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhanVien
{
    public partial class NhapNhanVien : Form
    {
        ServiceReference.WebServiceSoapClient ws = new ServiceReference.WebServiceSoapClient();
        public NhapNhanVien()
        {
            InitializeComponent();
            LoadDonVi();
            LoadNhanVienLenLuoi();
            LOADNGAYTHANGNAM();
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            this.cboDonVi.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboNgay.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboThang.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboNam.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadDonVi()
        {
            ws.Connect();
            cboDonVi.DisplayMember = "TENDV";
            cboDonVi.ValueMember = "MADV";
            cboDonVi.DataSource = ws.Select("sp_LayThongTinDonVi").Tables[0].DefaultView;
            ws.Disconnect();
        }
        private void LoadNhanVienLenLuoi()
        {
            ws.Connect();
            dgridNhanVien.DataSource = ws.Select("sp_LayThongNhanVien").Tables[0].DefaultView;
        }
        OpenFileDialog openFile = new OpenFileDialog();
        String manv, hoten, diachi, madv;
        int gioitinh;
        DateTime ngaysinh;
        Byte[] image;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFile.InitialDirectory = @"C:";
            openFile.FileName = "";
            openFile.Filter = "All file (*.*)|*.*";
            openFile.RestoreDirectory = true;
            openFile.ShowDialog();
            if (openFile.FileName != "")
            {
                txtHinhAnh.Text = openFile.SafeFileName.Substring(openFile.SafeFileName.LastIndexOf(@"\") + 1);
                picHinhAnh.Image = Image.FromFile(openFile.FileName);
                FileStream fsFile = new FileStream(openFile.FileName,
                FileMode.Open, FileAccess.Read);
                image = new Byte[fsFile.Length];
                fsFile.Read(image, 0, image.Length);
                fsFile.Close();
            }

        }
        private void LOADNGAYTHANGNAM()
        {
            int i;
            for (i = 1; i <= 12; i++)
            {
                cboThang.Items.Add(i.ToString());
            }

            for (i = 1950; i <= DateTime.Now.Year; i++)

                cboNam.Items.Add(i.ToString());

        }
        private void LayDuLieuTuForm()
        {
            if (txtMaNV.Text.Length == 0 || txtHoTen.Text.Length == 0 || txtHinhAnh.Text.Length == 0 || txtDiaChi.Text.Length == 0 || cboGioiTinh.Text.Length == 0 || cboDonVi.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                manv = txtMaNV.Text;
                hoten = txtHoTen.Text;
                if (cboGioiTinh.SelectedItem.ToString() == "Nam")
                {
                    gioitinh = 1;
                }
                else
                {
                    gioitinh = 0;
                }
                ngaysinh = DateTime.Parse(cboNam.Text + "/" + cboThang.Text + "/" + cboNgay.Text);
                diachi = txtDiaChi.Text;

                madv = cboDonVi.SelectedValue.ToString();
            }
        }

        private void cboDonVi_Click(object sender, EventArgs e)
        {
            LoadDonVi();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhapDonVi nhapDonVi = new NhapDonVi();
            nhapDonVi.Show();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult = MessageBox.Show("Bạn có chắn chắn muốn xóa!?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                ws.DeleteNhanVien("sp_DeleteNhanVien", manv);
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
                txtMaNV.Enabled = true;
                LoadNhanVienLenLuoi();
            }
            else
            {
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
                txtMaNV.Enabled = true;
            }

        }
        private void dgridNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgridNhanVien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;
                txtMaNV.Enabled = false;
                try
                {
                    dgridNhanVien.CurrentRow.Selected = true;
                    manv = String.Format(dgridNhanVien.Rows[e.RowIndex].Cells["MANV"].FormattedValue.ToString());
                    txtMaNV.Text = dgridNhanVien.Rows[e.RowIndex].Cells["MANV"].FormattedValue.ToString();
                    txtDiaChi.Text = dgridNhanVien.Rows[e.RowIndex].Cells["DIACHI"].FormattedValue.ToString();
                    if (dgridNhanVien.Rows[e.RowIndex].Cells["HINHANH"].FormattedValue.ToString() != "")
                    {
                        Byte[] data = new Byte[0];
                        data = (Byte[])dgridNhanVien.Rows[e.RowIndex].Cells["HINHANH"].Value;
                        MemoryStream mem = new MemoryStream(data);
                        picHinhAnh.Image = Image.FromStream(mem);
                    }
                    else
                    {

                    }
                    txtHoTen.Text = dgridNhanVien.Rows[e.RowIndex].Cells["HOTEN"].FormattedValue.ToString();

                }
                catch (Exception)
                {
                    picHinhAnh.Image = null;
                    return;
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            ws.Connect();
            if (txtMaNV.Text.Length == 0 || txtHoTen.Text.Length == 0 || txtHinhAnh.Text.Length == 0 || txtDiaChi.Text.Length == 0 || cboGioiTinh.Text.Length == 0 || cboDonVi.Text.Length == 0)
            {
                LayDuLieuTuForm();
            }
            else
            {
                LayDuLieuTuForm();
                ws.Update("sp_UpdateNhanVien", manv, hoten, gioitinh, ngaysinh, diachi, image, madv);
                ws.Disconnect();
                LoadNhanVienLenLuoi();
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
                txtMaNV.Enabled = true;

            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            ws.Connect();
            if (txtMaNV.Text.Length == 0 || txtHoTen.Text.Length == 0 || txtHinhAnh.Text.Length == 0 || txtDiaChi.Text.Length == 0 || cboGioiTinh.Text.Length == 0 || cboDonVi.Text.Length == 0)
            {
                LayDuLieuTuForm();
            }
            else
            {
                LayDuLieuTuForm();
                String Query = "Select * from NHANVIEN where MANV = " + manv;
                if (ws.CheckKey(Query) == true)
                {
                    MessageBox.Show("Mã Nhân Viên Đã Tồn Tại");
                    txtMaNV.Clear();
                }
                else
                {
                    ws.Insert("sp_InsertNhanVien", manv, hoten, gioitinh, ngaysinh, diachi, image, madv);
                    ws.Disconnect();
                    LoadNhanVienLenLuoi();
                }
            }
        }

        private void CboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNgay.Items.Clear();
            int i;
            if (cboThang.SelectedItem.ToString() == "2")
            {

                for (i = 1; i <= 28; i++)
                    cboNgay.Items.Add(i.ToString());
            }
            else
            {
                if (cboThang.SelectedItem.ToString() == "1" || cboThang.SelectedItem.ToString() == "3" || cboThang.SelectedItem.ToString() == "5" || cboThang.SelectedItem.ToString() == "7" || cboThang.SelectedItem.ToString() == "8" || cboThang.SelectedItem.ToString() == "10" || cboThang.SelectedItem.ToString() == "12")
                {
                    for (i = 1; i <= 31; i++)
                        cboNgay.Items.Add(i.ToString());
                }
                else
                {
                    for (i = 1; i <= 30; i++)
                        cboNgay.Items.Add(i.ToString());
                }

            }
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i;
            if (cboThang.Text.Length == 0)
            {

            }
            else
            {
                if (cboThang.SelectedItem.ToString() == "2")
                {
                    String nam = cboNam.SelectedItem.ToString();
                    int a;
                    a = int.Parse(nam) / 4;
                    if (a % 2 == 0)
                    {
                        cboNgay.Items.Clear();
                        for (i = 1; i <= 29; i++)
                            cboNgay.Items.Add(i.ToString());
                    }
                    else
                    {
                        cboNgay.Items.Clear();
                        for (i = 1; i <= 28; i++)
                            cboNgay.Items.Add(i.ToString());
                    }
                }
            }
            
        }



    }
}
