using System.Windows.Forms.DataVisualization.Charting;

namespace FraunhoferDiffractionThroughMultipleSlits
{
    public partial class MainForm : Form
    {
        private readonly Chart chart;
        public MainForm()
        {
            InitializeComponent();

            this.chart = new Chart() {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            chart.ChartAreas.Add(new ChartArea());
            chart.Series.Add(new Series());
            chart.Series[0].ChartType = SeriesChartType.Line;
            this.panelOfChart.Controls.Add(chart);

            this.Load += (_, _) => this.buttonStartDrawing.PerformClick();
        }

        private void ButtonStartDrawingClick(object sender, EventArgs e)
        {
            this.labelForPrompt.Text = "";

            if (!double.TryParse(this.textBoxOfA0.Text, out double A0) ||
                !double.TryParse(this.textBoxOfa.Text, out double a) ||
                !double.TryParse(this.textBoxOfb.Text, out double b) ||
                !double.TryParse(this.textBoxOfLambda.Text, out double lambda) ||
                !int.TryParse(this.textBoxOfN.Text, out int N) ||
                !double.TryParse(this.textBoxOfStart.Text, out double start) ||
                !double.TryParse(this.textBoxOfEnd.Text, out double end) ||
                !int.TryParse(this.textBoxOfStepCount.Text, out int stepCount) ||
                !double.TryParse(this.textBoxOfUpper.Text, out double upper) ||
                !double.TryParse(this.textBoxOfLower.Text, out double lower))
            {
                this.labelForPrompt.Text = "无法解析输入的内容";
                return;
            }

            var calculator = new Calculator(A0, a, N, b, lambda);
            Draw(calculator, start, end, stepCount, upper, lower);
        }

        private void Draw(
            Calculator calculator, 
            double start, double end, int stepCount,
            double upper, double lower)
        {
            var chartPoints = chart.Series[0].Points;
            chartPoints.Clear();

            chart.ChartAreas[0].AxisY.Maximum = upper;
            chart.ChartAreas[0].AxisY.Minimum = lower;

            var step = (end - start) / stepCount;
            for (int i = 0; i < stepCount; i++)
            {
                var x = start + i * step;
                _ = chartPoints.AddXY(x, calculator.ITheta(x));
            }
        }

        private void ButtonSaveImageClick(object sender, EventArgs e)
        {
            if (this.saveImageDialog.ShowDialog() is DialogResult.OK)
                this.chart.SaveImage(this.saveImageDialog.FileName, ChartImageFormat.Png);
        }
    }
}