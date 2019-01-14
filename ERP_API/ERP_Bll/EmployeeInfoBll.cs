using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using ERP_Dal;
using ERP_Model;

namespace ERP_Bll
{
    public class EmployeeInfoBll
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="Rpassword">密码</param>
        /// <returns></returns>
        public static LoginResult Login(string ENo, string Rpassword)
        {
            return EmployeeInfoDal.Login(ENo, Rpassword);
        }
        /// <summary>
        /// 根据条件获取员工信息
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="EName">员工姓名</param>
        /// <param name="Pstatic">工作状态</param>
        /// <returns></returns>
        public static List<EmployeeInfos> GetEmployeeInfos()
        {
            return EmployeeInfoDal.GetEmployeeInfos();
        }
        /// <summary>
        /// 根据员工ID获取单个对象
        /// </summary>
        /// <param name="id">员工id</param>
        /// <returns></returns>
        public static EmployeeInfo GetById(int id)
        {
            return EmployeeInfoDal.GetById(id);
        }
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="restInfo">员工信息对象</param>
        /// <returns></returns>
        public static int Add(string EmployeeInfoStr)
        {
            return EmployeeInfoDal.Add(EmployeeInfoStr);
        }
        /// <summary>
        /// 员工信息修改
        /// </summary>
        /// <param name="restInfo">修改后的员工信息对象</param>
        /// <returns></returns>
        public static int Update(string EmployeeInfoStr)
        {
            return EmployeeInfoDal.Update(EmployeeInfoStr);
        }
    }
}
