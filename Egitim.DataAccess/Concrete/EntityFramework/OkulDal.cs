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
    public class OkulDal : EntityRepositoryBase<Okul>, IOkulDal
    {
        EgitimDbContext context;
        public OkulDal(EgitimDbContext x) : base(x)
        {
            context = x;
        }

        public Okul GetForOkul(Expression<Func<Okul, bool>> filter)
        {
            return context.Okul.Include(c => c.Yorumlar).Include(c=>c.Ogretmenler).FirstOrDefault(filter);
        }

        public List<Okul> ListForOkul(Expression<Func<Okul, bool>> filter = null)
        {
            return filter == null ? context.Okul.Include(c => c.Yorumlar).Include(c => c.Ogretmenler).ToList() : context.Okul.Include(c => c.Yorumlar).Include(c => c.Ogretmenler).Where(filter).ToList();
        }
    }
}
