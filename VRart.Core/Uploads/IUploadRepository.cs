using System.Collections.Generic;
using Abp.Domain.Repositories;

namespace VRart.Uploads
{
    public interface IUploadRepository : IRepository<Upload, long>
    {
        List<Upload> GetAllUploads(); 
    }
}
