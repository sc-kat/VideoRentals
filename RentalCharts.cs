namespace CassetteRentals
{
    public partial class RentalCharts : UserControl
    {
        private Dictionary<string, int> rentalsData = new();

        public RentalCharts()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // pentru redare fluidă
        }

        public void LoadChartData(Dictionary<string, int> data)
        {
            rentalsData = data;
            this.Invalidate(); // redesenează
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (rentalsData == null || rentalsData.Count == 0)
                return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int margin = 60;
            int width = this.Width - 2 * margin;
            int height = this.Height - 2 * margin;

            int barWidth = Math.Max(20, width / rentalsData.Count);
            int maxVal = rentalsData.Values.Max();

            int i = 0;
            foreach (var pair in rentalsData)
            {
                int barHeight = (int)((pair.Value / (float)maxVal) * height);
                int x = margin + i * barWidth;
                int y = this.Height - margin - barHeight;

                // bar
                Rectangle barRect = new Rectangle(x, y, barWidth - 10, barHeight);
                g.FillRectangle(Brushes.SteelBlue, barRect);

                // value
                var valueSize = g.MeasureString(pair.Value.ToString(), this.Font);
                g.DrawString(pair.Value.ToString(), this.Font, Brushes.Black, x + (barWidth - 10 - valueSize.Width) / 2, y - valueSize.Height - 5);

                // label
                var labelSize = g.MeasureString(pair.Key, this.Font);
                g.DrawString(pair.Key, this.Font, Brushes.Black, x + (barWidth - 10 - labelSize.Width) / 2, this.Height - margin + 5);

                i++;
            }
        }

    }
}
