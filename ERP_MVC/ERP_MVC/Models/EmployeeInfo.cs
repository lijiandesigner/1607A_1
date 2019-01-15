using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_MVC.Models
{
    public class EmployeeInfo
    {
        public int EID { get; set; }//主键ID
        public string ENo { get; set; }//员工编号
        public string EName { get; set; }//姓名
        public bool Esex { get; set; }//性别
        public string Ephone { get; set; }//手机号
        public string Eemail { get; set; }//邮箱
        public string EcardID { get; set; }//身份
        public string Eheart { get; set; }//头像
        public string PoName { get; set; }//职位
        public string PeBeginWork { get; set; } //入职时间
        public string PeEndwork { get; set; }//离职时间
        public bool Pstatic { get; set; }//工作状态
    }
}