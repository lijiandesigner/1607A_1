using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Models;

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
            var result = from a in Context.EmployeeInfo
                         join b in Context.PositionInfo
                         on a.Pid equals b.PoID
                         join c in Context.PersonMessage
                         on a.EID equals c.EID
                         where a.ENo.Equals(ENo) && a.EcardID.Contains(Rpassword)
                         select new {
                             name=a.EName,
                             Pstatic= c.Pstatic,
                             permissins = b.Permission
                        };
            LoginResult loginResult = new LoginResult();
            if (result.Count() != 1||result.FirstOrDefault().Pstatic)
                loginResult.Result = false;
            else
            {
                loginResult.Result = true;
                loginResult.EName = result.FirstOrDefault().name.ToString();
                loginResult.Permissins = result.FirstOrDefault().permissins.ToString();
            }
            return loginResult;
        }
    }
}
