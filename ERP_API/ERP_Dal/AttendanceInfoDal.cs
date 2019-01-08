using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_Model;
using System.Data;
using System.Data.SqlClient;

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
        public int Get(int EID, string AttendanceTime)
        {
            using (EFContext Context = new EFContext())
            {
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0]= new SqlParameter("@EID",EID );
                parameters[1] = new SqlParameter("@AttendanceTime", AttendanceTime);
                parameters[2] = new SqlParameter("@Result", SqlDbType.Int);
                parameters[2].Direction = ParameterDirection.Output;
                var articles = Context.Database.SqlQuery(typeof(int),"exec [USP_GetPagedArticleList] @startIndex,@endIndex,@totalItems out",parameters);
                
                return (int)parameters[2].Value;
            }
        }
    }
}
