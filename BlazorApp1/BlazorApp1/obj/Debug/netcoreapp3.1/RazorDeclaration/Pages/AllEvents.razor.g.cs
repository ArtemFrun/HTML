#pragma checksum "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\AllEvents.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0800a5e9005af9ed0e04d13222e71f937164954"
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
#nullable restore
#line 3 "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\AllEvents.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AllEvents")]
    public partial class AllEvents : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Users\Group-bbv182\Documents\GitHub\HTML\BlazorApp1\BlazorApp1\Pages\AllEvents.razor"
       
    private IEnumerable<EventsForecast> events;

    protected override async Task OnInitializedAsync()
    {
        events = await EventsService.GetEvents();
    }

    /* protected override async Task OnInitializedAsync()
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
