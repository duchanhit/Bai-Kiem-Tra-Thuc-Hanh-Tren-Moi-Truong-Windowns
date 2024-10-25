using DAL.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NhanVienService = new NhanVienService();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                List<NHANVIEN> nhanViens = NhanVienService.GetAllNhanViens();

                var dataTable = new System.Data.DataTable();
                dataTable.Columns.Add("CMND/CCCD");
                dataTable.Columns.Add("Họ và Tên");
                dataTable.Columns.Add("Số lần XN");
                dataTable.Columns.Add("Kết Quả");

                foreach (var nv in nhanViens)
                {
                    string ketQua = nv.AmTinh ? "Âm Tính" : "+";
                    dataTable.Rows.Add(nv.ID, nv.HoTen, nv.SoLanXN, ketQua);
                }

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
    }
}
