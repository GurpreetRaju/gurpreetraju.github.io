using ShineBlazor.Components.Theme;

namespace GurpreetRaju.Layout
{
    /// <summary>
    /// Shine Theme.
    /// </summary>
    public class GurpreetTheme : DefaultTheme
    {
        public GurpreetTheme()
        {
            Light = new LightPalette();
            Dark = new DarkPalette();
        }
    }

    /// <summary>
    /// The light palette.
    /// </summary>
    public class LightPalette : Palette
    {
        /// <summary>
        /// Initializes the light palette.
        /// </summary>
        public LightPalette()
        {
            Primary = new ThemeColorSet
            {
                Color = "#26a69a",
                Rgb = "38, 166, 154",
                BackgroundSubtle = "#386cbc",
                Border = "#186e66"
            };
            Secondary = new ThemeColorSet
            {
                Color = "#FF5666",
                Rgb = "255, 86, 102",
            };
            TertiaryBackgroundHex = "#4f359b";
            TertiaryColorRgb = "#FFF";
            TertiaryBackgroundRgb = "79, 53, 155";
        }
    }

    /// <summary>
    /// The light palette.
    /// </summary>
    public class DarkPalette : Palette
    {
        /// <summary>
        /// Initializes the dark palette.
        /// </summary>
        public DarkPalette()
        {
            Primary = new ThemeColorSet
            {
                Color = "#26a69a",
                Rgb = "38, 166, 154",
                BackgroundSubtle = "#08539e"
            };
            Secondary = new ThemeColorSet
            {
                Color = "#FF5666",
                Rgb = "255, 86, 102",
            };
            TertiaryBackgroundHex = "#4f359b";
            TertiaryColorRgb = "#FFF";
            TertiaryBackgroundRgb = "79, 53, 155";
        }
    }
}
