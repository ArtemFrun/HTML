#pragma checksum "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2369391c765619abaac31a1c4b2931edd91845e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\FetchData.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\FetchData.razor"
 if (events != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\FetchData.razor"
     foreach (var eve in events)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "        ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "blog-container");
            __builder.AddMarkupContent(3, "\r\n\r\n            ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "blog-header");
            __builder.AddMarkupContent(6, "\r\n                ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "blog-cover");
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "blog-owner");
            __builder.AddMarkupContent(12, "\r\n                        ");
            __builder.OpenElement(13, "ul");
            __builder.AddMarkupContent(14, "\r\n                            ");
            __builder.OpenElement(15, "li");
            __builder.AddMarkupContent(16, "\r\n                                ");
            __builder.AddMarkupContent(17, "<b>Автор:</b>\r\n                                ");
            __builder.AddContent(18, 
#nullable restore
#line 20 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\FetchData.razor"
                                 eve.owner

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                            ");
            __builder.OpenElement(21, "li");
            __builder.AddMarkupContent(22, "\r\n                                ");
            __builder.AddMarkupContent(23, "<b>Категория:</b>\r\n                                ");
            __builder.AddContent(24, 
#nullable restore
#line 24 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\FetchData.razor"
                                 eve.category

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "li");
            __builder.AddMarkupContent(28, "\r\n                                ");
            __builder.AddMarkupContent(29, "<b>Место проведения:</b>\r\n                                ");
            __builder.AddContent(30, 
#nullable restore
#line 28 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\FetchData.razor"
                                 eve.location

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.AddMarkupContent(36, "<div class=\"blog-photo\">\r\n                    <img src=\"Events.jpg\" asp-append-version=\"true\" alt=\"Image\">\r\n                </div>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "blog-body");
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "blog-title");
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "h1");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "href", "/EventDetalies");
            __builder.AddContent(47, 
#nullable restore
#line 41 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\FetchData.razor"
                                                  eve.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "blog-desc");
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "p");
            __builder.AddContent(54, 
#nullable restore
#line 44 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\FetchData.razor"
                        eve.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.AddMarkupContent(57, @"<div class=""blog-tags"">
                    <ul>
                        <li><a href=""#"">css</a></li>
                        <li><a href=""#"">web design</a></li>
                        <li><a href=""#"">codepen</a></li>
                    </ul>
                </div>
            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 55 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\FetchData.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\FetchData.razor"
     
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "    ");
            __builder.AddMarkupContent(61, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 60 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\FetchData.razor"
       
    private IEnumerable<EventsForecast> events;

    protected override async Task OnInitializedAsync()
    {
        events = await EventsService.GetEvents();
    }
    /*
     protected override async Task OnInitializedAsync()
    {
        events = await apiService.GetEvents();
    }*/

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IEventsServices apiService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EventsForecastService EventsService { get; set; }
    }
}
#pragma warning restore 1591
