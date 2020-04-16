using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication.Data
{
    public interface IDashboardService
    {
        Task<List<string>> GetToDo();
        Task<List<string>> GetInProgress();
        Task<List<string>> GetTest();
        Task<List<string>> GetDone();
    }
}