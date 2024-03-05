
using dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll
{
    public class TinTuc_dal
    {
        public TinTuc_dal()
        {
           
        }

        public List<TinTuc_dto> select_NT(string maNT)
        {
            List<TinTuc_dto> resultList = (from item in Main._db.TINTUCs
                                       select new TinTuc_dto
                                       {
                                           MaTT = item.MaTT,
                                           MaNT = item.MaNT,
                                           TieuDe = item.TieuDe,
                                           NoiDungTT = item.NoiDungTT,
                                           MoTa = item.MoTa,
                                           ThoiGian = (DateTime)item.Thoigian,
                                           HinhAnh = item.HinhAnh,
                                           MaNV = item.MaNV,
                                       }).Where(t => t.MaNT.Equals(maNT)).ToList();
            return resultList;
        }
        public List<TinTuc_dto> select()
        {
            List<TinTuc_dto> resultList = (from item in Main._db.TINTUCs
                                       select new TinTuc_dto
                                       {
                                           MaTT = item.MaTT,
                                           MaNT = item.MaNT,
                                           TieuDe = item.TieuDe,
                                           NoiDungTT = item.NoiDungTT,
                                           MoTa = item.MoTa,
                                           ThoiGian = (DateTime)item.Thoigian,
                                           HinhAnh = item.HinhAnh,
                                           MaNV = item.MaNV,
                                       }).ToList();
            return resultList;
        }
        public int insert(TinTuc_dto tt)
        {
            try
            {
                TINTUC tINTUC = new TINTUC();
                tINTUC.MaTT = tt.MaTT;
                tINTUC.MaNT = tt.MaNT;
                tINTUC.TieuDe = tt.TieuDe;
                tINTUC.NoiDungTT = tt.NoiDungTT;
                tINTUC.MoTa = tt.MoTa;
                tINTUC.HinhAnh = tt.HinhAnh;
                tINTUC.MaNV = tt.MaNV;
                tINTUC.TinhTrang = tt.TinhTrang;
                tINTUC.Thoigian = tt.ThoiGian;
                Main._db.TINTUCs.InsertOnSubmit(tINTUC);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int delete(string matt)
        {
            try
            {
                TINTUC tINTUC = Main._db.TINTUCs.SingleOrDefault(t => t.MaTT == matt);
                Main._db.TINTUCs.DeleteOnSubmit(tINTUC);
                Main._db.SubmitChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int update(TinTuc_dto tt)
        {
            try
            {
                TINTUC tINTUC = new TINTUC();
                TINTUC entityToUpdate = Main._db.TINTUCs.SingleOrDefault(e => e.MaTT == tt.MaTT);
                if (entityToUpdate != null)
                {
                    entityToUpdate.MaTT = tt.MaTT;
                    entityToUpdate.MaNT = tt.MaNT;
                    entityToUpdate.TieuDe = tt.TieuDe;
                    entityToUpdate.NoiDungTT = tt.NoiDungTT;
                    entityToUpdate.TinhTrang = tt.TinhTrang;
                    entityToUpdate.MoTa = tt.MoTa;
                    entityToUpdate.HinhAnh = tt.HinhAnh;
                    entityToUpdate.Thoigian = tt.ThoiGian;
                    Main._db.SubmitChanges();

                    return 1;
                }
                return 0;
            }catch (Exception ex)
            {
                return -1;
            }
        }
        public int update_tinhtrang(string matt, bool tinhtrang)
        {
            try
            {
                TINTUC tINTUC = new TINTUC();
                TINTUC entityToUpdate = Main._db.TINTUCs.SingleOrDefault(e => e.MaTT == matt);
                if (entityToUpdate != null)
                {
                    entityToUpdate.TinhTrang = tinhtrang;
                    Main._db.SubmitChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
