#pragma checksum "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\EventDetalies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "195c9d7c2e351001271c7dd137d5515e295efbe9"
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
#line 4 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\EventDetalies.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EventDetalies/{name}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/EventDetalies")]
    public partial class EventDetalies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\EventDetalies.razor"
 if (eve != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "bloc-container-event");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "bloc-header-event");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "bloc-owner-event");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "ul");
            __builder.AddMarkupContent(11, "\r\n                    <p class=\"owner-photo\"></p>\r\n                    ");
            __builder.OpenElement(12, "li");
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.AddMarkupContent(14, "<b>Автор:</b>\r\n                        ");
            __builder.AddContent(15, 
#nullable restore
#line 16 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\EventDetalies.razor"
                         eve.owner

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "li");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.AddMarkupContent(20, "<b>Категория:</b>\r\n                        ");
            __builder.AddContent(21, 
#nullable restore
#line 20 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\EventDetalies.razor"
                         eve.category

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "li");
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.AddMarkupContent(26, "<b>Место проведения:</b>\r\n                        ");
            __builder.AddContent(27, 
#nullable restore
#line 24 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\EventDetalies.razor"
                         eve.location

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.AddMarkupContent(32, "<div class=\"bloc-photo\">\r\n                <div class=\"bloc-photo-event col-sm-9\">\r\n                    <img src=\"Events.jpg\" asp-append-version=\"true\" alt=\"Image\">\r\n                </div>\r\n                <div class=\"col-sm-3 bloc-photoalbum-event\">\r\n                    <div class=\"mt-4\">\r\n                        <label for=\"PhotoAlbum\">Фотоальбом</label>\r\n                        <ul>\r\n                            <li>\r\n                                <img src=\"s375.webp\" asp-append-version=\"true\" alt=\"Image\">\r\n                            </li>\r\n                            <li>\r\n                                <img src=\"s375.webp\" asp-append-version=\"true\" alt=\"Image\">\r\n                            </li>\r\n                            <li>\r\n                                <img src=\"s375.webp\" asp-append-version=\"true\" alt=\"Image\">\r\n                            </li>\r\n                            <li>\r\n                                <img src=\"s375.webp\" asp-append-version=\"true\" alt=\"Image\">\r\n                            </li>\r\n                            <li>\r\n                                <img src=\"s375.webp\" asp-append-version=\"true\" alt=\"Image\">\r\n                            </li>\r\n                            <li>\r\n                                <img src=\"s375.webp\" asp-append-version=\"true\" alt=\"Image\">\r\n                            </li>\r\n                            <li>\r\n                                <img src=\"s375.webp\" asp-append-version=\"true\" alt=\"Image\">\r\n                            </li>\r\n                            <li>\r\n                                <img src=\"s375.webp\" asp-append-version=\"true\" alt=\"Image\">\r\n                            </li>\r\n                            <li>\r\n                                <img src=\"s375.webp\" asp-append-version=\"true\" alt=\"Image\">\r\n                            </li>\r\n                            <li>\r\n                                <img src=\"s375.webp\" asp-append-version=\"true\" alt=\"Image\">\r\n                            </li>\r\n                            <li>\r\n                                <img src=\"s375.webp\" asp-append-version=\"true\" alt=\"Image\">\r\n                            </li>\r\n                            <li>\r\n                                <img src=\"s375.webp\" asp-append-version=\"true\" alt=\"Image\">\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n                </div>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "bloc-body-event");
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "bloc-titel-event");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "h1");
            __builder.AddContent(41, 
#nullable restore
#line 79 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\EventDetalies.razor"
                         eve.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "bloc-desc-event");
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "p");
            __builder.AddContent(48, 
#nullable restore
#line 82 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\EventDetalies.razor"
                        eve.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n                ");
            __builder.AddMarkupContent(51, @"<div class=""bloc-button-event"">
                    <ul>
                        <li>
                            <p><a class=""btn-warning"">Подписатся на событие</a></p>
                        </li>
                    </ul>
                </div>
            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 94 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\EventDetalies.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "    ");
            __builder.AddMarkupContent(55, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 98 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\EventDetalies.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\EventDetalies.razor"
       

    [Parameter]
    public string name { get; set; }

    private EventsForecast eve;

    protected override async Task OnInitializedAsync()
    {
        eve = await EventsService.GetEvent(name);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EventsForecastService EventsService { get; set; }
    }
}
#pragma warning restore 1591
