using _2280600827_Hoang_Duc_Hanh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2280600827_Hoang_Duc_Hanh
{
    public partial class Form1 : Form
    {
        public QLXetNghiemDB QLXetNghiemDB { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                QLXetNghiemDB qLXetNghiemDB = new QLXetNghiemDB();
                var listCty = qLXetNghiemDB.CONGTY.ToList();
                var listNV = qLXetNghiemDB.NHANVIEN.ToList();
                FillCongTyComboBox(listCty);
                BindGrid(listNV);
                ClearInput();
                gbThongTinXetNghiem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearInput()
        {
            txtCMNDCCCD.Text = null;
            txtHoTen.Text = null;
            txtSLXN.Text = null;
            rBtnAmTinh.Checked = true;
            gbThongTinXetNghiem.Enabled = false;

        }
        private void FillCongTyComboBox(List<CONGTY> CONGTies)
        {
            this.cbbCongTy.DataSource = CONGTies;
            this.cbbCongTy.DisplayMember = "TenCty";
            this.cbbCongTy.ValueMember = "MaCty";
            this.cbbCongTy.SelectedIndex = 0;
        }
        private void BindGrid(List<NHANVIEN> NHANVIENs)
        {
            dataGridView1.Rows.Clear();
            foreach (var NhanVien in NHANVIENs)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = NhanVien.ID;
                dataGridView1.Rows[index].Cells[1].Value = NhanVien.HoTen;
                dataGridView1.Rows[index].Cells[2].Value = NhanVien.SoLanXN;
                if (NhanVien.AmTinh)
                {
                    dataGridView1.Rows[index].Cells[3].Value = "Âm tính";
                }
                else
                {
                    dataGridView1.Rows[index].Cells[3].Value = "+";
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string cmnd = txtCMNDCCCD.Text.Trim();

                if (cmnd.Length != 9 && cmnd.Length != 12)
                {
                    MessageBox.Show("Vui lòng nhập CCCD hoặc CMND với độ dài 9 hoặc 12 ký tự.");
                    return;
                }

                if (!cmnd.All(char.IsDigit))
                {
                    MessageBox.Show("ID chỉ là các ký tự số.");
                    return;
                }

                var qLXetNghiemDB = new QLXetNghiemDB();
                var nhanVien = qLXetNghiemDB.NHANVIEN.FirstOrDefault(nv => nv.ID == cmnd);

                if (nhanVien == null)
                {
                    //MessageBox.Show("CMND/CCCD chưa tồn tại trong CSDL. Vui lòng nhập thông tin nhân viên mới.");
                    gbThongTinXetNghiem.Enabled = true;
                    txtHoTen.Text = "";
                    txtSLXN.Text = "1";
                    txtSLXN.ReadOnly = true;
                    rBtnAmTinh.Checked = true;
                    FillCongTyComboBox(qLXetNghiemDB.CONGTY.ToList());
                    cbbCongTy.SelectedIndex = 0;
                }
                else
                {
                    txtHoTen.Text = nhanVien.HoTen;
                    txtSLXN.Text = (nhanVien.SoLanXN + 1).ToString();
                    if (nhanVien.AmTinh)
                    {
                        rBtnAmTinh.Checked = true;
                    }
                    else
                    {
                        rBtnDuongTinh.Checked = true;
                    }
                    cbbCongTy.SelectedValue = nhanVien.MaCty;
                    gbThongTinXetNghiem.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string cmnd = txtCMNDCCCD.Text.Trim();
                if (string.IsNullOrEmpty(cmnd))
                {
                    MessageBox.Show("Vui lòng nhập CMND/CCCD.");
                    return;
                }

                var qLXetNghiemDB = new QLXetNghiemDB();

                var nhanVien = qLXetNghiemDB.NHANVIEN.FirstOrDefault(nv => nv.ID == cmnd);

                if (nhanVien == null)
                {
                    NHANVIEN newNhanVien = new NHANVIEN
                    {
                        ID = cmnd,
                        HoTen = txtHoTen.Text.Trim(),
                        SoLanXN = 1,
                        AmTinh = rBtnAmTinh.Checked,
                        MaCty = cbbCongTy.SelectedValue.ToString()
                    };

                    qLXetNghiemDB.NHANVIEN.Add(newNhanVien);
                    qLXetNghiemDB.SaveChanges();
                    MessageBox.Show("Thêm mới thành công!");

                }
                else
                {
                    nhanVien.HoTen = txtHoTen.Text.Trim();
                    nhanVien.SoLanXN += 1;
                    nhanVien.AmTinh = rBtnAmTinh.Checked;
                    nhanVien.MaCty = cbbCongTy.SelectedValue.ToString();

                    qLXetNghiemDB.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!");
                }

                var listNV = qLXetNghiemDB.NHANVIEN.ToList();
                BindGrid(listNV);

                ClearInput();
                gbThongTinXetNghiem.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        private void dsNVDuongTinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qLXetNghiemDB = new QLXetNghiemDB();
            var nhanViensDuongTinh = qLXetNghiemDB.NHANVIEN.Where(nv => !nv.AmTinh).ToList();

            BindGrid(nhanViensDuongTinh);
        }

        private void dsCtyDaTestTheoYCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qLXetNghiemDB = new QLXetNghiemDB();

            var congTys = qLXetNghiemDB.CONGTY.ToList();

            var congTysTestDu = new List<string>();

            foreach (var congTy in congTys)
            {
                var soNhanVienDaTest = qLXetNghiemDB.NHANVIEN.Count(nv => nv.MaCty == congTy.MaCty);

                if (soNhanVienDaTest >= congTy.SLNV)
                {
                    congTysTestDu.Add(congTy.TenCty);
                }
            }

            if (congTysTestDu.Count > 0)
            {
                string danhSachCongTy = "Các Công Ty đã test đủ Y/C:\n" + string.Join("\n", congTysTestDu);
                MessageBox.Show(danhSachCongTy);
            }
            else
            {
                MessageBox.Show("Không có công ty nào đã test đủ Y/C.");
            }
        }

        private void xuatBaoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCao frm = new frmBaoCao();
            frm.Show();
        }
    }
}
