using PointLighting.TwoDimension;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using YoungsDoubleSlitInterference;

//
Console.WriteLine("运行中……");

// 1. 创建 LightedSpace2D 空间
var light1 = new IdealPointLight2D() {
    Phase = 0,
    Intensity = 1,
    PolarizationDirection = new Vector2D(0, 0),
    Position = new Vector2D(0, 2E-3),
    Wavelength = 550E-9,
};

var light2 = new IdealPointLight2D() {
    Phase = 0,
    Intensity = 1,
    PolarizationDirection = new Vector2D(0, 0),
    Position = new Vector2D(0, -2E-3),
    Wavelength = 550E-9,
};

var space = new LightedSpace2D(light1, light2);

// 2. 创建两个 Screen 光屏
const int size = 5000;

var screen1 = new Screen<int>((t) => {
    double length = (t - size / 2) * 0.000001;
    return new Vector2D(2 + length / 2, length * Math.Sqrt(3) / 2);
}, Enumerable.Range(0, size));

var screen2 = new Screen<int>((t) => {
    double length = (t - size / 2) * 0.000001;
    return new Vector2D(2, length);
}, Enumerable.Range(0, size));


// 3. 绘制用眼观察 screen1 时大致所能看到的图样
using (Image<Rgba32> output = new(size, 1000))
{
    output.Mutate(p => {
        _ = p.BackgroundColor(Color.Black);
    });

    var color = Color.Green;
    foreach (var current in screen1.Image(space, 550E-9))
    {
        output.Mutate((p) => {
            _ = p.DrawLines(
                color.WithAlpha((float)current.Intensity),
                thickness: 1,
                new Point(current.Parameter, 0),
                new Point(current.Parameter, 1000));
        });
    }
    output.SaveAsPng("out1.png");
}


// 4. 绘制两种光屏上光照强度的图像
using (Image<Rgba32> output = new(size, 1000))
{
    {
        var image = screen2.Image(space, 550E-9)
            .Select(i => new PointF(i.Parameter, (float)(i.Intensity * 800 + 100)));
        var last = image.First();
        foreach (var current in image.Skip(1))
        {
            output.Mutate((p) => {
                _ = p.DrawLines(Color.Blue, 5, last, current);
            });
            last = current;
        }
    }

    {
        var image = screen1.Image(space, 550E-9)
            .Select(i => new PointF(i.Parameter, (float)(i.Intensity * 800 + 100)));
        var last = image.First();
        foreach (var current in image.Skip(1))
        {
            output.Mutate((p) => {
                _ = p.DrawLines(Color.Black, 5, last, current);
            });
            last = current;
        }
    }

    output.Mutate(c => {
        _ = c.Rotate(RotateMode.Rotate180);
    });
    output.SaveAsPng("out2.png");
}

//
Console.WriteLine("文件已生成。可以按回车键退出。");
Console.ReadKey();