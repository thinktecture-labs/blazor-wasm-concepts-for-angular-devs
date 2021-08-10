using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Routing;

namespace AngularBlazor
{
    public partial class App
    {
        private async Task OnNavigateAsync(NavigationContext args)
        {
            Console.WriteLine($"Navigation to: {args.Path}");
        }
    }
}