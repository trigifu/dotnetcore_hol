using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Parsing.Structure.IntermediateModel;
using SpyStore_HOL.DAL.EF;
using SpyStore_HOL.DAL.Repos.Base;
using SpyStore_HOL.DAL.Repos.Interfaces;
using SpyStore_HOL.Models.Entities;

namespace SpyStore_HOL.DAL.Repos
{
    public class CustomerRepo : RepoBase<Customer>, ICustomerRepo
    {
        public CustomerRepo() : base()
        {
        }

        public CustomerRepo(StoreContext context) : base(context)
        {
        }

        public override IList<Customer> GetAll()
            => Table.OrderBy(x => x.FullName).ToList();

        public IEnumerable<Customer> GetRange(int skip, int take)
            => Table.OrderBy(x => x.FullName).Skip(skip).Take(take);

    }
}
