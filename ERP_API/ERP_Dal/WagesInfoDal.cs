using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using ERP_Model;
using System.Data.SqlClient;
using System.Data;

namespace ERP_Dal
{
    /// <summary>
    /// 工资信息表
    /// </summary>
    public class WagesInfoDal
    {
        /// <summary>
        /// 根据条件查询员工工资
        /// </summary>
        /// <returns></returns>
        public static List<GZ> GetGZs()
        {
            using (EFContext Context = new EFContext())
            {
                try
                {
                    var result = (from a in Context.EmployeeInfo
                                  join b in Context.PersonMessage
                                  on a.EID equals b.EID
                                  join c in Context.WagesInfo
                                  on a.EID equals c.EID
                                  select new GZ()
                                  {
                                      WID = c.WID,
                                      ENo = a.ENo,
                                      EName = a.EName,
                                      WDudectionMoney=c.WDudectionMoney,
                                      WShouldMoney=c.WShouldMoney,
                                      CreateDate=c.CreateDate,
                                      Pstatic = b.Pstatic
                                  }).ToList();
                    return result.ToList();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// 生成本月工资记录
        /// </summary>
        /// <returns></returns>
        public  static int CreateGZ(string Date)
        {
            using (EFContext Context = new EFContext())
            {
                //var articles = Context.Database.SqlQuery(typeof(int), "exec [USP_GetPagedArticleList]", null);
                return 1;
            }
        }

    }
}
