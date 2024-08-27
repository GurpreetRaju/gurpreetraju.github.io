using MudBlazor;

namespace GurpreetRaju.Layout
{
    /// <summary>
    /// Custom theme.
    /// </summary>
    public class GurpreetTheme : MudTheme
    {
        
        public GurpreetTheme() 
        {
            PaletteLight = new PaletteLight()
            {
                PrimaryContrastText = Colors.Shades.White,
                Primary = Colors.Teal.Default,
                TextPrimary = Colors.Shades.Black,
                Secondary = Colors.Teal.Accent3,
                TextSecondary = Colors.Shades.White,
                AppbarBackground = Colors.Teal.Lighten1,
                AppbarText = Colors.Teal.Darken4,
                DrawerBackground = Colors.Teal.Lighten1,
                DrawerText = Colors.Teal.Darken4,
                DrawerIcon = Colors.Teal.Darken4,
                Background = Colors.Teal.Lighten5,
                HoverOpacity = 0.32
            };
            PaletteDark = new PaletteDark()
            {
                PrimaryContrastText = Colors.Shades.White,
                Primary = Colors.Teal.Default,
                Secondary = Colors.Teal.Accent3,
                TextSecondary = Colors.Shades.White,
                AppbarBackground = Colors.Teal.Darken4,
                AppbarText = Colors.Shades.White,
                DrawerBackground = Colors.Teal.Darken4,
                DrawerText = Colors.Shades.White
            };

            LayoutProperties = new LayoutProperties()
            {
                DrawerWidthLeft = "260px",
                DrawerWidthRight = "300px",                
            };
        }
    }
}
