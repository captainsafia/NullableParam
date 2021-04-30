using System;
using Microsoft.AspNetCore.Components;

namespace NullableParam.Shared
{
    public class BodyAndAttributeChildContent : ComponentBase
    {
        [Parameter]
        public RenderFragment<string> Header { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public RenderFragment Footer { get; set; }
    }
}