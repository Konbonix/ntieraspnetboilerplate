using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Abp.EntityFramework;
using VRart.Uploads;

namespace VRart.EntityFrameWork.Repositories
{
    /// <summary>
    /// Implements <see cref="ITaskRepository"/> for EntityFramework ORM.
    /// </summary>
    public class UploadRepository : VRartRepositoryBase<Upload, long>, IUploadRepository
    {
        public UploadRepository(IDbContextProvider<VRArtDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }


        public List<Upload> GetAllUploads() 
        {
            //In repository methods, we do not deal with create/dispose DB connections, DbContexes and transactions. ABP handles it.

            var query = GetAll(); //GetAll() returns IQueryable<T>, so we can query over it.
                                  //var query = Context.Tasks.AsQueryable(); //Alternatively, we can directly use EF's DbContext object.
                                  //var query = Table.AsQueryable(); //Another alternative: We can directly use 'Table' property instead of 'Context.Tasks', they are identical.

            //Add some Where conditions...

            return query.ToList();
        }
    }
}
