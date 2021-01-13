using Core.Entities;
using Core.Services;
using Microsoft.AspNet.Identity;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class LibraryController : Controller
    {
        private readonly BookService _bookService;
        private readonly UserBookService _userBookService;
        //ApplicationDbContext db = new ApplicationDbContext();

        //Dependency injection!
        public LibraryController(UserBookService userBookService, BookService bookService)
        {
            _bookService = bookService;
            _userBookService = userBookService;
        }

        // GET: Library
        [Authorize]
        public ActionResult Index()
        {
            //provisional code; I don't know how my services should really look yet
            var userId = User.Identity.GetUserId<int>();
            var userBooks = _userBookService.GetUserBooks(userId);
            //var userBooks = db.UserBooks.Include(u => u.Book).Where(m => m.UserId == userId);
            return View(userBooks.ToList());
        }

        // GET: Library/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //UserBook userBook = db.UserBooks.Find(id);
            //I don't love that this is a nullable int
            var userBook = _userBookService.GetUserBook(id);
            if (userBook == null)
            {
                return HttpNotFound();
            }
            return View(userBook);
        }

        // GET: Library/Create
        public ActionResult Create()
        {
            //ViewBag.BookId = new SelectList(db.Books, "BookId", "Title");
            ViewBag.BookId = new SelectList(_bookService.GetBooks(), "BookId", "Title");
            return View();
        }

        // POST: Library/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Status,Priority,Rating")] UserBook userBook)
        {
            if (ModelState.IsValid)
            {
                _userBookService.CreateUserBook(userBook);
                //db.UserBooks.Add(userBook);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.BookId = new SelectList(db.Books, "BookId", "Title", userBook.BookId);
            ViewBag.BookId = new SelectList(_bookService.GetBooks(), "BookId", "Title");
            return View(userBook);
        }

        // GET: Library/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //UserBook userBook = db.UserBooks.Find(id);
            var userBook = _userBookService.GetUserBook(id);
            if (userBook == null)
            {
                return HttpNotFound();
            }
            //ViewBag.BookId = new SelectList(db.Books, "BookId", "Title", userBook.BookId);
            ViewBag.BookId = new SelectList(_bookService.GetBooks(), "BookId", "Title");
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
                //db.Entry(userBook).State = EntityState.Modified;
                //db.SaveChanges();
                _userBookService.EditBook(userBook);
                return RedirectToAction("Index");
            }
            //ViewBag.BookId = new SelectList(db.Books, "BookId", "Title", userBook.BookId);
            ViewBag.BookId = new SelectList(_bookService.GetBooks(), "BookId", "Title");
            return View(userBook);
        }

        // GET: Library/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //UserBook userBook = db.UserBooks.Find(id);
            var userBook = _userBookService.GetUserBook(id);
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
            //UserBook userBook = db.UserBooks.Find(id);
            //db.UserBooks.Remove(userBook);
            //db.SaveChanges();
            _userBookService.RemoveBook(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
