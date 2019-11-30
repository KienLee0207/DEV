using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThuVienApp.Models;

namespace ThuVienApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            List<DataPoint> dataPoints1 = new List<DataPoint>();
			List<DataPoint> dataPoints2 = new List<DataPoint>();
			List<DataPoint> dataPoints3 = new List<DataPoint>();
			List<DataPoint> dataPoints4 = new List<DataPoint>();
 
			dataPoints1.Add(new DataPoint(1483209000000, 65));
			dataPoints1.Add(new DataPoint(1485887400000, 62));
			dataPoints1.Add(new DataPoint(1488306600000, 65));
			dataPoints1.Add(new DataPoint(1490985000000, 20));
			dataPoints1.Add(new DataPoint(1493577000000, 36));
			dataPoints1.Add(new DataPoint(1496255400000, 53));
 
			dataPoints2.Add(new DataPoint(1483209000000, 85));
			dataPoints2.Add(new DataPoint(1485887400000, 36));
			dataPoints2.Add(new DataPoint(1488306600000, 15));
			dataPoints2.Add(new DataPoint(1490985000000, 25));
			dataPoints2.Add(new DataPoint(1493577000000, 65));
			dataPoints2.Add(new DataPoint(1496255400000, 49));
 
			dataPoints3.Add(new DataPoint(1483209000000, 63));
			dataPoints3.Add(new DataPoint(1485887400000, 46));
			dataPoints3.Add(new DataPoint(1488306600000, 21));
			dataPoints3.Add(new DataPoint(1490985000000, 55));
			dataPoints3.Add(new DataPoint(1493577000000, 46));
			dataPoints3.Add(new DataPoint(1496255400000, 50));
 
			dataPoints4.Add(new DataPoint(1483209000000, 45));
			dataPoints4.Add(new DataPoint(1485887400000, 55));
			dataPoints4.Add(new DataPoint(1488306600000, 33));
			dataPoints4.Add(new DataPoint(1490985000000, 60));
			dataPoints4.Add(new DataPoint(1493577000000, 39));
			dataPoints4.Add(new DataPoint(1496255400000, 70));
 
			ViewBag.DataPoints1 = JsonConvert.SerializeObject(dataPoints1);
			ViewBag.DataPoints2 = JsonConvert.SerializeObject(dataPoints2);
			ViewBag.DataPoints3 = JsonConvert.SerializeObject(dataPoints3);
			ViewBag.DataPoints4 = JsonConvert.SerializeObject(dataPoints4);
 
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}