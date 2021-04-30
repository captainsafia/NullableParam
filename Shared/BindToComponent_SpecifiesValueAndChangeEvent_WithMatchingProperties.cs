using System;
using Microsoft.AspNetCore.Components;

namespace NullableParam.Shared
{
    public class BindToComponent_SpecifiesValueAndChangeEvent_WithMatchingProperties : ComponentBase
    {
        [Parameter]
        public int Value { get; set; }

        [Parameter]
        public Action<int> OnChanged { get; set; }
    }
}