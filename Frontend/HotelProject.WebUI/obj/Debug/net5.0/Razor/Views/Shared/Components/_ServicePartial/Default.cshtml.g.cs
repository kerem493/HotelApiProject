#pragma checksum "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_ServicePartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6835af378278485772b2e5a4fefe728145a5009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__ServicePartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_ServicePartial/Default.cshtml")]
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
#nullable restore
#line 13 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ContactDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.GuestDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.SendMessageDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6835af378278485772b2e5a4fefe728145a5009", @"/Views/Shared/Components/_ServicePartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebc42b6abeadc8f36749ca178e46760b37ffa8c5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__ServicePartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultServiceDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h6 class=""section-title text-center text-primary text-uppercase"">Hizmetlerimiz</h6>
            <h1 class=""mb-5"">Hizmetlerimizi <span class=""text-primary"">Tanıyın</span></h1>
        </div>
        <div class=""row g-4"">
");
#nullable restore
#line 10 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_ServicePartial\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.1s"">
                    <a class=""service-item rounded"" href=""#"">
                        <div class=""service-icon bg-transparent border rounded p-1"">
                            <div class=""w-100 h-100 border rounded d-flex align-items-center justify-content-center"">
                                <i");
            BeginWriteAttribute("class", " class=\"", 846, "\"", 871, 1);
#nullable restore
#line 16 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_ServicePartial\Default.cshtml"
WriteAttributeValue("", 854, item.ServiceIcon, 854, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                            </div>\r\n                        </div>\r\n                        <h5 class=\"mb-3\">");
#nullable restore
#line 19 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_ServicePartial\Default.cshtml"
                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"text-body mb-0\">");
#nullable restore
#line 20 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_ServicePartial\Default.cshtml"
                                             Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 23 "D:\develope\Murat Yücedağ\HotelApiProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_ServicePartial\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultServiceDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
