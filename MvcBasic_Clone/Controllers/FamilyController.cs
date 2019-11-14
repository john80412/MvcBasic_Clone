using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcBasic_Clone.Models;

namespace MvcBasic_Clone.Controllers
{
    public class FamilyController : Controller
    {
        private MvcBasic_CloneContext db = new MvcBasic_CloneContext();

        // GET: Family
        public ActionResult Index()
        {
            List<Family> employees = new List<Family>
            {
                new Family { Id = 10001, Name = "David", Phone = "0933-154228", Age = 10 , City ="Tainan" },
                new Family { Id = 10002, Name = "Mary", Phone = "0925-157886", Age = 10 ,City ="Tainan" },
                new Family { Id = 10003, Name = "John", Phone = "0921-335884", Age = 10 ,City ="Tainan" },
                new Family { Id = 10004, Name = "Cindy", Phone = "0971-628322", Age = 10 ,City ="Tainan" },
                new Family { Id = 10005, Name = "Rose", Phone = "0933-154228",  Age = 10 ,City ="Tainan" }
            };

            return View(employees);
        }

        // GET: Family/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Family family = db.Families.Find(id);
            if (family == null)
            {
                return HttpNotFound();
            }
            return View(family);
        }

        // GET: Family/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Family/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Phone,Age,City")] Family family)
        {
            if (ModelState.IsValid)
            {
                db.Families.Add(family);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(family);
        }

        // GET: Family/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Family family = db.Families.Find(id);
            if (family == null)
            {
                return HttpNotFound();
            }
            return View(family);
        }

        // POST: Family/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Phone,Age,City")] Family family)
        {
            if (ModelState.IsValid)
            {
                db.Entry(family).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(family);
        }

        // GET: Family/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Family family = db.Families.Find(id);
            if (family == null)
            {
                return HttpNotFound();
            }
            return View(family);
        }

        // POST: Family/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Family family = db.Families.Find(id);
            db.Families.Remove(family);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
