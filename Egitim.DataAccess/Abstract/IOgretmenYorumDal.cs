using Egitim.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Egitim.DataAccess.Abstract
{
    public interface IOgretmenYorumDal:IEntityRepository<OgretmenYorum>
    {
        List<OgretmenYorum> ListForOgretmenYorum(Expression<Func<OgretmenYorum, bool>> filter = null);
        OgretmenYorum GetForOgretmenYorum(Expression<Func<OgretmenYorum, bool>> filter);
    }
}
