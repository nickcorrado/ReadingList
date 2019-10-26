namespace Core.Services
{
    public class AuthorService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddAuthor(string firstName, string lastName)
        {
            _unitOfWork.AuthorRepository.Add(new Author(firstName, lastName));
        }
    }
}
