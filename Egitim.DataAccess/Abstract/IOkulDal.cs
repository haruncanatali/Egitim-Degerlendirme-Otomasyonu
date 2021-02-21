using Egitim.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Egitim.DataAccess.Abstract
{
    public interface IOkulDal:IEntityRepository<Okul>
    {
        List<Okul> ListForOkul(Expression<Func<Okul, bool>> filter = null);
        Okul GetForOkul(Expression<Func<Okul, bool>> filter);
    }
}
