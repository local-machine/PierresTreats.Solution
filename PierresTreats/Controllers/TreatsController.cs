// using Microsoft.AspNetCore.Mvc;
// using PierresTreats.Models;
// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc.Rendering;

// namespace PierresTreats.Controllers
// {
//     public class TreatsController : Controller
//     {
//         private readonly PierresTreatsContext _db;

//         public TreatsController(PierresTreatsContext db)
//         {
//             _db = db;
//         }


//         public ActionResult Index()
//         {
//             List<Treat> model = _db.Treats.Include(treats => treats.Flavor).ToList();
//             return View(model);
//         }

//         public ActionResult Create()
//         {
//             ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
//             return View();
//         }

//         [HttpPost]
//         public ActionResult Create(Treat treat)
//         {
//             _db.Treats.Add(treat);
//             _db.SaveChanges();
//             return RedirectToAction("Index");
//         }

//         public ActionResult Details(int id)
//         {
//             Treat thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
//             return View(thisTreat);
//         }
//         public ActionResult Edit(int id)
//         {
//             var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
//             ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
//             return View(thisTreat);
//         }

//         [HttpPost]
//         public ActionResult Edit(Treat treat)
//         {
//             _db.Entry(treat).State = EntityState.Modified;
//             _db.SaveChanges();
//             return RedirectToAction("Index");
//         }

//         public ActionResult Delete(int id)
//         {
//             var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
//             return View(thisTreat);
//         }

//         [HttpPost, ActionName("Delete")]
//         public ActionResult DeleteConfirmed(int id)
//         {
//             var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
//             _db.Treats.Remove(thisTreat);
//             _db.SaveChanges();
//             return RedirectToAction("Index");
//         }

//     }
// }