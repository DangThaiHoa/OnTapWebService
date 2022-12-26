using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NhapDonVi
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
            dgv_donvi.DataSource = ws.Select("sp_LayThongDonVi").Tables[0].DefaultView;
        }

        private void NhapDonVi_Load(object sender, EventArgs e)
        {

        }
    }
}
