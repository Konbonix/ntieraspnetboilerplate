using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace VRart.EntityFramework.Repositories
{
    public abstract class VRartRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<VRartDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected VRartRepositoryBase(IDbContextProvider<VRartDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class VRartRepositoryBase<TEntity> : VRartRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected VRartRepositoryBase(IDbContextProvider<VRartDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
