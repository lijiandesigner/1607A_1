using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using ERP_Model;
using ERP_Bll;

namespace ERP_API.Controllers
{
    /// <summary>
    /// 员工信息管理
    /// </summary>
    public class EmployeeInfoController : ApiController
    {
        /// <summary>
        /// 根据条件获取员工信息
        /// </summary>
        /// <param name="ENo">员工编号</param>
        /// <param name="EName">员工姓名</param>
        /// <param name="Pstatic">工作状态</param>
        /// <returns></returns>
        public List<EmployeeInfos> Get(bool Pstatic, string ENo = null, string EName = null)
        {
            return EmployeeInfoBll.GetEmployeeInfos(ENo, EName, Pstatic);
        }
        /// <summary>
        /// 根据员工ID获取单个对象
        /// </summary>
        /// <param name="id">员工id</param>
        /// <returns></returns>
        public  EmployeeInfo Get(int id)
        {
            return EmployeeInfoBll.GetById(id);
        }
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="restInfo">员工信息对象</param>
        /// <returns></returns>
        public  int Post([FromBody]string EmployeeInfoStr)
        {
            return EmployeeInfoBll.Add(EmployeeInfoStr);
        }
        /// <summary>
        /// 员工信息修改
        /// </summary>
        /// <param name="restInfo">修改后的员工信息对象</param>
        /// <returns></returns>
        public  int Put([FromBody]string EmployeeInfoStr)
        {
            return EmployeeInfoBll.Update(EmployeeInfoStr);
        }
    }
}
