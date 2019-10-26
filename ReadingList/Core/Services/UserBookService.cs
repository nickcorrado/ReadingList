namespace Core.Services
{
    public class UserBookService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserBookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
