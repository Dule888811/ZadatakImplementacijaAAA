using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using ZadatakImplementacijaAAA.Models;
using Newtonsoft.Json.Linq;
using System.Runtime.Remoting.Contexts;

namespace ZadatakImplementacijaAAA.Controllers
{
    public class ProizvodiController : Controller
    {
        // GET: Proizvodi
        public ActionResult Index()
        {
           Proizvod  proizvod = null;
            return View(proizvod);
        }

        // GET: Proizvodi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Proizvodi/Create
        public ActionResult Create()
        {
        
            return View();
        }

        // POST: Proizvodi/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "naziv,opis,kategorija,proizvođač,dobavljač,cena")] Proizvod proizvod)
        {
            if (ModelState.IsValid)
            {
                string path = Server.MapPath("~/App_Data/");
                string json = JsonConvert.SerializeObject(proizvod);
               var jsonData = json.ToString();
                // JToken token = JToken.Parse(json);
                System.IO.File.WriteAllText(path + "proizvodi.json", jsonData);
              
                return RedirectToAction("Index", "Proizvodi");
            }
            else

                return View(proizvod);
        }
    }

        // GET: Proizvodi/Edit/5
   /*     public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Proizvodi/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        */
        // GET: Proizvodi/Delete/5
      

        // POST: Proizvodi/Delete/5
       
      
    }

