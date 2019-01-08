using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;  //  注意引用 NEWTONSOFT
namespace ERP_Dal
{
    public  class DBHelper
    {
        //连接
        public static  SqlConnection GetConn (){
            return new SqlConnection("Data Source=.;Initial Catalog=GoodsDB;Integrated Security=True");
        }
        //执行添加删除修改
        public static int ExecuteNonQuery(string sql)
        {
            SqlConnection conn = GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            int i=cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        //查询首行首列
        public static object ExecuteScalar(string sql)
        {
            SqlConnection conn = GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            object i = cmd.ExecuteScalar();
            conn.Close();
            return i;
        }
        //查询多行多列
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection conn = GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr=cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return sdr; 
        }

        //查询多行多列
        public static DataTable GetDataTable(string sql)
        {
            SqlConnection conn = GetConn();
            SqlDataAdapter sda = new SqlDataAdapter(sql,conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        //引用 newtownsoft 后 去掉注释
        public static List<T> GetList<T>(string sql)
        {
            DataTable dt = GetDataTable(sql);
            string json = JsonConvert.SerializeObject(dt);
            List<T> list = JsonConvert.DeserializeObject<List<T>>(json);
            return list;
        }

    }
}
//多选
/*
public string Hobby { 
            get {
                string hobby = "";
                if (IsSwimming) hobby += "游泳 ";
                if (IsRunning) hobby += "跑步 ";
                if (IsReading) hobby += "读书 ";
                if (IsWriting) hobby += "写作 ";
                return hobby;
            }
            set {
                if (value.Contains("游泳")) IsSwimming = true;
                if (value.Contains("跑步")) IsRunning = true;
                if (value.Contains("读书")) IsReading = true;
                if (value.Contains("写作")) IsWriting = true;
            }

        }*/
/*
 分页
       @using (Ajax.BeginForm("Search", null, new AjaxOptions() { UpdateTargetId = "tb" }, new { Id="f1" }))

 * 引用分部视图
 * <tbody id="tb">
                @Html.Action("Search")
            </tbody>
 * 
 * 
 * 分部视图
 * @using C1607B.ZH01.Model

@using Webdiyer.WebControls.Mvc

@model PagedList<Student>

@foreach (var item in Model)
{
    <tr>
        <td>
            @item.Id
        </td>
        <td>
            @item.Name
        </td>
        <td>
            @item.Hobby
        </td>
        <td>
            @item.Address
        </td>
    </tr> 
}
<tr>
    <td colspan="4">
        @Ajax.Pager(Model, 
                    new PagerOptions() {
                        ActionName="Search",
                        PageIndexParameterName = "PageIndex",
                        ContainerTagName = "ul",
                        CssClass = "pagination",
                        CurrentPagerItemTemplate = "<li class=\"active\"><a href=\"#\">{0}</a></li>",
                        DisabledPagerItemTemplate = "<li class=\"disabled\"><a>{0}</a></li>",
                        PagerItemTemplate = "<li>{0}</li>",
                        Id = "bootstrappager",
                        FirstPageText = "第一页",
                        LastPageText = "最后一页",
                        PrevPageText = "上一页",
                        NextPageText = "下一页" 
                    }, 
                    new MvcAjaxOptions() { UpdateTargetId="tb", DataFormId="f1" }（  视图      @using (Ajax.BeginForm("Search", null, new AjaxOptions() { UpdateTargetId = "tb" }, new { Id="f1" }))）
                    )

    </td>
</tr>
 */
/*
 文件引用
 * <script src="~/Scripts/jquery-1.10.2.js"></script>
    @*验证文件*@
    <script src="~/Scripts/jquery.validate.js"></script>
    <script src="~/Scripts/jquery.validate.unobtrusive.js"></script>
    @*ajax辅助方法文件*@
    <script src="~/Scripts/jquery.unobtrusive-ajax.js"></script>
    @*时间控件文件*@
    <script src="~/My97DatePicker/WdatePicker.js"></script>
    @*富文本框文件*@
    <script src="~/ueditor/ueditor.config.js"></script>
    <script src="~/ueditor/ueditor.all.js"></script>
    @*文件上传文件*@
    <script src="~/ueditor/lang/zh-cn/zh-cn.js"></script>
    <script src="~/ueditor/jquery-form.js"></script>
    <script src="~/ueditor/ueditor-upload.js"></script>
 */
/*
namespace BaWei.MVC.Unit09.Filters
{
    /// <summary>
    /// 自定义授权过滤器
    /// </summary>
    public class BWAuthorization : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //判断userName的值是否为空，如果为空表示用户未登录。
            //如果未登录，则转到Login控制器的Index方法。
            if (System.Web.HttpContext.Current.Session["userName"] == null)
            {
                filterContext.Result = new RedirectResult("/Login/Index");
            }
        }
    }
}
这里使用的是Session存储当前登录的用户名。
现在使用该过滤器：
[BWAuthorization()]
public ActionResult List()
{
    return View();
}


2.2.AllowAnonymous过滤器 匿名访问
*/