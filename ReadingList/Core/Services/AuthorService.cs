using Core.Entities;
using System;

namespace Core.Services
{
    public class AuthorService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //I think this is how this goes? We can do business logic in methods like this
        public void AddAuthor(string firstName, string lastName)
        {
            _unitOfWork.AuthorRepository.Add(new Author
            {
                FirstName = firstName,
                LastName = lastName,
                CreateDate = DateTime.Now,
            });
        }
    }
}
