using System;
using Microsoft.AspNetCore.Components;

namespace NullableParam.Shared
{
    public class ChildComponent_WithExplicitEventHandler : ComponentBase
    {
        [Parameter]
        public Action<EventArgs> OnClick { get; set; }

        protected override void OnAfterRender(bool firstRender)
        {
            System.Console.WriteLine("ChildComponent_WithExplicitEventHandler");
            OnClick(new EventArgs());
        }
    }
}