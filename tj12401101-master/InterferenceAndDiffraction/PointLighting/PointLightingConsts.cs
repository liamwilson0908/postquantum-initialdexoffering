namespace PointLighting
{
    public sealed record PointLightingConsts(double Pi, double LightSpeed)
    {
        public static PointLightingConsts Default { get; } = new(
            Pi: 3.1415926535897931,
            LightSpeed: 299792458);
    }
}
