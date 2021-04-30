using System;
using Microsoft.AspNetCore.Components;

namespace NullableParam.Shared
{
    public class RazorTemplate_Generic_AsComponentParameter : ComponentBase
    {
        [Parameter] public RenderFragment<Person> PersonTemplate { get; set; }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}