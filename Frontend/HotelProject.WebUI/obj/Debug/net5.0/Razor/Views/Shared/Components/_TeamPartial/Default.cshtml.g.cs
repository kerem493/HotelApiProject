#pragma checksum "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_TeamPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "680162ec14f7ec87340f75facabc4e766690787f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__TeamPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_TeamPartial/Default.cshtml")]
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
#line 1 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Staff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Testimonial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RegisterDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.LoginDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.AboutDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RoomDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.TestimonialDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.StaffDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.BookingDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"680162ec14f7ec87340f75facabc4e766690787f", @"/Views/Shared/Components/_TeamPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489bc74970a9e0660197937c4d57c44164956b4e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__TeamPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultStaffDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h6 class=""section-title text-center text-primary text-uppercase"">Ekip Arkadaşlarımız</h6>
            <h1 class=""mb-5"">Ekibimizle <span class=""text-primary text-uppercase"">Tanışın</span></h1>
        </div>
        <div class=""row g-4"">
");
#nullable restore
#line 10 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_TeamPartial\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-3 col-md-6 wow fadeInUp"" data-wow-delay=""0.1s"">
                    <div class=""rounded shadow overflow-hidden"">
                        <div class=""position-relative"">
                            <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 732, "\"", 756, 1);
#nullable restore
#line 15 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_TeamPartial\Default.cshtml"
WriteAttributeValue("", 738, item.SocialMedia1, 738, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 757, "\"", 763, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"position-absolute start-50 top-100 translate-middle d-flex align-items-center\">\r\n                                <a class=\"btn btn-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 962, "\"", 969, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a>\r\n                                <a class=\"btn btn-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 1084, "\"", 1091, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a>\r\n                                <a class=\"btn btn-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 1203, "\"", 1210, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\"></i></a>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"text-center p-4 mt-3\">\r\n                            <h5 class=\"fw-bold mb-0\">");
#nullable restore
#line 23 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_TeamPartial\Default.cshtml"
                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <small>");
#nullable restore
#line 24 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_TeamPartial\Default.cshtml"
                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 28 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_TeamPartial\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultStaffDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
