using System;
using Microsoft.AspNetCore.Components;

namespace NullableParam.Shared
{
    public class BindToComponent_TypeChecked_WithMatchingProperties : ComponentBase
    {
        [Parameter]
        public int Value { get; set; }

        [Parameter]
        public Action<int> ValueChanged { get; set; }
    }
}