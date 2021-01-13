using MudBlazor;

namespace AngularBlazor.Shared
{
    public partial class MainLayout
    {
        private bool _drawerOpen = true;

        private readonly MudTheme _customTheme = new()
        {
            Palette = new Palette()
            {
                Primary = "#5C2D91",
                AppbarBackground = "#5C2D91"
            }
        };

        private void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }
    }
}