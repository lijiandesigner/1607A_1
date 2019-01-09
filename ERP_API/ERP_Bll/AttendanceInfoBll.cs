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
        public static int Get(int EID, string AttendanceTime)
        {
            return AttendanceInfoDal.Get(EID, AttendanceTime);
        }
    }
}
