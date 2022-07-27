using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using asp_todo.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_todo.Controllers
{
    public class ToDoController : Controller
    {
        //dotnet watch run
        public static toDoModel homeModel = new toDoModel()
        {
            ProjectList = new List<ProjectModel>()
            {
                createExampleProject(),
                createExampleProject2()
            }
        };
        

        // GET
        public IActionResult todo_page()
        {
            return View(homeModel);
        }

        public IActionResult initHomeListItems() 
        {
            return PartialView("Partials/_todo_item", homeModel);
        }

        public IActionResult initHomeProjectItems()
        {
            return PartialView("Partials/_projectList_init", homeModel);
        }
        
        
        public IActionResult switchProject(string inputProjectName)
        {
            toDoModel switchModel = new toDoModel()
            {
                ProjectList = {homeModel.ProjectList.FirstOrDefault(
                    model => model.ProjectName == inputProjectName
                )}
            };
           return PartialView("Partials/_todo_item", switchModel);
        }

        public static ProjectModel createExampleProject()
        {
            toDoItem newItem1 = new toDoItem();
            newItem1.ItemTitle = "Example item 1";
            newItem1.ItemDescription = "The description of item 1 one";
            newItem1.ItemPriority = toDoPriority.Medium;
            newItem1.ItemDueDate = DateTime.Today.AddDays(10);
            toDoItem newItem2 = new toDoItem();
            newItem2.ItemTitle = "Example item 2";
            newItem2.ItemDescription = "The description of 2nd item";
            newItem2.ItemPriority = toDoPriority.Low;
            newItem2.ItemDueDate = DateTime.Today.AddDays(12);
            toDoItem newItem3 = new toDoItem();
            newItem3.ItemTitle = "Example item number 3";
            newItem3.ItemDescription = "The description 3";
            newItem3.ItemPriority = toDoPriority.High;
            newItem3.ItemDueDate = DateTime.Today.AddDays(6);
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
            toDoItem newItem2 = new toDoItem();
            newItem2.ItemTitle = "NewProj item 2";
            newItem2.ItemDescription = "The description of 2nd item";
            newItem2.ItemPriority = toDoPriority.Low;
            newItem2.ItemDueDate = DateTime.Today.AddDays(12);
            toDoItem newItem3 = new toDoItem();
            newItem3.ItemTitle = "NewProj item number 3";
            newItem3.ItemDescription = "The description 3";
            newItem3.ItemPriority = toDoPriority.High;
            newItem3.ItemDueDate = DateTime.Today.AddDays(6);
            toDoItem newItem4 = new toDoItem();
            newItem4.ItemTitle = "NewProj item number 4";
            newItem4.ItemDescription = "The description 4";
            newItem4.ItemPriority = toDoPriority.High;
            newItem4.ItemDueDate = DateTime.Today.AddDays(15);
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