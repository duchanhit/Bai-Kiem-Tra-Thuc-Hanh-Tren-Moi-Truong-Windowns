using DAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    internal class NhanVienService
    {
        // Lấy danh sách tất cả nhân viên
        public List<NHANVIEN> GetAllNhanViens()
        {
            using (var context = new QLXetNghiemDB())
            {
                return context.NHANVIEN.Include("CONGTY").ToList(); // Include CONGTY để lấy thông tin công ty
            }
        }

        // Lấy nhân viên theo ID
        public NHANVIEN GetNhanVienById(string id)
        {
            using (var context = new QLXetNghiemDB())
            {
                return context.NHANVIEN.Include("CONGTY").FirstOrDefault(nv => nv.ID == id);
            }
        }

        // Thêm mới một nhân viên
        public void InsertNhanVien(NHANVIEN nv)
        {
            using (var context = new QLXetNghiemDB())
            {
                context.NHANVIEN.Add(nv);
                context.SaveChanges();
            }
        }

        // Cập nhật thông tin nhân viên
        public void UpdateNhanVien(NHANVIEN nv)
        {
            using (var context = new QLXetNghiemDB())
            {
                var existingNhanVien = context.NHANVIEN.FirstOrDefault(x => x.ID == nv.ID);
                if (existingNhanVien != null)
                {
                    existingNhanVien.HoTen = nv.HoTen;
                    existingNhanVien.SoLanXN = nv.SoLanXN;
                    existingNhanVien.AmTinh = nv.AmTinh;
                    existingNhanVien.MaCty = nv.MaCty;
                    context.SaveChanges();
                }
            }
        }

        // Xóa nhân viên
        public void DeleteNhanVien(string id)
        {
            using (var context = new QLXetNghiemDB())
            {
                var nhanVien = context.NHANVIEN.FirstOrDefault(nv => nv.ID == id);
                if (nhanVien != null)
                {
                    context.NHANVIEN.Remove(nhanVien);
                    context.SaveChanges();
                }
            }
        }

    }
}
