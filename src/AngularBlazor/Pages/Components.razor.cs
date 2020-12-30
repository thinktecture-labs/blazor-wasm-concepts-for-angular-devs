using System;

namespace AngularBlazor.Pages
{
    public partial class Components
    {
        private string Text { get; set; } = "World";
        private int Counter { get; set; } = 0;

        private void ButtonClicked(string value)
        {
            Text = value;
            Counter++;
        }
    }
}