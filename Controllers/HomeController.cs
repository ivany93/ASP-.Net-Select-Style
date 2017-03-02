using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CDM1._1.Models;

namespace CDM1._1.Controllers
{
    public class HomeController : Controller
    {

        StyleContext db = new StyleContext();
        Random rnd = new Random();
       
        public ActionResult Index()
        {
            initialize();
            return View();
        }


      //  public void Listner(int idType, int idSelectImage)
       // {
         //   ListnerSelectImage(idType, idSelectImage);
          //  initialize();
          //  return Redirect("/Home/Index");
      //  }

        public ActionResult EndSelect()
        {
            IEnumerable<StyleType> Type = db.StyleType;
            IEnumerable<StyleType> FinType = Type.OrderByDescending(p => p.countSelect).Take(2);
            IEnumerable<StyleItems> Items = db.StyleItems;

            IEnumerable<StyleItems> itemsArray1 = Items.Where(items => items.parentId == FinType.ElementAt(0).id).Where(items => items.view == 0);
            StyleItems Oneitem1 = itemsArray1.ElementAt(rnd.Next(0, itemsArray1.Count()));
            IEnumerable<StyleItems> itemsArray2 = Items.Where(items => items.parentId == FinType.ElementAt(1).id).Where(items => items.view == 0);
            StyleItems Oneitem2 = itemsArray2.ElementAt(rnd.Next(0, itemsArray2.Count()));

            Oneitem1.view = 1;
            Oneitem2.view = 1;
            db.SaveChanges();

            ViewBag.Type = Type;
            ViewBag.ItemsList = Items;
            ViewBag.idType1 = FinType.ElementAt(0).id;
            ViewBag.idType2 = FinType.ElementAt(1).id;
            ViewBag.Items1 = Oneitem1;
            ViewBag.Items2 = Oneitem2;

            //return View("index");
            return View("~/Views/Home/Index.cshtml");
        }

        public ActionResult Finished()
        {
            IEnumerable<StyleType> Type = db.StyleType;
            IEnumerable<StyleItems> Items = db.StyleItems;

            IEnumerable<StyleType> FinType = Type.OrderByDescending(p => p.countSelect).Take(1);
            IEnumerable<StyleItems> itemsArray = Items.Where(items => items.view == 1);
            ViewBag.FinType = FinType;
            ViewBag.Type = Type;
            ViewBag.ItemsList = itemsArray;
            return View();
        }

        /// ////////////////////////////////////////////////////////////////////////////////////////

        public void clearDB() {
            IEnumerable<StyleType> Type = db.StyleType;
            IEnumerable<StyleItems> Items = db.StyleItems;

             for (int i = 0; i < Type.Count(); i++)
             {
                 Type.ElementAt(i).countSelect = 0;
             }

            for (int i = 0; i < Items.Count(); i++)
             {
                 Items.ElementAt(i).view = 0;             
             }

            db.SaveChanges();

        }

        [HttpPost]
        public string EndIteration(int idType, int idSelectImage)
        {
          //  int idType = Int32.Parse(Request.Params["idType"]);
           // int idSelectImage = Int32.Parse(Request.Params["idSelectImage"]);
            ListnerSelectImage(idType, idSelectImage);
            IEnumerable<StyleType> Type = db.StyleType;
            IEnumerable<StyleType> FinType = Type.OrderByDescending(p => p.countSelect).Take(2);


            if (FinType.ElementAt(0).countSelect == FinType.ElementAt(1).countSelect)
            {
                return "/Home/EndSelect";
            }
            else
            {
                return "/Home/Finished";
            }

        }


        private void initialize() {
            IEnumerable<StyleType> Type = db.StyleType;
            IEnumerable<StyleItems> Items = db.StyleItems;

            int[] typeArray = Type.Select(key => key.id).ToArray();
            int idType1 = rnd.Next(0, typeArray.Length);
            int idType2 = rnd.Next(0, typeArray.Length);

            while (idType1 == idType2)
            {
                idType2 = rnd.Next(0, typeArray.Length);
            }

            IEnumerable<StyleItems> itemsArray1 = Items.Where(items => items.parentId == typeArray[idType1]).Where(items => items.view == 0);
            StyleItems Oneitem1 = itemsArray1.ElementAt(rnd.Next(0, itemsArray1.Count()));
            IEnumerable<StyleItems> itemsArray2 = Items.Where(items => items.parentId == typeArray[idType2]).Where(items => items.view == 0);
            StyleItems Oneitem2 = itemsArray2.ElementAt(rnd.Next(0, itemsArray2.Count()));

            Oneitem1.view = 1;
            Oneitem2.view = 1;
            db.SaveChanges();

            ViewBag.idType1 = typeArray[idType1]; // random id array StyleType
            ViewBag.idType2 = typeArray[idType2]; // random id array StyleType
            ViewBag.Items1 = Oneitem1;
            ViewBag.Items2 = Oneitem2;
        }

        public void ListnerSelectImage(int idType, int idSelectImage)
        {
            StyleType Type = db.StyleType.Find(idType);
            Type.countSelect = Type.countSelect + 1;

          //  StyleItems Items = db.StyleItems.Find(idSelectImage);
          //  Items.view = 1;

            db.SaveChanges();
            
        }

    }


}
