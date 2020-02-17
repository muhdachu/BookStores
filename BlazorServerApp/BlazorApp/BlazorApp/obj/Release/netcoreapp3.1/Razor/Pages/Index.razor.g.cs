#pragma checksum "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48777cf5d7e4d47506cd708c7fe87de1c7c4b717"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\_Imports.razor"
using CuriousDriveRazorLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Index.razor"
using BlazorServerApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Index.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Index.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 17 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Index.razor"
 if (IsUserAuthenticated)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "h3");
            __builder.OpenElement(2, "b");
            __builder.AddContent(3, 
#nullable restore
#line 19 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Index.razor"
            user.Identity.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(4, " is logged in!!!");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    <br>\r\n    ");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Is Publisher : ");
            __builder.AddContent(8, 
#nullable restore
#line 21 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Index.razor"
                       IsPublisher

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "p");
            __builder.AddContent(11, "Is Senior Employee : ");
            __builder.AddContent(12, 
#nullable restore
#line 22 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Index.razor"
                             IsSeniorEmployee

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 23 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.AddMarkupContent(15, "<h3><b>User is logged out</b></h3>\r\n");
#nullable restore
#line 27 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Data\CuriousDrive\BookStores\BlazorServerApp\BlazorApp\BlazorApp\Pages\Index.razor"
       

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    ClaimsPrincipal user;

    bool IsUserAuthenticated;
    bool IsPublisher;
    bool IsSeniorEmployee;

    protected override async Task OnInitializedAsync()
    {
        user = (await authenticationStateTask).User;

        if (user.Identity.IsAuthenticated)
            IsUserAuthenticated = true;

        if (user.IsInRole("Publisher"))
            IsPublisher = true;

        if ((await authorizationService.AuthorizeAsync(user, "SeniorEmployee")).Succeeded)
            IsSeniorEmployee = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorizationService authorizationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
