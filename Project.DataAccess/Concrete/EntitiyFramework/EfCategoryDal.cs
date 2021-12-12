using Project.DataAccess.Abstract;
using Project.DataAccess.Concrete.EntityFramework;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess.Concrete.EntitiyFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext> ,ICategoryDal
    {
    }
}
