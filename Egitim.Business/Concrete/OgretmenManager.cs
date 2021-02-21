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
    public class OgretmenManager : IOgretmenService
    {
        IOgretmenDal dal;

        public OgretmenManager(IOgretmenDal x)
        {
            dal = x;
        }

        public void Add(Ogretmen entity)
        {
            ValidationTool.Validate(new OgretmenValidator(), entity);
            dal.Add(entity);
        }

        public void Delete(Ogretmen entity)
        {
            dal.Delete(entity);
        }

        public Ogretmen Get(Expression<Func<Ogretmen, bool>> filter)
        {
            return dal.GetForOgretmen(filter);
        }

        public List<Ogretmen> List(Expression<Func<Ogretmen, bool>> filter = null)
        {
            return dal.ListForOgretmen(filter);
        }

        public void Update(Ogretmen entity)
        {
            ValidationTool.Validate(new OgretmenValidator(), entity);
            dal.Update(entity);
        }
    }
}
