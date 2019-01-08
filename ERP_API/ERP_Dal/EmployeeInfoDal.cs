using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Models;
using ERP_Model;
using System.Data.Entity.Infrastructure;

namespace ERP_Dal
{
    /// <summary>
    /// 员工信息表
    /// </summary>
    public class EmployeeInfoDal
    {
        /// <summary>
        ///登录
        /// </summary>
        /// <param name="ENo">员工号</param>
        /// <param name="Rpassword">密码</param>
        /// <returns></returns>
        public static LoginResult Login(string ENo, string Rpassword)
        {
            using (EFContext Context = new EFContext())
            {
                var jieguo = from s in Context.EmployeeInfo
                             select s;
                if (jieguo.FirstOrDefault() == null)
                {
                    EmployeeInfo employee = new EmployeeInfo()
                    {
                        ENo = ENo,
                        EName = "管理员",
                        Esex = true,
                        Ephone = "",
                        Eemail = "",
                        EcardID = Rpassword,
                        Ppassword = Rpassword.Substring(12),
                        Eheart = "",
                        Pid = 1
                    };
                    PositionInfo positionInfo = new PositionInfo()
                    {
                        PoName = "超级管理员",
                        PoLeave = 1,
                        PoMinMoney = 0,
                        Permission = "ALL"
                    };
                    PersonMessage personMessage = new PersonMessage()
                    {
                        EID = 1,
                        PeBeginWork = DateTime.Now.ToString(),
                        PeEndwork = "",
                        Pstatic = true
                    };
                    DbEntityEntry<EmployeeInfo> entityEntry = Context.Entry<EmployeeInfo>(employee);
                    entityEntry.State = System.Data.Entity.EntityState.Added;
                    DbEntityEntry<PositionInfo> entityEn = Context.Entry<PositionInfo>(positionInfo);
                    entityEn.State = System.Data.Entity.EntityState.Added;
                    DbEntityEntry<PersonMessage> person = Context.Entry<PersonMessage>(personMessage);
                    person.State = System.Data.Entity.EntityState.Added;
                    Context.SaveChanges();
                    Rpassword = Rpassword.Substring(12);
                }

                var result = (from a in Context.EmployeeInfo
                              join b in Context.PositionInfo
                             on a.Pid equals b.PoID
                              join c in Context.PersonMessage
                              on a.EID equals c.EID
                              where a.ENo.Equals(ENo) && a.Ppassword.Equals(Rpassword)
                              select new
                              {
                                  name = a.EName,
                                  Eid = a.EID,
                                  Pstats = c.Pstatic,
                                  PoName=b.PoName,
                                  permissins = b.Permission
                              }).ToList().FirstOrDefault();
                LoginResult loginResult = new LoginResult();
                if (result == null)
                    loginResult.Result = false;
                else
                {
                    if (result.Pstats)
                    {
                        loginResult.Result = true;
                        loginResult.EID = result.Eid;
                        loginResult.EName = result.name.ToString();
                        loginResult.PoName = result.PoName.ToString();
                        loginResult.Permissins = result.permissins.ToString();
                    }
                    else
                        loginResult.Result = false;
                }
                return loginResult;
            }
        }
        /// <summary>
        /// 根据条件获取员工信息
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="EName">员工姓名</param>
        /// <param name="Pstatic">工作状态</param>
        /// <returns></returns>
        public static List<EmployeeInfos> GetEmployeeInfos( string ENo,string EName ,bool Pstatic)
        {
            using (EFContext Context = new EFContext())
            {
                List<EmployeeInfos> infos = (from a in Context.EmployeeInfo
                                             join b in Context.PositionInfo
                                            on a.Pid equals b.PoID
                                             join c in Context.PersonMessage
                                             on a.EID equals c.EID
                                             select new EmployeeInfos
                                             {
                                                 EID = a.EID,
                                                 ENo = a.ENo,
                                                 EName = a.EName,
                                                 Esex = a.Esex,
                                                 Ephone = a.Ephone,
                                                 Eemail = a.Eemail,
                                                 EcardID = a.EcardID,
                                                 Eheart = a.Eheart,
                                                 PoName = b.PoName,
                                                 PeBeginWork = c.PeBeginWork,
                                                 PeEndwork = c.PeEndwork,
                                                 Pstatic = c.Pstatic
                                             }).Where(u => ENo == "" ? true : u.ENo == ENo).Where(u => ENo == "" ? true : u.EName == EName).Where(u => ENo == "" ? true : u.Pstatic == Pstatic).ToList();
                return infos;
            }
        }
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="restInfo">员工信息对象</param>
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
        /// 员工信息修改
        /// </summary>
        /// <param name="restInfo">修改后的员工信息对象</param>
        /// <returns></returns>
        public static int Update (RestInfo restInfo)
        {
            using (EFContext Context = new EFContext())
            {
                Context.Entry<RestInfo>(restInfo).State = System.Data.Entity.EntityState.Modified;
                return Context.SaveChanges();
            }
        }
    }
}
