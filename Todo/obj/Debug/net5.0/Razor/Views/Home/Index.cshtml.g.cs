#pragma checksum "/Users/user/Downloads/c-sharp-academy-mvc-01-todo-vsc-master/Todo/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83417d732368ebdf6dcfe171df42f27474d8aa4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/user/Downloads/c-sharp-academy-mvc-01-todo-vsc-master/Todo/Views/_ViewImports.cshtml"
using Todo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/user/Downloads/c-sharp-academy-mvc-01-todo-vsc-master/Todo/Views/_ViewImports.cshtml"
using Todo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/user/Downloads/c-sharp-academy-mvc-01-todo-vsc-master/Todo/Views/_ViewImports.cshtml"
using Todo.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83417d732368ebdf6dcfe171df42f27474d8aa4c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30fa5c8dfa57d12f262a8b2aece5341238e41b26", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row justify-content-center"">
    <div class=""col-xl-6 col-lg-8 col-md-8 col-sm-10"">
        <table class=""table"">
            <thead>
                <tr class=""table-primary"">
                    <th scope=""col"">Id</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 14 "/Users/user/Downloads/c-sharp-academy-mvc-01-todo-vsc-master/Todo/Views/Home/Index.cshtml"
                 foreach (var t in Model.TodoList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th class=\"todos-column\" scope=\"row\">");
#nullable restore
#line 17 "/Users/user/Downloads/c-sharp-academy-mvc-01-todo-vsc-master/Todo/Views/Home/Index.cshtml"
                                                        Write(t.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td class=\"todos-column\">");
#nullable restore
#line 18 "/Users/user/Downloads/c-sharp-academy-mvc-01-todo-vsc-master/Todo/Views/Home/Index.cshtml"
                                            Write(t.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"buttons-column\">\r\n                            <input type=\"submit\" class=\"btn btn-danger\" value=\"Delete\"");
            BeginWriteAttribute("onClick", " onClick=\"", 791, "\"", 818, 3);
            WriteAttributeValue("", 801, "deleteTodo(", 801, 11, true);
#nullable restore
#line 20 "/Users/user/Downloads/c-sharp-academy-mvc-01-todo-vsc-master/Todo/Views/Home/Index.cshtml"
WriteAttributeValue("", 812, t.Id, 812, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 817, ")", 817, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <input type=\"submit\" class=\"btn btn-primary\" value=\"Update\"");
            BeginWriteAttribute("onClick", " onClick=\"", 911, "\"", 940, 3);
            WriteAttributeValue("", 921, "populateForm(", 921, 13, true);
#nullable restore
#line 21 "/Users/user/Downloads/c-sharp-academy-mvc-01-todo-vsc-master/Todo/Views/Home/Index.cshtml"
WriteAttributeValue("", 934, t.Id, 934, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 939, ")", 939, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 25 "/Users/user/Downloads/c-sharp-academy-mvc-01-todo-vsc-master/Todo/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
