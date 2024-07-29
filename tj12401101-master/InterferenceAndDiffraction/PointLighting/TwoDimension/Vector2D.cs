namespace PointLighting.TwoDimension
{
    public sealed record Vector2D(double X, double Y)
    {
        public double GetDistanceSquareBetween(Vector2D other)
        {
            var deltaX = this.X - other.X;
            var deltaY = this.Y - other.Y;
            return deltaX * deltaX + deltaY * deltaY;
        }
        public double GetDistanceBetween(Vector2D other)
        {
            return Math.Sqrt(this.GetDistanceSquareBetween(other));
        }
        public static Vector2D operator +(Vector2D left, Vector2D right)
        {
            return new Vector2D(left.X + right.X, left.Y + right.Y);
        }
        public static Vector2D operator -(Vector2D left, Vector2D right)
        {
            return new Vector2D(left.X - right.X, left.Y - right.Y);
        }
        public static Vector2D operator *(Vector2D left, double right)
        {
            return new Vector2D(left.X * right, left.Y * right);
        }
        public static Vector2D operator *(double left, Vector2D right)
        {
            return new Vector2D(right.X * left, right.Y * left);
        }
        public static Vector2D operator /(Vector2D left, double right)
        {
            return new Vector2D(left.X / right, left.Y / right);
        }
    }
}
