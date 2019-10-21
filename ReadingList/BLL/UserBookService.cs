using Core;
using System;

namespace Services
{
    public class UserBookService
    {
        private IUnitOfWork _unitOfWork;

        public UserBookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }

    //I think I need these?
    public class UserBook
    {
        public int UserBookId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int? Priority { get; set; }
        public float? Rating { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
