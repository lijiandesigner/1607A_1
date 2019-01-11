using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace ERP_Dal
{
    /// <summary>
    /// 月考勤信息表
    /// </summary>
    public class MonthAttenDal
    {
        /// <summary>
        /// 根据条件查询月打卡信息
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="EName">员工姓名</param>
        /// <param name="Adate">打卡日期</param>
        /// <returns></returns>
        public static List<AttendanceMonth> AttendanceMonth()
        {
            using (EFContext Context = new EFContext())
            {
                List<AttendanceMonth> infos = (from a in Context.EmployeeInfo
                                               join b in Context.MonthAtten
                                              on a.Pid equals b.EID
                                               select new AttendanceMonth
                                               {
                                                   MID = b.MID,
                                                   ENo = a.ENo,
                                                   EName = a.EName,
                                                   MAbsenteeism = b.MAbsenteeism,
                                                   MLateTime = b.MLateTime,
                                                   Adate = b.MDate
                                               }).ToList();
                return infos;
            }
        }
    }
}
