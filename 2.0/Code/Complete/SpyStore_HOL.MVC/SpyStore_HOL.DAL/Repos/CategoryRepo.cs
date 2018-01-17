using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SpyStore_HOL.DAL.EF;
using SpyStore_HOL.DAL.Repos.Base;
using SpyStore_HOL.DAL.Repos.Interfaces;
using SpyStore_HOL.Models.Entities;

namespace SpyStore_HOL.DAL.Repos
{
    public class CategoryRepo : RepoBase<Category>, ICategoryRepo
    {
        public CategoryRepo()
        {
        }
        public CategoryRepo(StoreContext context):base(context)
        {
        }
        public override IList<Category> GetAll() 
            => Table.OrderBy(x => x.CategoryName).ToList();

        public IEnumerable<Category> GetRange(int skip, int take) 
            => Table.OrderBy(x => x.CategoryName).Skip(skip).Take(take);
    }
}