﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ReadingList.Models;

namespace ReadingList.Controllers
{
    public class UserLibraryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: UserLibrary
        public ActionResult Index()
        {
            var userBooks = db.UserBooks.Include(u => u.Book);
            return View(userBooks.ToList());
        }

        // GET: UserLibrary/Details/5
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

        // GET: UserLibrary/Create
        public ActionResult Create()
        {
            ViewBag.BookId = new SelectList(db.Books, "BookId", "Title");
            return View();
        }

        // POST: UserLibrary/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserBookId,UserId,BookId,Status,Priority,Rating,DateAdded")] UserBook userBook)
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

        // GET: UserLibrary/Edit/5
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

        // POST: UserLibrary/Edit/5
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

        // GET: UserLibrary/Delete/5
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

        // POST: UserLibrary/Delete/5
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
