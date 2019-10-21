using Core;

namespace Services
{
    //By analogy with IdentityService. It's a start
    public class AuthorService
    {
        private IUnitOfWork _unitOfWork;
        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
