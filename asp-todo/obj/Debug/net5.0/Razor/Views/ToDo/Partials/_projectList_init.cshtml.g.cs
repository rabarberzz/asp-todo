#pragma checksum "C:\Users\artis\RiderProjects\asp-todo\asp-todo\Views\ToDo\Partials\_projectList_init.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb33d17480ff94d33fd473f68d62ba2db77208b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDo_Partials__projectList_init), @"mvc.1.0.view", @"/Views/ToDo/Partials/_projectList_init.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb33d17480ff94d33fd473f68d62ba2db77208b0", @"/Views/ToDo/Partials/_projectList_init.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a562c5533e56258b2e8fdf00b10f3d4f3be5612b", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDo_Partials__projectList_init : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<toDoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\artis\RiderProjects\asp-todo\asp-todo\Views\ToDo\Partials\_projectList_init.cshtml"
  
    var ProjectList = Model.ProjectList;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\artis\RiderProjects\asp-todo\asp-todo\Views\ToDo\Partials\_projectList_init.cshtml"
 foreach (ProjectModel project in ProjectList)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li id=\"project-item\"");
            BeginWriteAttribute("onclick", " onclick=\"", 151, "\"", 205, 3);
            WriteAttributeValue("", 161, "actionSwitchProjects(\'", 161, 22, true);
#nullable restore
#line 11 "C:\Users\artis\RiderProjects\asp-todo\asp-todo\Views\ToDo\Partials\_projectList_init.cshtml"
WriteAttributeValue("", 183, project.ProjectName, 183, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 203, "\')", 203, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <p id=\"project-name\">");
#nullable restore
#line 12 "C:\Users\artis\RiderProjects\asp-todo\asp-todo\Views\ToDo\Partials\_projectList_init.cshtml"
                        Write(project.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <span id=\"project-count\">");
#nullable restore
#line 13 "C:\Users\artis\RiderProjects\asp-todo\asp-todo\Views\ToDo\Partials\_projectList_init.cshtml"
                            Write(project.toDoList.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </li>\r\n");
#nullable restore
#line 15 "C:\Users\artis\RiderProjects\asp-todo\asp-todo\Views\ToDo\Partials\_projectList_init.cshtml"
}

#line default
#line hidden
#nullable disable
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
