#pragma checksum "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "924d90041958bfadd3c17e50ecd62b93a75d948b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, @"<div>
        <header>
            <nav class=""navbar navbar-expand-md navbar-dark bg-dark"">
                <a class=""navbar-brand"" href=""#"">Events</a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarCollapse"" aria-controls=""navbarCollapse"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarCollapse"">
                    <ul class=""navbar-nav mr-auto"">
                        <li class=""nav-item active"">
                            <a class=""nav-link"" href=""/"">Главная </a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""/AllEvents"">Все События</a>
                        </li>
                    </ul>
                   <a class=""btn btn-outline-success my-2 my-sm-0"" role=""button"" href=""/SingIn"">Sing in</a>
                </div>
            </nav>
        </header>
    </div>

    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "content px-4");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddContent(7, 
#nullable restore
#line 31 "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
