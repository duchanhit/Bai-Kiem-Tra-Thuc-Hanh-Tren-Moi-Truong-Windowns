using _2280600827_Hoang_Duc_Hanh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2280600827_Hoang_Duc_Hanh
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            var qLXetNghiemDB = new QLXetNghiemDB();
            var congTys = qLXetNghiemDB.CONGTY.ToList();

            cbbCongTy.DataSource = congTys;
            cbbCongTy.DisplayMember = "TenCty";
            cbbCongTy.ValueMember = "MaCty";

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string maCty = cbbCongTy.SelectedValue.ToString();

            var qLXetNghiemDB = new QLXetNghiemDB();
            var nhanViens = qLXetNghiemDB.NHANVIEN.Where(nv => nv.MaCty == maCty).ToList();

            if (nhanViens.Count == 0)
            {
                MessageBox.Show("Không có nhân viên nào được xét nghiệm trong công ty này.");
                return;
            }

            DataTable reportData = new DataTable();
            reportData.Columns.Add("CMND/CCCD");
            reportData.Columns.Add("Họ và Tên");
            reportData.Columns.Add("Kết Quả");

            foreach (var nv in nhanViens)
            {
                string ketQua = nv.AmTinh ? "Âm Tính" : "Dương Tính";
                reportData.Rows.Add(nv.ID, nv.HoTen, ketQua);
            }

            dataGridView1.DataSource = reportData;
        }
    }
}
