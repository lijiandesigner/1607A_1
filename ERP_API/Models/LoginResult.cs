using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class LoginResult
    {
        public Boolean Result { get; set; }//登录是否成功
        public int EID { get; set; }//员工id
        public string PoName { get; set; }//职位名称
        public string ENo { get; set; }//员工编号
        public string EName { get; set; }//员工姓名
        public string Permissins { get; set; }//职位权限
    }
}