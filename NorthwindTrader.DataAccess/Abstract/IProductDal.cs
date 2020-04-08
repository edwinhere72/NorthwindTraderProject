using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindTrader.Entities.ComplexTypes;
using NorthwindTrader.Entities.Concrete;

namespace NorthwindTrader.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();

        int GetProductsCountByCategory();
    }
}
