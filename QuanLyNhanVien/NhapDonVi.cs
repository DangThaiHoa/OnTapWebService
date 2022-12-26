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
        }

        private void LoadDonViLenLuoi()
        {
            ws.Connect();
            dgv_donvi.DataSource = ws.Select("sp_LayThongTinDonVi").Tables[0].DefaultView;
        }
        String madv, tendv;

        private void LayDuLieuTuForm()
        {
            madv = txt_madv.Text;
            tendv = txt_tendv.Text;
        }

        private void dgv_donvi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_donvi.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_donvi.CurrentRow.Selected = true;
                txt_madv.Text = dgv_donvi.Rows[e.RowIndex].Cells["MADV"].FormattedValue.ToString();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ws.DeleteDonVi("sp_DeleteDonVi", txt_madv.Text.ToString());
            LoadDonViLenLuoi();
            txt_madv.Clear();
        }

        private void btn_nhap_Click(object sender, EventArgs e)
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
