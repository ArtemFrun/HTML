#pragma checksum "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\SingUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91f2342410da84552743531253c9edb109977e05"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\SingUp.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class SingUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\tjomka777tjomka777\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\SingUp.razor"
  
    private User user;

    protected override Task OnInitializedAsync()
    {
        user = new User();
        return base.OnInitializedAsync();
    }

    private async Task Register()
    {
        await apiService.Create(user);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.IUserRegister apiService { get; set; }
    }
}
#pragma warning restore 1591
