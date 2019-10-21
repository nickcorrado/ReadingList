using Core;

namespace Services
{
    //By analogy with IdentityService. It's a start
    public class AuthorService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
