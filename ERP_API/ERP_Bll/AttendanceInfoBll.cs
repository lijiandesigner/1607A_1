using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_Dal;
using System.Data;
using Models;

namespace ERP_Bll
{
    public class AttendanceInfoBll
    {
        /// <summary>
        /// 打卡
        /// </summary>
        /// <param name="EID">员工id</param>
        /// <param name="AttendanceTime">打卡时间</param>
        /// <returns></returns>
        public static int DK(int EID, string AttendanceTime)
        {
            return AttendanceInfoDal.DK(EID, AttendanceTime);
        }
        /// <summary>
        /// 根据条件查询日打卡信息
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="EName">员工姓名</param>
        /// <param name="Adate">打卡日期</param>
        /// <returns></returns>
        public static List<AttendanceDay> AttendanceDays(string ENo, string EName, string Adate)
        {
            return AttendanceInfoDal.AttendanceDays(ENo, EName, Adate);
        }
    }
}
