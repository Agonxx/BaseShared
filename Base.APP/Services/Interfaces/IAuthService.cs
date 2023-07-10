using Base.Shared.Models;

namespace Base.APP.Services.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);

        Task Logout();
    }
}
