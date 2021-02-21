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
    public class OgretmenYorumDal : EntityRepositoryBase<OgretmenYorum>, IOgretmenYorumDal
    {
        EgitimDbContext context;
        public OgretmenYorumDal(EgitimDbContext x) : base(x)
        {
            context = x;
        }

        public OgretmenYorum GetForOgretmenYorum(Expression<Func<OgretmenYorum, bool>> filter)
        {
            return context.OgretmenYorum.Include(c => c.Ogretmeni).FirstOrDefault(filter);
        }

        public List<OgretmenYorum> ListForOgretmenYorum(Expression<Func<OgretmenYorum, bool>> filter = null)
        {
            return filter == null ? context.OgretmenYorum.Include(c => c.Ogretmeni).ToList() : context.OgretmenYorum.Include(c => c.Ogretmeni).Where(filter).ToList();
        }
    }
}
