using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class NhapDonVi : Form
    {
        ServiceReference.WebServiceSoapClient ws = new ServiceReference.WebServiceSoapClient();
        public NhapDonVi()
        {
            InitializeComponent();
            LoadDonViLenLuoi();
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;    
        }

        private void LoadDonViLenLuoi()
        {
            ws.Connect();
            dgv_donvi.DataSource = ws.Select("sp_LayThongTinDonVi").Tables[0].DefaultView;
        }
        String madv, tendv;

        private void LayDuLieuTuForm()
        {
            if(txt_madv.Text.Length == 0 || txt_tendv.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                madv = txt_madv.Text;
                tendv = txt_tendv.Text;
            }
            
        }

        private void dgv_donvi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_donvi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                btn_xoa.Enabled = true;
                btn_sua.Enabled = true;
                btn_nhap.Enabled = false;
                dgv_donvi.CurrentRow.Selected = true;
                madv = String.Format(dgv_donvi.Rows[e.RowIndex].Cells["MADV"].FormattedValue.ToString());
                txt_madv.Text = dgv_donvi.Rows[e.RowIndex].Cells["MADV"].FormattedValue.ToString();
                txt_tendv.Text = dgv_donvi.Rows[e.RowIndex].Cells["TENDV"].FormattedValue.ToString();
                txt_madv.Enabled = false;

            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắn chắn muốn xóa!?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                ws.DeleteDonVi("sp_DeleteDonVi", madv);
                LoadDonViLenLuoi();
                txt_madv.Clear();
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
                txt_madv.Enabled = true;
                btn_nhap.Enabled = true;
            }
            else
            {
                btn_xoa.Enabled = false;
                btn_sua.Enabled = false;
                txt_madv.Enabled = true;
                btn_nhap.Enabled = true;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_madv.Text.Length == 0 || txt_tendv.Text.Length == 0)
            {
                LayDuLieuTuForm();
            }
            else
            {
                ws.Connect();
                LayDuLieuTuForm();
                ws.UpdateDonVi("sp_UpdateDonVi", madv, tendv);
                ws.Disconnect();
                LoadDonViLenLuoi();
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
                txt_madv.Enabled = true;
                btn_nhap.Enabled = true;

            }
        }

        private void btn_nhap_Click(object sender, EventArgs e)
        {
            if (txt_madv.Text.Length == 0 || txt_tendv.Text.Length == 0)
            {
                LayDuLieuTuForm();
            }
            else
            {
                ws.Connect();
                LayDuLieuTuForm();
                String Query = "Select * from DONVI WHERE MADV = " + madv;
                if (ws.CheckKey(Query) == true)
                {
                    MessageBox.Show("Mã Đơn Vị Đã Tồn Tại");
                    txt_madv.Clear();
                }
                else
                {
                    ws.InsertDonVi("sp_InsertDonVi", madv, tendv);
                    ws.Disconnect();
                    LoadDonViLenLuoi();
                }
            }
        }
    }
}
