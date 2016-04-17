using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace VRart.Uploads
{
    public class Upload : Entity<long>
    {
        public virtual string Title { get; set; }
        //public DateTime Created { get; set; }
    }
}