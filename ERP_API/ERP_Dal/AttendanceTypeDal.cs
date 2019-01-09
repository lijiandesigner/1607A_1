using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_Model;

namespace ERP_Dal
{
    /// <summary>
    /// 考勤规则表
    /// </summary>
    public class AttendanceTypeDal
    {
        /// <summary>
        /// 获取考勤规则
        /// </summary>
        /// <returns></returns>
        public static AttendanceType GetOne()
        {
            using (EFContext Context = new EFContext())
            {
                return (from a in Context.AttendanceType
                        select a).FirstOrDefault<AttendanceType>();
            }
        }
        /// <summary>
        /// 添加考勤规则
        /// </summary>
        /// <param name="attendanceType"></param>
        /// <returns></returns>
        public static int Add(AttendanceType attendanceType)
        {
            using (EFContext Context = new EFContext())
            {
                DbEntityEntry<AttendanceType> person = Context.Entry<AttendanceType>(attendanceType);
                person.State = System.Data.Entity.EntityState.Added;
                return Context.SaveChanges();
            }
        }
        /// <summary>
        /// 修改考勤规则
        /// </summary>
        /// <param name="attendanceType"></param>
        /// <returns></returns>
        public static int Update(AttendanceType attendanceType)
        {
            using (EFContext Context = new EFContext())
            {
                AttendanceType type = new AttendanceType()
                {
                    ATID = attendanceType.ATID
                };
                AttendanceType a = Context.AttendanceType.Attach(type);
                a.MBeginTime = attendanceType.MBeginTime;
                a.MEndTime = attendanceType.MEndTime;
                a.ABeginTime = attendanceType.ABeginTime;
                a.AEndTime = attendanceType.AEndTime;
                a.Remark = attendanceType.Remark;
                return Context.SaveChanges();
            }
        }
    }
}
