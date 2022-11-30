using UserApi.Models;

namespace UserApi.Data
{
    public class DataHelper
    {
        public static readonly List<GetUserResponseModel> users = new List<GetUserResponseModel>();

        static DataHelper()
        {
            users.Add(new GetUserResponseModel() { FullName = "Uğur Can Yazıcıoğlu", Age = 29 });
            users.Add(new GetUserResponseModel() { FullName = "Test User", Age = 33 });
        }

        public static List<GetUserResponseModel> GetUsers()
        {
            return users;
        }
    }
}
