using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using ERP_Model;

namespace ERP_Dal
{
    public class EFContext:DbContext
    {
        public EFContext():base("Supervisory_SystemEntities") {}
        public virtual DbSet<EmployeeInfo> EmployeeInfo { get; set; }
        public virtual DbSet<AttendanceInfo> AttendanceInfo { get; set; }
        public virtual DbSet<AttendanceType> AttendanceType { get; set; }
        public virtual DbSet<MonthAtten> MonthAtten { get; set; }
        public virtual DbSet<PersonMessage> PersonMessage { get; set; }
        public virtual DbSet<PositionInfo> PositionInfo { get; set; }
        public virtual DbSet<RestInfo> RestInfo { get; set; }
        public virtual DbSet<WagesInfo> WagesInfo { get; set; }
    }
}