#pragma checksum "/Users/captainsafia/Verifications/NullableParam/Pages/Index.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "aed74a1620935419440f2470a1a44940dcda6b2d5496e54886718e9d054985df"
// <auto-generated/>
#pragma warning disable 1591
namespace NullableParam.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>BindToComponent_SpecifiesValueAndChangeEvent_WithMatchingProperties</h1>\r\n\r\n");
            __builder.OpenComponent<NullableParam.Shared.BindToComponent_SpecifiesValueAndChangeEvent_WithMatchingProperties>(1);
            __builder.AddAttribute(2, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "/Users/captainsafia/Verifications/NullableParam/Pages/Index.razor"
                                                                                  ParentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnChanged", (System.Action<System.Int32>)(__value => ParentValue = __value));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.AddMarkupContent(5, "<h1>ChildComponent_WithLambdaEventHandler</h1>\r\n\r\n");
            __builder.OpenComponent<NullableParam.Shared.ChildComponent_WithLambdaEventHandler>(6);
            __builder.AddAttribute(7, "OnClick", (System.Action<System.EventArgs>)(
#nullable restore
#line 9 "/Users/captainsafia/Verifications/NullableParam/Pages/Index.razor"
                                                  e => { Increment(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.AddMarkupContent(9, "<h1>BodyAndAttributeChildContent</h1>");
#nullable restore
#line 13 "/Users/captainsafia/Verifications/NullableParam/Pages/Index.razor"
   RenderFragment<string> header = (context) => 

#line default
#line hidden
#nullable disable
            (__builder2) => {
                __builder2.OpenElement(10, "div");
                __builder2.AddContent(11, 
#nullable restore
#line 13 "/Users/captainsafia/Verifications/NullableParam/Pages/Index.razor"
                                                       context.ToLowerInvariant()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
#nullable restore
#line 13 "/Users/captainsafia/Verifications/NullableParam/Pages/Index.razor"
                                                                                       ; 

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<NullableParam.Shared.BodyAndAttributeChildContent>(12);
            __builder.AddAttribute(13, "Header", (Microsoft.AspNetCore.Components.RenderFragment<System.String>)(
#nullable restore
#line 14 "/Users/captainsafia/Verifications/NullableParam/Pages/Index.razor"
                                      header

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n    Some Content\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.AddMarkupContent(17, "<h1>RazorTemplate_Generic_AsComponentParameter</h1>");
#nullable restore
#line 20 "/Users/captainsafia/Verifications/NullableParam/Pages/Index.razor"
   RenderFragment<Person> template = (person) => 

#line default
#line hidden
#nullable disable
            (__builder2) => {
                __builder2.OpenElement(18, "div");
                __builder2.AddContent(19, 
#nullable restore
#line 20 "/Users/captainsafia/Verifications/NullableParam/Pages/Index.razor"
                                                        person.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
#nullable restore
#line 20 "/Users/captainsafia/Verifications/NullableParam/Pages/Index.razor"
                                                                         ; 

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<NullableParam.Shared.RazorTemplate_Generic_AsComponentParameter>(20);
            __builder.AddAttribute(21, "PersonTemplate", (Microsoft.AspNetCore.Components.RenderFragment<NullableParam.Shared.Person>)(
#nullable restore
#line 21 "/Users/captainsafia/Verifications/NullableParam/Pages/Index.razor"
                                                             template

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n\r\n");
            __builder.AddMarkupContent(23, "<h1>BindToComponent_TypeChecked_WithMatchingProperties</h1>\r\n\r\n");
            __builder.OpenComponent<NullableParam.Shared.BindToComponent_TypeChecked_WithMatchingProperties>(24);
            __builder.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "/Users/captainsafia/Verifications/NullableParam/Pages/Index.razor"
                                                                 ParentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "ValueChanged", (System.Action<System.Int32>)(__value => ParentValue = __value));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n\r\n");
            __builder.OpenComponent<NullableParam.Shared.ChildComponent_WithExplicitEventHandler>(28);
            __builder.AddAttribute(29, "OnClick", (System.Action<System.EventArgs>)(
#nullable restore
#line 27 "/Users/captainsafia/Verifications/NullableParam/Pages/Index.razor"
                                                   IncrementWithEventArgs

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "/Users/captainsafia/Verifications/NullableParam/Pages/Index.razor"
       
    public int ParentValue { get; set; } = 42;

    private int counter;
    private void Increment() {
        System.Console.WriteLine("Incrementing inside Increment.");
        counter++;
    }

    private void IncrementWithEventArgs(EventArgs args)
    {
       System.Console.WriteLine("Incrementing inside IncrementWithEventArgs.");
        counter++; 
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
