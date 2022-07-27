using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace asp_todo.Models
{
    public class toDoModel
    {
        public List<ProjectModel> ProjectList { get; set; } = new List<ProjectModel>();
        //public ProjectModel ProjectModelSwitch { get; set; } = null;
    }

    public class ProjectModel
    {
        public string ProjectName { get; set; }
        public List<toDoItem> toDoList { get; set; } = new List<toDoItem>();
    }

    public class toDoItem
    {
        public string ItemTitle { get; set; }
        public string ItemDescription { get; set; }
        public DateTime ItemDueDate { get; set; }
        public toDoPriority ItemPriority { get; set; }
        public bool ItemDone { get; set; } = false;
    }

    public enum toDoPriority
    {
        Low,
        Medium,
        High
    }
}