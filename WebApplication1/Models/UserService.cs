using Microsoft.AspNetCore.Http;

namespace WebApplication1.Models
{
    public class UserService
    {
        private IHttpContextAccessor _httpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public bool IsLogin()
        {
            return _httpContextAccessor.HttpContext.Request.Cookies["username"] != null;
        }

        public bool CheckLogin(UserInfo user)
        {
            //为了测试方便
            return user.Name == user.Password;
        }
    }
}
