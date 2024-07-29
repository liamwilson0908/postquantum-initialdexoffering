namespace PointLighting.TwoDimension
{
    public sealed class IdealPointLight2D
    {
        public required Vector2D Position { get; init; }
        public required double Wavelength { get; init; }
        public required Vector2D PolarizationDirection { get; init; }

        /// <summary>
        /// 在零时刻时零距离处的相位。
        /// </summary>
        public required double Phase { get; init; }

        /// <summary>
        /// 与光源相距一个单位处的光照强度。
        /// </summary>
        public required double Intensity { get; init; }

        public double GetPhaseAt(
            Vector2D position, double time = 0, double refractivity = 1,
            PointLightingConsts? consts = null)
        {
            consts = consts ?? PointLightingConsts.Default;

            var distance = this.Position.GetDistanceBetween(position);
            var d1 = 2 * consts.Pi * refractivity * distance / Wavelength;
            var d2 = 2 * consts.Pi * consts.LightSpeed * time / Wavelength;
            return Phase + d1 + d2;
        }

        public double GetIntensityAt(Vector2D position)
        {
            var distanceSquare = this.Position.GetDistanceSquareBetween(position);
            return this.Intensity / distanceSquare;
        }
    }
}
