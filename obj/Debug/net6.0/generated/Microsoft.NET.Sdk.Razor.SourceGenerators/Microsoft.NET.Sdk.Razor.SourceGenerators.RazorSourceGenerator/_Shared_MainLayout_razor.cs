#pragma checksum "/Users/captainsafia/Verifications/NullableParam/Shared/MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "96aceea3f9725f64bf3f541b7daadbd0cd895d0561857e344646f9f4af6a111b"
// <auto-generated/>
#pragma warning disable 1591
namespace NullableParam.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/captainsafia/Verifications/NullableParam/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/captainsafia/Verifications/NullableParam/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/captainsafia/Verifications/NullableParam/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/captainsafia/Verifications/NullableParam/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/captainsafia/Verifications/NullableParam/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/captainsafia/Verifications/NullableParam/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/captainsafia/Verifications/NullableParam/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/captainsafia/Verifications/NullableParam/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/captainsafia/Verifications/NullableParam/_Imports.razor"
using NullableParam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/captainsafia/Verifications/NullableParam/_Imports.razor"
using NullableParam.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-usr5vxcihh");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-usr5vxcihh");
            __builder.OpenComponent<NullableParam.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-usr5vxcihh");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-usr5vxcihh><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-usr5vxcihh>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-usr5vxcihh");
            __builder.AddContent(15, 
#nullable restore
#line 14 "/Users/captainsafia/Verifications/NullableParam/Shared/MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
