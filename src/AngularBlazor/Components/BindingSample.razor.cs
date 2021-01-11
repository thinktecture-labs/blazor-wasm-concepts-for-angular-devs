using Microsoft.AspNetCore.Components;

namespace AngularBlazor.Components
{
    public partial class BindingSample
    {
        [Parameter]
        public string MyParameter { get; set; }
        
        [Parameter]
        public EventCallback<string> MyParameterChanged { get; set; }

        private void ButtonClick()
        {
            MyParameterChanged.InvokeAsync(MyParameter);
        }
    }
}