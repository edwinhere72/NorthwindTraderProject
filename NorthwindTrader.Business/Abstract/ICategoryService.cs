using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindTrader.Entities.Concrete;

namespace NorthwindTrader.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
