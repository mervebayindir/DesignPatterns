﻿using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.UnitOfWork;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public CustomerManager(IUnitOfWorkDal unitOfWorkDal, ICustomerDal customerDal)
        {
            _unitOfWorkDal = unitOfWorkDal;
            _customerDal = customerDal;
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
            _unitOfWorkDal.Save();
        }

        public Customer TGetByID(int id)
        {
            return _customerDal.GetByID(id);
        }

        public List<Customer> TGetLİst()
        {
            return _customerDal.GetLİst();
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
            _unitOfWorkDal.Save();
        }

        public void TMultiUpdate(List<Customer> t)
        {
            _customerDal.MultiUpdate(t);
            _unitOfWorkDal.Save();
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
            _unitOfWorkDal.Save();
        }
    }
}
