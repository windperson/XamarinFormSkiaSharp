using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace XamarinFormSkiaSharp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SKCanvasView_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            //clear SKCanvas first.
            var surface = e.Surface;
            var canvas = surface.Canvas;
            canvas.Clear();

			var contaienr = sender as SKCanvasView;
			if(contaienr == null) { return; }

			var scale = (float)(e.Info.Width / contaienr.Width);
			Console.WriteLine("Scale = {0}", scale);
			canvas.Scale(scale);

			var circleFill = new SkiaSharp.SKPaint
            {
                IsAntialias = true,
                Style = SKPaintStyle.Stroke,
                Color = SKColors.Blue
            };

            canvas.DrawCircle(100, 100, 100, circleFill);

        }
    }
}
