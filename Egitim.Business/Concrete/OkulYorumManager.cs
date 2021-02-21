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
    public class OkulYorumManager : IOkulYorumService
    {
        IOkulYorumDal dal;
        public OkulYorumManager(IOkulYorumDal x)
        {
            dal = x;
        }

        public void Add(OkulYorum entity)
        {
            ValidationTool.Validate(new OkulYorumValidator(), entity);
            dal.Add(entity);
        }

        public void Delete(OkulYorum entity)
        {
            dal.Delete(entity);
        }

        public OkulYorum Get(Expression<Func<OkulYorum, bool>> filter)
        {
            return dal.GetForOkulYorum(filter);
        }

        public List<OkulYorum> List(Expression<Func<OkulYorum, bool>> filter = null)
        {
            return dal.ListForOkulYorum(filter);
        }

        public void Update(OkulYorum entity)
        {
            ValidationTool.Validate(new OkulYorumValidator(), entity);
            dal.Update(entity);
        }
    }
}
