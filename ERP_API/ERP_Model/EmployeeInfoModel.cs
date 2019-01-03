﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ERP_Model
{
    /// <summary>
    /// 员工信息表
    /// </summary>
    public class EmployeeInfoModel
    {
        [Key]
        public int EID { get; set; }//主键ID
        public int ENo { get; set; }//员工编号
        public string EName { get; set; }//姓名
        public bool Esex { get; set; }//性别
        public string Ephone { get; set; }//手机号
        public string Eemail { get; set; }//邮箱
        public string EcardID { get; set; }//身份证
        public string Eheart { get; set; }//头像
        public int Pid { get; set; }//职位
        public string Permissions { get; set; }//权限
    }
}
