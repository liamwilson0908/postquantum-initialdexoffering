using System.Collections.Immutable;

namespace PointLighting.TwoDimension
{
    public sealed class LightedSpace2D
    {
        public double Refractivity { get; }
        public ImmutableArray<IdealPointLight2D> Lights { get; }

        public LightedSpace2D(params IdealPointLight2D[] lights) : this(1, lights)
        { }

        public LightedSpace2D(double refractivity, IEnumerable<IdealPointLight2D> lights)
        {
            this.Refractivity = refractivity;
            this.Lights = lights.ToImmutableArray();
        }

        public double GetIntensityAt(Vector2D position, double wavelength, double delta = 1E-6)
        {
            delta = Math.Abs(delta);
            var lower = wavelength - delta;
            var upper = wavelength + delta;

            var lightVectors =
                from light in Lights
                where lower < light.Wavelength && light.Wavelength < upper
                let r = Math.Sqrt(light.GetIntensityAt(position))
                let theta = light.GetPhaseAt(position, time: 0, this.Refractivity)
                select new {
                    Vector = new Vector2D(r * Math.Cos(theta), r * Math.Sin(theta)),
                    Polarization = light.PolarizationDirection
                };

            var first = lightVectors.FirstOrDefault();
            if(first is null)
                return 0;
            Vector2D polarization = first.Polarization;
            Vector2D sum = first.Vector;
            foreach (var light in lightVectors.Skip(1))
            {
                if (polarization != light.Polarization)
                    throw new NotSupportedException("暂不支持振动方向不平行的情况");
                sum += light.Vector;
            }
            return sum.GetDistanceSquareBetween(new Vector2D(0, 0));
        }
    }
}
