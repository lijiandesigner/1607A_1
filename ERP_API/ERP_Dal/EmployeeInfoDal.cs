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
        public static LoginResult Login(string ENo, string Rpassword)
        {
            EFContext Context = new EFContext();
            var jieguo = from s in Context.EmployeeInfo
                         select s;
            if(jieguo.FirstOrDefault()==null)
            {
                EmployeeInfo employee = new EmployeeInfo()
                {
                    ENo = ENo,
                    EName = "管理员",
                    Esex = true,
                    Ephone = "",
                    Eemail = "",
                    EcardID = Rpassword,
                    Password = Rpassword.Substring(12),
                    Eheart = "",
                    Pid = 1
                };
                PositionInfo positionInfo = new PositionInfo()
                {
                    PoName = "超级管理员",
                    PoLeave = 1,
                    PoMinMoney = 0,
                    Permission = "abcdefghijk"
                };
                DbEntityEntry<EmployeeInfo> entityEntry = Context.Entry<EmployeeInfo>(employee);
                entityEntry.State = System.Data.Entity.EntityState.Added;
                DbEntityEntry<PositionInfo> entityEn = Context.Entry<PositionInfo>(positionInfo);
                entityEn.State = System.Data.Entity.EntityState.Added;
                Context.SaveChanges();
            }

            var result = (from a in Context.EmployeeInfo
                         join b in Context.PositionInfo
                         on a.Pid equals b.PoID
                         join c in Context.PersonMessage
                         on a.EID equals c.EID
                         where a.ENo.Equals(ENo) && a.Password.Equals(Rpassword.Substring(12))
                         select new
                         {
                             name = a.EName,
                             Eid=a.EID,
                             Pstats = c.Pstatic,
                             permissins = b.Permission
                         }).ToList();
            LoginResult loginResult = new LoginResult();
            if (result.Count() != 1||result.FirstOrDefault().Pstats)
                loginResult.Result = false;
            else
            {
                loginResult.Result = true;
                loginResult.EID = result.FirstOrDefault().Eid;
                loginResult.EName = result.FirstOrDefault().name.ToString();
                loginResult.Permissins = result.FirstOrDefault().permissins.ToString();
            }
            return loginResult;
        }
    }
}
