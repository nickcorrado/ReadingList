using Core.Entities;
using Core.Entities.BookAggregate;
using System;
using System.Collections.Generic;

namespace Core.Services
{
    public class UserBookService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserBookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //something like this??
        public void ReadBook(int bookId, int userId)
        {
            _unitOfWork.UserBookRepository.Add(new UserBook(userId, bookId, UserBookStatus.Read, null, null));
        }

        public List<UserBook> GetUserBooks(int userId)
        {
            return _unitOfWork.UserBookRepository.FindByUserId(userId);
        }

        public UserBook GetUserBook(int? id)
        {
            return _unitOfWork.UserBookRepository.FindById(id);
        }

        public void CreateUserBook(UserBook userBook)
        {
            _unitOfWork.UserBookRepository.Add(userBook);
        }

        //I'm convinced something like this has to exist SOMEWHERE. This is just a rough first go at it
        public void CreateUserBook(Book book, IEnumerable<Author> authors, int roleId, int userId, UserBookStatus status, int? priority, int? rating)
        {
            _unitOfWork.BookRepository.Add(book);
            foreach(var author in authors)
            {
                _unitOfWork.AuthorRepository.Add(author);
                _unitOfWork.BookAuthorRepository.Add(new BookAuthor(roleId, book.BookId, author.AuthorId));
            }
            _unitOfWork.UserBookRepository.Add(new UserBook(userId, book.BookId, status, priority, rating));
        }

        public void EditBook(UserBook userBook)
        {
            _unitOfWork.UserBookRepository.Update(userBook);
        }

        public int GetUserBookCount(int userId) => _unitOfWork.UserBookRepository.FindByUserId(userId).Count;

        public void RemoveBook(int id)
        {
            var userBook = _unitOfWork.UserBookRepository.FindById(id);
            _unitOfWork.UserBookRepository.Remove(userBook);
        }
    }
}
