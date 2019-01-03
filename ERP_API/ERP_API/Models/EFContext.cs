using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ERP_Model;

namespace ERP_API.Models
{
    public class EFContext:DbContext
    {
        public EFContext():base("Supervisory_SystemEntities") {}
        public virtual DbSet<EmployeeInfo> MyProperty { get; set; }
    }
}