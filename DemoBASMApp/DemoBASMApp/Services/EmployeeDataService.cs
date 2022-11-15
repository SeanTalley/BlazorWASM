using DemoBASMApp.Models;
using System.Net.Http.Json;

namespace DemoBASMApp.Services
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly HttpClient _httpClient;

        public EmployeeDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            var res = await _httpClient.GetFromJsonAsync<Employee[]>("http://localhost:5048/Client");
            return res?.ToList() ?? new List<Employee>();
        }
    }
}