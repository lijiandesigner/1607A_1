using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using ERP_Model;
using System.Data.Entity.Infrastructure;

namespace ERP_Dal
{
    /// <summary>
    /// 请假信息表
    /// </summary>
    public class RestInfoDal
    {
        /// <summary>
        /// 根据条件获取所有匹配的请假信息
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="Type">请假类型</param>
        /// <returns></returns>
        public static List<LeaveInfo> GetAllPositionInfo(string ENo, string Type)
        {
            using (EFContext Context = new EFContext())
            {
                List<LeaveInfo> positionInfos = (from a in Context.EmployeeInfo
                                                 join b in Context.PositionInfo
                                                on a.Pid equals b.PoID
                                                 join c in Context.RestInfo
                                                 on a.EID equals c.EID
                                                 where a.ENo.Equals(ENo) && c.Rtype.Equals(Type)
                                                 select new LeaveInfo
                                                 {

                                                     EID = a.EID,
                                                     EName = a.EName,
                                                     PoName = b.PoName,
                                                     Rtype = c.Rtype,
                                                     RBeginTime = c.RBeginTime,
                                                     REndTime = c.REndTime,
                                                     RemarkInfo = c.RemarkInfo,
                                                     ReAuditTime = c.ReAuditTime,
                                                     Restatic = c.Restatic,
                                                     Remark = c.Remark

                                                 }).ToList();
                return positionInfos;
            }
        }
        /// <summary>
        /// 添加请假信息
        /// </summary>
        /// <param name="restInfo">请假信息对象</param>
        /// <returns></returns>
        public static int Add(RestInfo restInfo)
        {
            using (EFContext Context = new EFContext())
            {
                DbEntityEntry<RestInfo> person = Context.Entry<RestInfo>(restInfo);
                person.State = System.Data.Entity.EntityState.Added;
                return Context.SaveChanges();
            }
        }
        /// <summary>
        /// 请假信息审批
        /// </summary>
        /// <param name="RID">信息id</param>
        /// <param name="ReAuditTime">审批时间</param>
        /// <returns></returns>
        public static int Update(int RID, string ReAuditTime)
        {
            using (EFContext Context = new EFContext())
            {
                RestInfo restInfo = new RestInfo()
                {
                    RID = RID
                };
                RestInfo a = Context.RestInfo.Attach(restInfo);
                a.ReAuditTime = ReAuditTime;
                return Context.SaveChanges();
            }
        }
    }
}
