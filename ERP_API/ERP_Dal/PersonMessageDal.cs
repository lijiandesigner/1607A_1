using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using ERP_Model;

namespace ERP_Dal
{
    /// <summary>
    /// 员工工作状态
    /// </summary>
    public class PersonMessageDal
    {
        /// <summary>
        /// 根据条件查询员工工作状态
        /// </summary>
        /// <param name="Static">工作状态</param>
        /// <returns></returns>
        public static List<WorkState> Get(bool Static)
        {
            using (EFContext Context = new EFContext())
            {
                try
                {
                    var result = (from a in Context.EmployeeInfo
                                  join b in Context.PersonMessage
                                  on a.EID equals b.EID
                                  select new WorkState()
                                  {
                                      PID = b.PID,
                                      ENo = a.ENo,
                                      EName = a.EName,
                                      PeBeginWork = b.PeBeginWork,
                                      PeEndwork = b.PeEndwork,
                                      Pstatic = b.Pstatic
                                  }).ToList();
                    return result.Where(u => u.Pstatic == Static).ToList();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// 员工工作状态修改
        /// </summary>
        /// <param name="workState"></param>
        /// <returns></returns>
        public static int Update(WorkState workState)
        {
            using (EFContext Context = new EFContext())
            {
                try
                {
                    PersonMessage work = new PersonMessage()
                    {
                        PID = workState.PID
                    };
                    PersonMessage person = Context.PersonMessage.Attach(work);
                    person.PeEndwork = workState.PeEndwork;
                    person.Pstatic = Convert.ToBoolean(0);
                    return Context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
