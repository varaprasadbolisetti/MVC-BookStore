#pragma checksum "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Student\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6e2830471150a236ea5dd913ce22c2129b59cbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Edit), @"mvc.1.0.view", @"/Views/Student/Edit.cshtml")]
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
#line 1 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\_ViewImports.cshtml"
using BookService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\_ViewImports.cshtml"
using BookService.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6e2830471150a236ea5dd913ce22c2129b59cbc", @"/Views/Student/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ee065b352811cce9c56014903173590060373a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bookstore.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Student\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit</h1>\r\n\r\n<h4>Student</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n            ");
#nullable restore
#line 13 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Student\Edit.cshtml"
       Write(Html.HiddenFor(m => m.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 15 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Student\Edit.cshtml"
           Write(Html.LabelFor(m => m.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 16 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Student\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 19 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Student\Edit.cshtml"
           Write(Html.LabelFor(m => m.StudentGender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Student\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.StudentGender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 23 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Student\Edit.cshtml"
           Write(Html.LabelFor(m => m.StudentCourse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 24 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Student\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.StudentCourse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Student\Edit.cshtml"
           Write(Html.LabelFor(m => m.StudentJoindate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <input type=\"date\" id=\"StudentJoindate\"");
            BeginWriteAttribute("value", " value=\"", 864, "\"", 914, 1);
#nullable restore
#line 28 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Student\Edit.cshtml"
WriteAttributeValue("", 872, Model.StudentJoindate.ToShortDateString(), 872, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class = \"form-control\"/>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <button class=\"btn btn-primary\" id=\"Update\">Update</button>\r\n            </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        $('#Update').click(function () {
            debugger;
            var studentId = document.getElementById('StudentId').value;
            var studentName = document.getElementById('StudentName').value;
            var studentGender = document.getElementById('StudentGender').value;
            var studentCourse = document.getElementById('StudentCourse').value;
            var studentJoindate = document.getElementById('StudentJoindate').value;

            var stud = {
                StudentId: parseInt(studentId),
                StudentName: studentName,
                StudentGender: studentGender,
                StudentCourse: studentCourse,
            }

            $.ajax({
                type: ""POST"",
                url: '");
#nullable restore
#line 56 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Student\Edit.cshtml"
                 Write(Url.Action("EditStudentDetails", "Student"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                contentType: \"application/json;\",\r\n                data: JSON.stringify(stud),\r\n                dataType: \"json\",\r\n                success: function () { alert(\'Success\'); window.location.href = \'");
#nullable restore
#line 60 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Student\Edit.cshtml"
                                                                            Write(Url.Action("GetStudents","Student"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\'; },\r\n                error: function (e) { console.log(e) }\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookstore.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
