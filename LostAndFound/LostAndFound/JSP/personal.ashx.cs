using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using BLL;
using System.Web.Script.Serialization;
using System.IO;
using System.Drawing;

namespace LostAndFound.JSP
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            
            context.Response.ContentType = "text/plain";
            string action = context.Request["Action"];
            switch (action)
            {
               
                case "GetPublished":
                    GetPublished(context);
                    break;              
                
                default:
                    query(context);
                    break;
            }
            context.Response.End();
        }

                    private void query(HttpContext context)
                    {
 	                    throw new NotImplementedException();
                    }



         //获取已发布信息
        public void GetPublished(HttpContext context)
        {
            
            string UserID = context.Request["UserID"];
            BLL_Published MsgPublished = new BLL_Published();
            IList<Published> PublishedInf = MsgPublished.getPublishedInf(UserID);
            JavaScriptSerializer jss = new JavaScriptSerializer();
            string json = jss.Serialize(PublishedInf);
            context.Response.Write("{ \"PublishedInf\":" + json + "}");

        }



        


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}