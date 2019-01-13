using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_Dal;
using Models;

namespace ERP_Bll
{
    public class WagesInfoBll
    {
        /// <summary>
        /// 根据条件查询员工工资
        /// </summary>
        /// <returns></returns>
        public static List<GZ> GetGZs()
        {
            return WagesInfoDal.GetGZs();
        }
        /// <summary>
        /// 生成本月工资记录
        /// </summary>
        /// <returns></returns>
        public static int CreateGZ(string Date)
        {
            return WagesInfoDal.CreateGZ(Date);
        }
    }
}
