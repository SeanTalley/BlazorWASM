using DemoBASMApp.Models;

namespace DemoBASMApp.Services
{
    public interface IEmployeeDataService
    {
        Task<List<Employee>> GetAllEmployees();
    }
}