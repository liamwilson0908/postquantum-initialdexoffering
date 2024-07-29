using PointLighting.TwoDimension;

namespace YoungsDoubleSlitInterference
{
    public sealed class Screen<T>
    {
        public delegate Vector2D FunctionOfScreen(T parameter);

        private readonly FunctionOfScreen function;
        private readonly T[] parameters;

        public Screen(FunctionOfScreen screen, IEnumerable<T> parameters)
        {
            this.function = screen;
            this.parameters = parameters.ToArray();
        }

        public IEnumerable<(T Parameter, Vector2D Position, double Intensity)> Image(
            LightedSpace2D space, double wavelength)
        {
            foreach (var parameter in this.parameters)
            {
                var position = function(parameter);
                var intensity = space.GetIntensityAt(position, wavelength);
                yield return (parameter, position, intensity);
            }
        }
    }
}
