using Core.Entities.BookAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class BookService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //this is totally useless for a real app; there would be
        //thousands of book at a minimum and millions in a big one.
        public List<Book> GetBooks()
        {
            return _unitOfWork.BookRepository.GetAll();
        }
    }
}
