using DemoBASMApp.Models;
using DemoBASMApp.Services;
using Microsoft.AspNetCore.Components;

namespace DemoBASMApp.Pages
{
    public partial class Index
    {
        [Inject] IEmployeeDataService EmployeeDataService { get; set; }
        private bool IsLoading { get; set; } = true;
        private List<Employee> Employees { get; set; } = new();
        protected override async Task OnInitializedAsync()
        {
            Employees = await EmployeeDataService.GetAllEmployees();
            IsLoading = false;
        }
    }
}