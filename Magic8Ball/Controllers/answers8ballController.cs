using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Magic8Ball.DAL;
using Magic8Ball.Models;

namespace Magic8Ball.Controllers
{
    public class answers8ballController : Controller
    {
        private Magic8BallContext db = new Magic8BallContext();

        // GET: answers8ball
        public ActionResult Index()
        {
            return View(db.answers8balls.ToList());
        }

        // GET: answers8ball/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            answers8ball answers8ball = db.answers8balls.Find(id);
            if (answers8ball == null)
            {
                return HttpNotFound();
            }
            return View(answers8ball);
        }

        // GET: answers8ball/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: answers8ball/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Message")] answers8ball answers8ball)
        {
            if (ModelState.IsValid)
            {
                db.answers8balls.Add(answers8ball);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(answers8ball);
        }

        // GET: answers8ball/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            answers8ball answers8ball = db.answers8balls.Find(id);
            if (answers8ball == null)
            {
                return HttpNotFound();
            }
            return View(answers8ball);
        }

        // POST: answers8ball/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Message")] answers8ball answers8ball)
        {
            if (ModelState.IsValid)
            {
                db.Entry(answers8ball).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(answers8ball);
        }

        // GET: answers8ball/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            answers8ball answers8ball = db.answers8balls.Find(id);
            if (answers8ball == null)
            {
                return HttpNotFound();
            }
            return View(answers8ball);
        }

        // POST: answers8ball/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            answers8ball answers8ball = db.answers8balls.Find(id);
            db.answers8balls.Remove(answers8ball);
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
