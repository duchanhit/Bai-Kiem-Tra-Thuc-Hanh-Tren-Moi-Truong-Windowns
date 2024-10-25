using DAL.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    internal class CongTyService
    {
        // Lấy danh sách tất cả công ty
        public List<CONGTY> GetAllCongTys()
        {
            using (var context = new QLXetNghiemDB())
            {
                return context.CONGTY.ToList();
            }
        }

        // Lấy công ty theo mã công ty
        public CONGTY GetCongTyById(string maCty)
        {
            using (var context = new QLXetNghiemDB())
            {
                return context.CONGTY.FirstOrDefault(ct => ct.MaCty == maCty);
            }
        }

        // Thêm mới một công ty
        public void InsertCongTy(CONGTY congTy)
        {
            using (var context = new QLXetNghiemDB())
            {
                context.CONGTY.Add(congTy);
                context.SaveChanges();
            }
        }

        // Cập nhật thông tin công ty
        public void UpdateCongTy(CONGTY congTy)
        {
            using (var context = new QLXetNghiemDB())
            {
                var existingCongTy = context.CONGTY.FirstOrDefault(ct => ct.MaCty == congTy.MaCty);
                if (existingCongTy != null)
                {
                    existingCongTy.TenCty = congTy.TenCty;
                    existingCongTy.SLNV = congTy.SLNV;
                    context.SaveChanges();
                }
            }
        }

        // Xóa công ty
        public void DeleteCongTy(string maCty)
        {
            using (var context = new QLXetNghiemDB())
            {
                var congTy = context.CONGTY.FirstOrDefault(ct => ct.MaCty == maCty);
                if (congTy != null)
                {
                    context.CONGTY.Remove(congTy);
                    context.SaveChanges();
                }
            }
        }
    }
}
