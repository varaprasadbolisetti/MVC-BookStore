#pragma checksum "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Book\Edit1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3616c9d3162497d22b23a9e3e6211632b3dc2569"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Edit1), @"mvc.1.0.view", @"/Views/Book/Edit1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3616c9d3162497d22b23a9e3e6211632b3dc2569", @"/Views/Book/Edit1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ee065b352811cce9c56014903173590060373a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Edit1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bookstore.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Book\Edit1.cshtml"
  
    ViewData["Title"] = "Edit1";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit1 Book datails</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
#nullable restore
#line 9 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Book\Edit1.cshtml"
   Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 11 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Book\Edit1.cshtml"
       Write(Html.LabelFor(m => m.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 12 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Book\Edit1.cshtml"
       Write(Html.TextBoxFor(m => m.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Book\Edit1.cshtml"
       Write(Html.LabelFor(m => m.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Book\Edit1.cshtml"
       Write(Html.TextBoxFor(m => m.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Book\Edit1.cshtml"
       Write(Html.LabelFor(m => m.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 20 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Book\Edit1.cshtml"
       Write(Html.TextBoxFor(m => m.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Book\Edit1.cshtml"
       Write(Html.LabelFor(m => m.PublishedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"date\" id=\"PublishedDate\"");
            BeginWriteAttribute("value", " value=\"", 741, "\"", 780, 1);
#nullable restore
#line 24 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Book\Edit1.cshtml"
WriteAttributeValue("", 749, Model.PublishedDate.ToString(), 749, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" />\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <button class=\"btn btn-primary\" id=\"Update\">Update</button>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        $('#Update').click(function () {
            debugger;
            var Id = document.getElementById('Id').value;
            var bookName = document.getElementById('BookName').value;
            var Author = document.getElementById('Author').value;
            //var publisheddate = document.getElementById('Publisheddate').value;
            var isActive = document.getElementById('IsActive').value;

            var book = {
                Id: parseInt(Id),
                BookName: bookName,
                Author: Author
            }

            $.ajax({
                type: ""POST"",
                url: '");
#nullable restore
#line 51 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Book\Edit1.cshtml"
                 Write(Url.Action("EditBookDetails", "Book"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                contentType: \"application/json;\",\r\n                data: JSON.stringify(book),\r\n                dataType: \"json\",\r\n                success: function () { alert(\'Success\'); window.location.href = \'");
#nullable restore
#line 55 "C:\Users\Varaprasad Bolisetti\source\repos\Bookstore\Bookstore\Views\Book\Edit1.cshtml"
                                                                            Write(Url.Action("Index", "Book"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\'; },\r\n                error: function (e) { console.log(e) }\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bookstore.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
