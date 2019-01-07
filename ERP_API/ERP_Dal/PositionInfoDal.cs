using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP_Model;
using Models;

namespace ERP_Dal
{
    /// <summary>
    /// 职位表管理
    /// </summary>
    public class PositionInfoDal
    {
        /// <summary>
        /// 获取所有职位信息
        /// </summary>
        /// <returns></returns>
        public static List<PositionInfo> GetAllPositionInfo()
        {
            using (EFContext Context = new EFContext())
            {
                List<PositionInfo> positionInfos = (from s in Context.PositionInfo
                                                    select s).ToList();
                return positionInfos;
            }
        }
        /// <summary>
        /// 根据职位id查询单条职位信息
        /// </summary>
        /// <param name="id">职位id</param>
        /// <returns></returns>
        public static PositionInfo GetById(int id)
        {
            using (EFContext Context = new EFContext())
            {
                PositionInfo position = (from s in Context.PositionInfo
                                         where s.PoID.Equals(id)
                                         select s).ToList().FirstOrDefault();
                return position;
            }
        }
        /// <summary>
        /// 职位添加
        /// </summary>
        /// <param name="positionInfo"></param>
        /// <returns></returns>
        public static int Add(PositionInfo positionInfo)
        {
            using (EFContext Context = new EFContext())
            {
                DbEntityEntry<PositionInfo> entityEntry = Context.Entry<PositionInfo>(positionInfo);
                entityEntry.State = System.Data.Entity.EntityState.Added;
                int result= Context.SaveChanges();
                return result;
            }
        }
        /// <summary>
        /// 职位修改
        /// </summary>
        /// <param name="positionInfo"></param>
        /// <returns></returns>
        public static int Update(PositionInfo positionInfo)
        {
            using (EFContext Context = new EFContext())
            {
                Context.Entry<PositionInfo>(positionInfo).State = System.Data.Entity.EntityState.Modified;
                int result = Context.SaveChanges();
                return result;
            }
        }
        /// <summary>
        /// 根据id删除职位信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int DeleteById(int id)
        {
            using (EFContext Context = new EFContext())
            {
                PositionInfo position = new PositionInfo() { PoID = id };
                Context.PositionInfo.Attach(position);
                Context.PositionInfo.Remove(position);
                int result = Context.SaveChanges();
                return result;
            }
        }
    }
}
