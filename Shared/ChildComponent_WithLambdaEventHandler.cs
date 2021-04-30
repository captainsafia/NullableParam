using System;
using Microsoft.AspNetCore.Components;

namespace NullableParam.Shared
{
    public class ChildComponent_WithLambdaEventHandler : ComponentBase
    {
        [Parameter]
        public Action<EventArgs> OnClick { get; set; }

        protected override void OnAfterRender(bool firstRender)
        {
            OnClick(new EventArgs());
        }
    }
}