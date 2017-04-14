using Serenity.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;

namespace mSurvey.Controllers
{
    public class HomeController : Controller
    {
        private string _cookieValue;

        public string CookieValue
        {
            get
            {
                if (Request.Cookies["UserId"] == null)
                {
                    Response.Cookies["UserId"].Value = Guid.NewGuid().ToString();
                    Response.Cookies["UserId"].Expires = DateTime.Now.AddYears(5);
                }

                _cookieValue = Request.Cookies["UserId"].Value;

                return _cookieValue;
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Survey(string cevaplar)
        {
            var ipAddress = GetLocalIPAddress();
            var guidFromCookie = CookieValue;

            IDbConnection con = SqlConnections.NewByKey("Default");
            string[] answers = cevaplar.Split('&');

            string[] QArray = {  "Q1", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7", "Q8", "Q9", "Q10", "Q11", "Q12", "Q13", "Q14",
                                 "Q15", "Q16", "Q17", "Q18", "Q19", "Q20", "Q21", "Guid", "IpAdress" };

            List<KeyValue> dataList = new List<KeyValue>();
            dataList.Add(new KeyValue("Guid", guidFromCookie));
            dataList.Add(new KeyValue("IpAdress", ipAddress));

            if (con.Query(new SqlQuery().From("Answers").Select("Guid").Where($"Guid = '{guidFromCookie}'")).Any())
            {
                var updateQuery = new SqlUpdate("Answers");

                foreach (var item in answers)
                {
                    var answer = item.Split('_');
                    dataList.Add(new KeyValue(answer[0], answer[1]));
                }

                foreach (var item in QArray)
                {
                    var data = "";
                    foreach (var item1 in dataList.Where(x => x.Key == item))
                    {
                        data += item1.Value + ",";
                    }
                    updateQuery.Set(item, data.TrimEnd(','));
                }
                con.Query(updateQuery.DebugText);
            }
            else
            {
                var insertQuery = new SqlInsert("Answers");

                foreach (var item in answers)
                {
                    var answer = item.Split('_');
                    dataList.Add(new KeyValue(answer[0], answer[1]));
                }

                foreach (var item in QArray)
                {
                    var data = "";
                    foreach (var item1 in dataList.Where(x => x.Key == item))
                    {
                        data += item1.Value + ",";
                    }
                    insertQuery.Set(item, data.TrimEnd(','));
                }
                con.Query(insertQuery.DebugText);
            }
            return Json("basarili");
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
    }

    public class KeyValue
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public KeyValue(string Key, string Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
}