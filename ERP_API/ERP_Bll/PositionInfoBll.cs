using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_Model;
using ERP_Dal;

namespace ERP_Bll
{
    public class PositionInfoBll
    {
        /// <summary>
        /// 获取所有职位信息
        /// </summary>
        /// <returns></returns>
        public static List<PositionInfo> GetAllPositionInfo()
        {
            return PositionInfoDal.GetAllPositionInfo();
        }
        /// <summary>
        /// 根据职位id查询单条职位信息
        /// </summary>
        /// <param name="id">职位id</param>
        /// <returns></returns>
        public static PositionInfo GetById(int id)
        {
            return PositionInfoDal.GetById(id);
        }
        /// <summary>
        /// 职位添加
        /// </summary>
        /// <param name="positionInfo"></param>
        /// <returns></returns>
        public static int Add(string positionInfoStr)
        {
            return PositionInfoDal.Add(positionInfoStr);
        }
        /// <summary>
        /// 职位修改
        /// </summary>
        /// <param name="positionInfo"></param>
        /// <returns></returns>
        public static int Update(PositionInfo positionInfo)
        {
            return PositionInfoDal.Update(positionInfo);
        }
        /// <summary>
        /// 根据id删除职位信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int DeleteById(int id)
        {
            return PositionInfoDal.DeleteById(id);
        }
    }
}
