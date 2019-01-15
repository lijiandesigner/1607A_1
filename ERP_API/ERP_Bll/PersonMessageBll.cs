using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_Dal;
using Models;

namespace ERP_Bll
{
    public class PersonMessageBll
    {
        /// <summary>
        /// 根据条件查询员工工作状态
        /// </summary>
        /// <param name="Static">工作状态</param>
        /// <returns></returns>
        public static List<WorkState> Get(bool Static)
        {
            return PersonMessageDal.Get(Static);
        }
        /// <summary>
        /// 员工工作状态修改
        /// </summary>
        /// <param name="workState"></param>
        /// <returns></returns>
        public static int Update(WorkState workState)
        {
            return PersonMessageDal.Update(workState);
        }
    }
}
