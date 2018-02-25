using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ReadingList.Models;
using Microsoft.AspNet.Identity;

namespace ReadingList.Controllers
{
    public class LibraryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Library
        [Authorize]
        public ActionResult Index()
        {
            string userId = User.Identity.GetUserId();
            //I only want the current user's library!
            var userBooks = db.UserBooks.Include(u => u.Book).Where(m => m.UserId == userId);
            return View(userBooks.ToList());

            //Disregard this; I was failing to use the model's collections properly. I'm a moron.
            //var library = db.Libraries.Where(m => m.UserId == userId);
            //I think we need to map from the model to the viewmodel by instantiating the viewmodel and then filling its properties.
            //var library2 = new LibraryViewModel
            //{
            //    UserBookId = 123
            //};

            //return View(library.ToList());
            
            //else
            //{
            //    //unnecessary now with [Authorize] attribute on
            //    //Redirects to home page; probably want to redirect to another page or Register instead?
            //    return RedirectToRoute(new
            //    {
            //        controller = "Home",
            //        action = "Index"
            //    });
            //}
        }

        // GET: Library/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserBook userBook = db.UserBooks.Find(id);
            if (userBook == null)
            {
                return HttpNotFound();
            }
            return View(userBook);
        }

        // GET: Library/Create
        public ActionResult Create()
        {
            ViewBag.BookId = new SelectList(db.Books, "BookId", "Title");
            return View();
        }

        // POST: Library/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // I've tried removing the IDs and the DateAdded field per above warning.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Status,Priority,Rating")] UserBook userBook)
        {
            if (ModelState.IsValid)
            {
                db.UserBooks.Add(userBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BookId = new SelectList(db.Books, "BookId", "Title", userBook.BookId);
            return View(userBook);
        }

        // GET: Library/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserBook userBook = db.UserBooks.Find(id);
            if (userBook == null)
            {
                return HttpNotFound();
            }
            ViewBag.BookId = new SelectList(db.Books, "BookId", "Title", userBook.BookId);
            return View(userBook);
        }

        // POST: Library/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserBookId,UserId,BookId,Status,Priority,Rating,DateAdded")] UserBook userBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BookId = new SelectList(db.Books, "BookId", "Title", userBook.BookId);
            return View(userBook);
        }

        // GET: Library/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserBook userBook = db.UserBooks.Find(id);
            if (userBook == null)
            {
                return HttpNotFound();
            }
            return View(userBook);
        }

        // POST: Library/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserBook userBook = db.UserBooks.Find(id);
            db.UserBooks.Remove(userBook);
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
