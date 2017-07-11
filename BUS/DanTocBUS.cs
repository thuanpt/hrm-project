using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class DanTocBUS
    {
        QuanLyNhanSuDataContext DB = new QuanLyNhanSuDataContext();
        public IEnumerable<DanToc> viewDanToc()
        {
            IEnumerable<DanToc> dantoc = from dt in DB.DanTocs
                                         select dt;
            return dantoc;
        }
        public bool KTTonTai(string madt)
        {
            int kt = (from dt in DB.DanTocs
                      where dt.MaDanToc == madt
                      select dt
                      ).Count();

            if (kt == 1)
                return true;
            else
                return false;
        }
        public void ThemDanToc(string madt, string tendt)
        {
            DanToc themdantoc = new DanToc();
            themdantoc.MaDanToc = madt;
            themdantoc.TenDanToc = tendt;
            DB.DanTocs.InsertOnSubmit(themdantoc);
            DB.SubmitChanges();
        }
        public void SuaDanToc(string madt, string tendt)
        {
            DanToc suadantoc = (from dt in DB.DanTocs
                                select dt).Single(t => t.MaDanToc == madt);

            suadantoc.TenDanToc = tendt;
            DB.SubmitChanges();

        }
        public void XoaDanToc(string madt)
        {
            DanToc xoadantoc = (from dt in DB.DanTocs
                                select dt).Single(t => t.MaDanToc == madt);
            DB.DanTocs.DeleteOnSubmit(xoadantoc);
            DB.SubmitChanges();
        }
    }
}
