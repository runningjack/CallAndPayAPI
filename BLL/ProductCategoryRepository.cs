using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductCategoryRepository : BaseRepository<ProductCategory>
    {
        public IEnumerable<ProductCategoryViewModel> ListProductCategories()
        {
            IQueryable<ProductCategory> productCategories = GetAll();
            IQueryable<ProductCategoryViewModel> allCategories = from c in productCategories
                                                                select new ProductCategoryViewModel()
                                                         {
                                                             Id = c.Id,
                                                             ProductCode = c.ProductCode,
                                                             ProductName = c.ProductName,
                                                             Description = c.Description,
                                                             CreatedAt = c.CreatedAt,
                                                             UpdatedAt = c.UpdatedAt,
                                                             CreatedBy = c.CreatedBy,
                                                         };
            return allCategories;
        }

        public ProductCategory FindById(int id)
        {
            return GetById(id);
        }

        public int Create(ProductCategory productCategory)
        {
            return Insert(productCategory);
        }

        public int Update(ProductCategory productCategory)
        {
            return Update(productCategory);
        }
    }
}
