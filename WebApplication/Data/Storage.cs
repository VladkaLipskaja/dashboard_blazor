using System.Collections.Generic;

namespace WebApplication.Data
{
    public static class Storage
    {
        public static List<string> ToDo = new List<string> { "Task #1", "Task #2", "Task #3" };
        public static List<string> InProgress = new List<string> { "Task #4", "Task #5", "Task #6", "Task #7" };
        public static List<string> Test = new List<string> { "Task #8", "Task #9" };
        public static List<string> Done = new List<string> { "Task #10", "Task #11", "Task #12", "Task #13", "Task #14" };
    }
}