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
        /// <param name="ENo">员工编号</param>
        /// <param name="EName">员工姓名</param>
        /// <param name="date">日期</param>
        /// <param name="Static">工作状态</param>
        /// <returns></returns>
        public List<GZ> GetGZs(string ENo, string EName,string Date, string Static)
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
                    return result.Where(u => ENo == null ? true : u.ENo == ENo).Where(u => EName == null ? true : u.EName == EName).Where(u =>  Date== null ? true : u.CreateDate == Date).Where(u => Static == null ? true : u.Pstatic == Convert.ToBoolean(Static)).ToList();
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
        public  static int CreateGZ()
        {
            using (EFContext Context = new EFContext())
            {
                var articles = Context.Database.SqlQuery(typeof(int), "exec [USP_GetPagedArticleList]", null);
                return 1;
            }
        }

    }
}
