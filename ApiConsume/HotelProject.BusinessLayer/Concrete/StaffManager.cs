using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class StaffManager : IStaffService
    {
        private readonly IStaffDal _staffDal;
        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }
        public void TDelete(Staff t)
        {
            _staffDal.Delete(t);
        }

        public Staff TGetByID(int id)
        {
            return _staffDal.GetByID(id);
        }

        public List<Staff> TGetList()
        {
            return _staffDal.GetList();
        }

        public int TGetStaffCount()
        {
            return _staffDal.GetStaffCount();
        }

        public void TInsert(Staff t)
        {
            _staffDal.Insert(t);
        }

        public List<Staff> TLast4Staff()
        {
            return _staffDal.Last4Staff();
        }

        public void TUpdate(Staff t)
        {
            _staffDal.Update(t);
        }
    }
}
