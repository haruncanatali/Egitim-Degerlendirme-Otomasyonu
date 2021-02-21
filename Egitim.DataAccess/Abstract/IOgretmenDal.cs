using Egitim.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Egitim.DataAccess.Abstract
{
    public interface IOgretmenDal:IEntityRepository<Ogretmen>
    {
        List<Ogretmen> ListForOgretmen(Expression<Func<Ogretmen,bool>> filter = null);
        Ogretmen GetForOgretmen(Expression<Func<Ogretmen, bool>> filter);
    }
}
