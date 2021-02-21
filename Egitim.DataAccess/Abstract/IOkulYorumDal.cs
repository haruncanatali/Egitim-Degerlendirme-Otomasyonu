using Egitim.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Egitim.DataAccess.Abstract
{
    public interface IOkulYorumDal:IEntityRepository<OkulYorum>
    {
        List<OkulYorum> ListForOkulYorum(Expression<Func<OkulYorum, bool>> filter = null);
        OkulYorum GetForOkulYorum(Expression<Func<OkulYorum, bool>> filter);
    }
}
