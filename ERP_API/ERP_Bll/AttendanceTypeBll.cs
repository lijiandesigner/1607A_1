using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_Model;
using ERP_Dal;

namespace ERP_Bll
{
    public class AttendanceTypeBll
    {
        /// <summary>
        /// 获取考勤规则
        /// </summary>
        /// <returns></returns>
        public static AttendanceType GetOne()
        {
            return AttendanceTypeDal.GetOne();
        }
        /// <summary>
        /// 添加考勤规则
        /// </summary>
        /// <param name="attendanceType"></param>
        /// <returns></returns>
        public static int Add(AttendanceType attendanceType)
        {
            return AttendanceTypeDal.Add(attendanceType);
        }
        /// <summary>
        /// 修改考勤规则
        /// </summary>
        /// <param name="attendanceType"></param>
        /// <returns></returns>
        public static int Update(AttendanceType attendanceType)
        {
            return AttendanceTypeDal.Update(attendanceType);
        }
    }
}
