using System;
using Microsoft.AspNetCore.Components;

namespace AngularBlazor.Components
{
    public partial class SampleComponent
    {
        [Parameter] public string MyParameter { get; set; }

        [Parameter] public EventCallback ButtonClicked { get; set; }
        private void ButtonClick()
        {
            ButtonClicked.InvokeAsync();
        }
    }
}