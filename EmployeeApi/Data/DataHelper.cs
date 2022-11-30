using EmployeeApi.Models;
using System.Collections.Generic;

namespace EmployeeApi.Data
{
    public class DataHelper
    {
        public static readonly List<GetEmployeeResponseModel> employees = new List<GetEmployeeResponseModel>();

        static DataHelper()
        {
            employees.Add(new GetEmployeeResponseModel() { Id = 1, FullName = "Uğur Can Yazıcıoğlu", Title = "Developer" });
            employees.Add(new GetEmployeeResponseModel() { Id = 2, FullName = "Test User", Title = "Data Scientist" });
        }

        public static List<GetEmployeeResponseModel> GetEmployees()
        {
            return employees;
        }
        public static GetEmployeeResponseModel GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(x => x.Id == id);
        }
    }
}
