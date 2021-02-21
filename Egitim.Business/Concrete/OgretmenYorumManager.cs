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
    public class OgretmenYorumManager : IOgretmenYorumService
    {
        IOgretmenYorumDal dal;

        public OgretmenYorumManager(IOgretmenYorumDal dalx)
        {
            dal = dalx;
        }

        public void Add(OgretmenYorum entity)
        {
            ValidationTool.Validate(new OgretmenYorumValidator(), entity);
            dal.Add(entity);
        }

        public void Delete(OgretmenYorum entity)
        {
            dal.Delete(entity);
        }

        public OgretmenYorum Get(Expression<Func<OgretmenYorum, bool>> filter)
        {
            return dal.GetForOgretmenYorum(filter);
        }

        public List<OgretmenYorum> List(Expression<Func<OgretmenYorum, bool>> filter = null)
        {
            return dal.ListForOgretmenYorum(filter);
        }

        public void Update(OgretmenYorum entity)
        {
            ValidationTool.Validate(new OgretmenYorumValidator(), entity);
            dal.Update(entity);
        }
    }
}
