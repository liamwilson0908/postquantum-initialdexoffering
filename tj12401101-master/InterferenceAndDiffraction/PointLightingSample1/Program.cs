using PointLighting.TwoDimension;
using OxyPlot;
using OxyPlot.Series;

Console.WriteLine("运行中……");

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

var plot = new PlotModel();
plot.Series.Add(new FunctionSeries(
    length => space.GetIntensityAt(new Vector2D(2, length), 550E-9),
    0, 0.001, 0.0000001));

plot.Series.Add(new FunctionSeries(
    length => space.GetIntensityAt(new Vector2D(2, length + 1.0002), 550E-9),
    0, 0.001, 0.0000001));

var svgExporter = new SvgExporter { Width = 1000, Height = 1000 };
using (var file = File.Create("out.svg"))
    svgExporter.Export(plot, file);

Console.WriteLine("文件已生成。可以按回车键退出。");
Console.ReadKey();