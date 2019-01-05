using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ERP_Model;
using ERP_Bll;

namespace ERP_API.Controllers
{
    public class APIpositionController : ApiController
    {
        //职位管理
        /// <summary>
        /// 获取所有职位信息
        /// </summary>
        /// <returns></returns>
        public static List<PositionInfo> Get()
        {
            return PositionInfoBll.GetAllPositionInfo();
        }
        /// <summary>
        /// 根据职位id查询单条职位信息
        /// </summary>
        /// <param name="id">职位id</param>
        /// <returns></returns>
        public static PositionInfo Get(int id)
        {
            return PositionInfoBll.GetById(id);
        }
        /// <summary>
        /// 职位添加
        /// </summary>
        /// <param name="positionInfo"></param>
        /// <returns></returns>
        public static int Post(PositionInfo positionInfo)
        {
            return PositionInfoBll.Add(positionInfo);
        }
        /// <summary>
        /// 职位修改
        /// </summary>
        /// <param name="positionInfo"></param>
        /// <returns></returns>
        public static int Update(PositionInfo positionInfo)
        {
            return PositionInfoBll.Update(positionInfo);
        }
        /// <summary>
        /// 根据id删除职位信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int Delete(int id)
        {
            return PositionInfoBll.DeleteById(id);
        }

    }
}
