using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using asp_todo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace asp_todo.Controllers
{
    public class ToDoController : Controller
    {
        //dotnet watch run
        public static ObjectIDGenerator ToDoItemIdGenerator = new ObjectIDGenerator();
        public static toDoModel MainToDoModel = new toDoModel()
        {
            ProjectList = new List<ProjectModel>()
            {
                createExampleProject(),
                createExampleProject2()
            }
        };
        

        // GET
        [HttpGet]
        public IActionResult todo_page()
        {
            return View(MainToDoModel);
        }

        // POST
        [HttpPost]
        public IActionResult drawMainListItems() 
        {
            return PartialView("Partials/_todo_item", MainToDoModel);
        }

        public IActionResult drawMainProjectItems()
        {
            return PartialView("Partials/_projectList_init", MainToDoModel);
        }
        
        
        public IActionResult switchProject(string inputProjectName)
        {
            toDoModel switchModel = new toDoModel()
            {
                ProjectList = {MainToDoModel.ProjectList.FirstOrDefault(
                    model => model.ProjectName == inputProjectName
                )}
            };
           return PartialView("Partials/_todo_item", switchModel);
        }

        public IActionResult drawAllToDoItems()
        {
            return PartialView("Partials/_todo_item", MainToDoModel);
        }

        public IActionResult drawTodayitems()
        {
            toDoModel todayModel = new toDoModel();
            foreach (ProjectModel projectModel in MainToDoModel.ProjectList)
            {
                foreach (toDoItem doItem in projectModel.toDoList)
                {
                    if (doItem.ItemDueDate == DateTime.Today)
                    {
                        ProjectModel newProject = new ProjectModel();
                        newProject.toDoList.Add(doItem);
                        newProject.ProjectName = projectModel.ProjectName;
                        todayModel.ProjectList.Add(newProject);
                    }
                }
            }
            return PartialView("Partials/_todo_item", todayModel);
        }

        public IActionResult drawWeekItems()
        {
            toDoModel weekModel = new toDoModel();
            foreach (ProjectModel projectModel in MainToDoModel.ProjectList)
            {
                foreach (toDoItem doItem in projectModel.toDoList)
                {
                    if (doItem.ItemDueDate > DateTime.Today && doItem.ItemDueDate < DateTime.Today.AddDays(7))
                    {
                        ProjectModel newProject = new ProjectModel();
                        newProject.toDoList.Add(doItem);
                        newProject.ProjectName = projectModel.ProjectName;
                        weekModel.ProjectList.Add(newProject);
                    }
                }
            }
            return PartialView("Partials/_todo_item", weekModel);
        }

        public IActionResult getNewToDoItemForm()
        {
            return PartialView("Partials/_newToDoItemForm", MainToDoModel);
        }

        public void addNewToDoItem(IFormCollection formCollection)
        {
            toDoItem newItem = new toDoItem();
            newItem.ItemTitle = formCollection["title"];
            newItem.ItemDescription = formCollection["description"];
            newItem.ItemDueDate = DateTime.Parse(formCollection["dueDate"]);
            Enum.TryParse(formCollection["priority"], out toDoPriority priority);
            newItem.ItemPriority = priority;
            newItem.ItemIdentifier = ToDoItemIdGenerator.GetId(newItem, out bool newItemFirstTime);
            ProjectModel projectObj = MainToDoModel.ProjectList.Find(model => model.ProjectName == formCollection["project"]);
            projectObj.toDoList.Add(newItem);
        }

        public void addNewProject(IFormCollection formCollection)
        {
            ProjectModel newProject = new ProjectModel();
            newProject.ProjectName = formCollection["name"];
            MainToDoModel.ProjectList.Add(newProject);
        }

        public void removeToDoItem(string projectName, long itemIdentifier)
        {
            var currentProj = MainToDoModel.ProjectList.Find(model => model.ProjectName == projectName);
            var currentItem = currentProj.toDoList.Find(item => item.ItemIdentifier == itemIdentifier);
            currentProj.toDoList.Remove(currentItem);
        }

        public JsonResult ProjectCountJsonResult()
        {
            Dictionary<string, int> projectItemCountDict = new Dictionary<string, int>();
            foreach (ProjectModel model in MainToDoModel.ProjectList)
            {
                projectItemCountDict.Add(model.ProjectName, model.toDoList.Count);
            }

            return Json(projectItemCountDict);
        }

        public static ProjectModel createExampleProject()
        {
            toDoItem newItem1 = new toDoItem();
            newItem1.ItemTitle = "Example item 1";
            newItem1.ItemDescription = "The description of item 1 one";
            newItem1.ItemPriority = toDoPriority.Medium;
            newItem1.ItemDueDate = DateTime.Today.AddDays(10);
            newItem1.ItemIdentifier = ToDoItemIdGenerator.GetId(newItem1, out bool newItem1FirstTime);
            toDoItem newItem2 = new toDoItem();
            newItem2.ItemTitle = "Example item 2";
            newItem2.ItemDescription = "The description of 2nd item";
            newItem2.ItemPriority = toDoPriority.Low;
            newItem2.ItemDueDate = DateTime.Today.AddDays(12);
            newItem2.ItemIdentifier = ToDoItemIdGenerator.GetId(newItem2, out bool newItem2FirstTime);
            toDoItem newItem3 = new toDoItem();
            newItem3.ItemTitle = "Example item number 3";
            newItem3.ItemDescription = "The description 3";
            newItem3.ItemPriority = toDoPriority.High;
            newItem3.ItemDueDate = DateTime.Today.AddDays(6);
            newItem3.ItemIdentifier = ToDoItemIdGenerator.GetId(newItem3, out bool newItem3FirstTime);
            ProjectModel returnProject = new ProjectModel();
            returnProject.ProjectName = "Example";
            returnProject.toDoList.Add(newItem1);
            returnProject.toDoList.Add(newItem2);
            returnProject.toDoList.Add(newItem3);
            return returnProject; 
        }
        public static ProjectModel createExampleProject2()
        {
            toDoItem newItem1 = new toDoItem();
            newItem1.ItemTitle = "NewProj item 1";
            newItem1.ItemDescription = "The description of item 1";
            newItem1.ItemPriority = toDoPriority.Medium;
            newItem1.ItemDueDate = DateTime.Today.AddDays(10);
            newItem1.ItemIdentifier = ToDoItemIdGenerator.GetId(newItem1, out bool newItem1FirstTime);
            toDoItem newItem2 = new toDoItem();
            newItem2.ItemTitle = "NewProj item 2";
            newItem2.ItemDescription = "The description of 2nd item";
            newItem2.ItemPriority = toDoPriority.Low;
            newItem2.ItemDueDate = DateTime.Today.AddDays(12);
            newItem2.ItemIdentifier = ToDoItemIdGenerator.GetId(newItem2, out bool newItem2FirstTime);
            toDoItem newItem3 = new toDoItem();
            newItem3.ItemTitle = "NewProj item number 3";
            newItem3.ItemDescription = "The description 3";
            newItem3.ItemPriority = toDoPriority.High;
            newItem3.ItemDueDate = DateTime.Today.AddDays(6);
            newItem3.ItemIdentifier = ToDoItemIdGenerator.GetId(newItem3, out bool newItem3FirstTime);
            toDoItem newItem4 = new toDoItem();
            newItem4.ItemTitle = "NewProj item number 4";
            newItem4.ItemDescription = "The description 4";
            newItem4.ItemPriority = toDoPriority.High;
            newItem4.ItemDueDate = DateTime.Today.AddDays(15);
            newItem4.ItemIdentifier = ToDoItemIdGenerator.GetId(newItem4, out bool newItem4FirstTime);
            ProjectModel returnProject = new ProjectModel();
            returnProject.ProjectName = "NewProj";
            returnProject.toDoList.Add(newItem1);
            returnProject.toDoList.Add(newItem2);
            returnProject.toDoList.Add(newItem3);
            returnProject.toDoList.Add(newItem4);
            return returnProject; 
        }
    }
}