using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using programmercalc.web.Models;

namespace programmercalc.web.Controllers
{
    public class XmlToJsonController : Controller
    {
        XmlToJsonModel model;
        public XmlToJsonController()
        {
            model = new XmlToJsonModel();
        }
        public IActionResult Index()
        {
            if (TempData["result"] != null)
            {
                return View(TempData["result"] as XmlToJsonModel);

            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(XmlToJsonModel xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml.XmlData);

            string json = JsonConvert.SerializeXmlNode(doc);
            model.JsonData = json;
            model.XmlData = xml.XmlData;
            TempData["result"] = model;
            return RedirectToAction("Index");
        }
    }
}