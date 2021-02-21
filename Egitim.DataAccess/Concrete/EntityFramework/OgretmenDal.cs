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
    public class OgretmenDal : EntityRepositoryBase<Ogretmen>, IOgretmenDal
    {
        EgitimDbContext context;
        public OgretmenDal(EgitimDbContext x) : base(x)
        {
            context = x;
        }

        public Ogretmen GetForOgretmen(Expression<Func<Ogretmen, bool>> filter)
        {
            return context.Ogretmen.Include(c => c.Yorumlar).FirstOrDefault(filter);
        }

        public List<Ogretmen> ListForOgretmen(Expression<Func<Ogretmen, bool>> filter = null)
        {
            return filter == null ? context.Ogretmen.Include(c => c.Yorumlar).ToList() : context.Ogretmen.Include(c => c.Yorumlar).Where(filter).ToList();
        }
    }
}
