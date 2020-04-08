using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindTrader.DataAccess.Abstract;
using NorthwindTrader.DataAccess.Concrete.EntityFramework.Contexts;
using NorthwindTrader.Entities.Concrete;

namespace NorthwindTrader.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
    }
}
