namespace GurpreetRaju.Service
{
    /// <summary>
    /// HSL color generator.
    /// </summary>
    public class HslColorGenerator(int? fixedSaturation = null, int? fixedLightness = null)
    {
        private static readonly Random _random = new Random();

        /// <summary>
        /// Generate HSL color code e.g. 100,30,46
        /// </summary>
        /// <returns></returns>
        public string GenerateHSL()
        {
            int hue = _random.Next(0, 360);
            int saturation = fixedSaturation ?? _random.Next(0, 101);
            int lightness = fixedLightness ?? _random.Next(0, 101);

            return $"{hue},{saturation}%,{lightness}%";
        }
    }
}
