using Egitim.DataAccess.Abstract;
using Egitim.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Egitim.DataAccess.Concrete.EntityFramework
{
    public class OkulYorumDal : EntityRepositoryBase<OkulYorum>, IOkulYorumDal
    {
        EgitimDbContext context;
        public OkulYorumDal(EgitimDbContext x) : base(x)
        {
            context = x;
        }

        public OkulYorum GetForOkulYorum(Expression<Func<OkulYorum, bool>> filter)
        {
            return context.OkulYorum.Include(c => c.Okulu).FirstOrDefault(filter);
        }

        public List<OkulYorum> ListForOkulYorum(Expression<Func<OkulYorum, bool>> filter = null)
        {
            return filter == null ? context.OkulYorum.Include(c => c.Okulu).ToList() : context.OkulYorum.Include(c => c.Okulu).Where(filter).ToList();
        }
    }
}
