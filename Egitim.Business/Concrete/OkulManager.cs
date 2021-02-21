using Egitim.Business.Abstract;
using Egitim.Business.FluentValidation;
using Egitim.DataAccess.Abstract;
using Egitim.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Egitim.Business.Concrete
{
    public class OkulManager : IOkulService
    {
        IOkulDal dal;
        public OkulManager(IOkulDal x)
        {
            dal = x;
        }
        public void Add(Okul entity)
        {
            ValidationTool.Validate(new OkulValidator(), entity);
            dal.Add(entity);
        }

        public void Delete(Okul entity)
        {
            dal.Delete(entity);
        }

        public Okul Get(Expression<Func<Okul, bool>> filter)
        {
            return dal.GetForOkul(filter);
        }

        public List<Okul> List(Expression<Func<Okul, bool>> filter = null)
        {
            return dal.ListForOkul(filter);
        }

        public void Update(Okul entity)
        {
            ValidationTool.Validate(new OkulValidator(), entity);
            dal.Update(entity);
        }
    }
}
