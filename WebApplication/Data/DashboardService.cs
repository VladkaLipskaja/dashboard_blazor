using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication.Data
{
    public class DashboardService : IDashboardService
    {
        public Task<List<string>> GetToDo()
        {
            return Task.FromResult(Storage.ToDo);
        }

        public Task<List<string>> GetInProgress()
        {
            return Task.FromResult(Storage.InProgress);
        }

        public Task<List<string>> GetTest()
        {
            return Task.FromResult(Storage.Test);
        }

        public Task<List<string>> GetDone()
        {
            return Task.FromResult(Storage.Done);
        }
    }
}