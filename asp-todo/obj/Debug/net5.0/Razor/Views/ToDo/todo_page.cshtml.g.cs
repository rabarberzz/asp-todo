#pragma checksum "C:\Users\artis\RiderProjects\asp-todo\asp-todo\Views\ToDo\todo_page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "747e7220efa498ff16529c62ac031e50805534d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDo_todo_page), @"mvc.1.0.view", @"/Views/ToDo/todo_page.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\artis\RiderProjects\asp-todo\asp-todo\Views\_ViewImports.cshtml"
using asp_todo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\artis\RiderProjects\asp-todo\asp-todo\Views\_ViewImports.cshtml"
using asp_todo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"747e7220efa498ff16529c62ac031e50805534d8", @"/Views/ToDo/todo_page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a562c5533e56258b2e8fdf00b10f3d4f3be5612b", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDo_todo_page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<toDoModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("new-project-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\artis\RiderProjects\asp-todo\asp-todo\Views\ToDo\todo_page.cshtml"
  
    ViewData["Title"] = "To Do App";
    //var ProjectList = Model.ProjectList;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function() {
          actionDrawAllToDoItems();
          actionDrawAllProjects();      
        });
        function actionSwitchProjects(name){           
            $.ajax({
                url: ""ToDo/switchProject"",
                type: ""POST"",
                data: {inputProjectName: name},
                success: function (partialView) {
                    $('.todo-container').empty().append(partialView);
                }
            });
        }
        function actionDrawAllToDoItems(){
            $.ajax({
                url: ""ToDo/drawAllToDoItems"",
                type: ""POST"",
                success: function (partialView) {
                    $('.todo-container').empty().append(partialView);
                }
            });
        }
        function actionDrawAllProjects(){
            $.ajax({
                 url: ""ToDo/drawMainProjectItems"",
                 type: ""POST"",
                 success: function(partial");
                WriteLiteral(@"View) {
                    $('#projects-listitem').nextAll().remove();
                    $('#projects-listitem').after(partialView);
                 }
            });
        }
        function actionDrawTodayItems(){
            $.ajax({
                 url: ""ToDo/drawTodayitems"",
                 type: ""POST"",
                 success: function(partialView) {
                    $('.todo-container').empty().append(partialView);
                 }
            });
        }
        function actionDrawWeekItems(){
                    $.ajax({
                         url: ""ToDo/drawWeekItems"",
                         type: ""POST"",
                         success: function(partialView) {
                            $('.todo-container').empty().append(partialView);
                         }
                    });
                }
        function toggleNewItemForm(){
            let newItemForm = $('.form-container-item').empty();
            $.ajax({
                url: ""To");
                WriteLiteral(@"Do/getNewToDoItemForm"",
                type: ""POST"",
                success: function(partialView) {
                    newItemForm.append(partialView).toggle();
                }
            });
        }
        function addNewItemFromForm(){
            var formElement = $(""form[name=new-item-form]"")[0];
            var formData = new FormData(formElement);
            $.ajax({
                url: ""ToDo/addNewToDoItem"",
                type: ""POST"",
                cache: false,
                contentType: false,
                processData: false,
                data: formData,
                success: function() {
                  actionDrawAllToDoItems();
                  actionDrawAllProjects();
                  $('.form-container-item').toggle();
                }
            });
        }      
        function addNewProjectFromForm(){
            var formElement = $(""form[name=new-project-form]"")[0];
            var formData = new FormData(formElement);
          ");
                WriteLiteral(@"  $.ajax({
                url: ""ToDo/addNewProject"",
                type: ""POST"",
                cache: false,
                contentType: false,
                processData: false,
                data: formData,
                success: function() {
                  actionDrawAllProjects();
                  $('.form-container-project').toggle();
                }
            });
        }
        function removeToDoItem(projectName, itemIdentifier, itemElement){            
            $.ajax({
                url: ""ToDo/removeToDoItem"",
                type: ""POST"",               
                data: {projectName: projectName, itemIdentifier: itemIdentifier},
                success: function() {
                  actionDrawAllProjects();
                  $(itemElement.parentElement.parentElement).fadeOut('slow', function() {
                    $(this).remove;
                  });
                }
            });
        }
        function toggleNoteExtra(element){
  ");
                WriteLiteral("          $(element).slideToggle(\'slow\');\r\n        }\r\n    </script> \r\n");
            }
            );
            WriteLiteral(@"
<header class=""page-header"">
    <h2>To Do List</h2>
    <button id=""new-item-btn"" class=""init-projs"" onclick=""$('.form-container-project').toggle()""  >Add new project</button>
    <button id=""new-item-btn"" onclick=""toggleNewItemForm()"">New items</button>
</header>

<div class=""hidden-form-container"">
    <div class=""form-container form-container-project"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "747e7220efa498ff16529c62ac031e50805534d88745", async() => {
                WriteLiteral("\r\n            <h4>Create a new project</h4>\r\n            <input type=\"text\" name=\"name\" placeholder=\"Enter project name\">\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <button onclick=""addNewProjectFromForm()"">Add Project</button>
    </div>
    <div class=""form-container form-container-item""></div>
</div>
    

<div class=""main-container app"">
    <div class=""sidebar-container"">
        <ul class=""sidebar-project-list"">
            <li onclick=""actionDrawAllToDoItems()""><p>Home</p></li>
            <li onclick=""actionDrawTodayItems()""><p>Today</p></li>
            <li onclick=""actionDrawWeekItems()""><p>Week</p></li>
            <li id=""projects-listitem""><p>Projects</p></li>
        </ul>
    </div>
    <div class=""todo-container"">
");
            WriteLiteral("        \r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<toDoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
