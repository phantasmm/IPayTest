#pragma checksum "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36271d9055c919279f40b2f62e3d207a32a2d5a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(IPay88Q2_4.Pages.Pages_Q3), @"mvc.1.0.razor-page", @"/Pages/Q3.cshtml")]
namespace IPay88Q2_4.Pages
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
#line 1 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\_ViewImports.cshtml"
using IPay88Q2_4;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36271d9055c919279f40b2f62e3d207a32a2d5a5", @"/Pages/Q3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f31f56f8edbfd83cb5273424ec43c668dab5f5b5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Q3 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
  
    ViewData["Title"] = "Q3";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Q3</h1>\r\n<table class=\"table table-dark\">\r\n    <tr>\r\n        <th>Doctor</th>\r\n        <th>Professor</th>\r\n        <th>Singer</th>\r\n        <th>Actor</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
     for (var i = 0; i < @Model.max; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n");
#nullable restore
#line 18 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
                 if (Model.Doctor.Length > i)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
               Write(Model.Doctor[i]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
                                    
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>NULL</span>\r\n");
#nullable restore
#line 25 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 28 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
                 if (Model.Professor.Length > i)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
               Write(Model.Professor[i]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
                                       
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>NULL</span>\r\n");
#nullable restore
#line 35 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 38 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
                 if (Model.Singer.Length > i)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
               Write(Model.Singer[i]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
                                    
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>NULL</span>\r\n");
#nullable restore
#line 45 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 48 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
                 if (Model.Actor.Length > i)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
               Write(Model.Actor[i]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
                                   
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>NULL</span>\r\n");
#nullable restore
#line 55 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\jakkr\Desktop\IPay88\IPay88Q2-4\IPay88Q2-4\Pages\Q3.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPay88Q2_4.Pages.Q3Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IPay88Q2_4.Pages.Q3Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IPay88Q2_4.Pages.Q3Model>)PageContext?.ViewData;
        public IPay88Q2_4.Pages.Q3Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
