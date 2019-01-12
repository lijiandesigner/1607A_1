using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_Model;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace ERP_Dal
{
    /// <summary>
    /// 日考勤信息表
    /// </summary>
    public class AttendanceInfoDal
    {
        /// <summary>
        /// 打卡
        /// </summary>
        /// <param name="EID">员工id</param>
        /// <param name="AttendanceTime">打卡时间</param>
        /// <returns></returns>
        public static int DK(int EID, string AttendanceTime)
        {
            using (EFContext Context = new EFContext())
            {
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0]= new SqlParameter("@EID",EID );
                parameters[1] = new SqlParameter("@AttendanceTime", AttendanceTime);
                parameters[2] = new SqlParameter("@Result", SqlDbType.Int);
                parameters[2].Direction = ParameterDirection.Output;
                var articles = Context.Database.SqlQuery(typeof(int), "exec prco_DaKa @EID,@AttendanceTime,@Result out", parameters);
                
                return (int)parameters[2].Value;
            }
        }
        /// <summary>
        /// 根据条件查询日打卡信息
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="EName">员工姓名</param>
        /// <param name="Adate">打卡日期</param>
        /// <returns></returns>
        public static List<AttendanceDay> AttendanceDays(string ENo,string EName,string Adate)
        {
            using (EFContext Context = new EFContext())
            {
                List<AttendanceDay> infos = (from a in Context.EmployeeInfo
                                             join b in Context.AttendanceInfo
                                            on a.Pid equals b.EID
                                             select new AttendanceDay
                                             {
                                                 AID=b.AID,
                                                 ENo=a.ENo,
                                                 EName=a.EName,
                                                 AMBeginTime=b.AMBeginTime,
                                                 AMEndTime=b.AMEndTime,
                                                 AABeginTime=b.AABeginTime,
                                                 AAEndTime=b.AAEndTime,
                                                 ABeLateTime=b.ABeLateTime,
                                                 ALeaveTime=b.ALeaveTime,
                                                 AStatic=b.AStatic,
                                                 Adate=b.Adate
                                             }).Where(u => ENo == "" ? true : u.ENo == ENo).Where(u => EName == "" ? true : u.EName ==EName).Where(u => ENo == "" ? true : u.Adate == Adate).ToList();
                return infos;
            }
        }
        
    }
}
