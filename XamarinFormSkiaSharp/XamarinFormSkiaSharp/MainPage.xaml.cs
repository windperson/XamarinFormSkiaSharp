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
#if DEBUG
#if !WINDOWS_UWP
			Console.WriteLine("Scale = {0}", scale);
#else
			System.Diagnostics.Debug.WriteLine("Scale = {0}", scale);
#endif
#endif
			canvas.Scale(scale);


			canvas.DrawCircle(100, 100, 100, new SKPaint
			{
				IsAntialias = true,
				Style = SKPaintStyle.Stroke,
				StrokeWidth = 1,
				Color = SKColors.Blue
			});

			canvas.DrawCircle(100, 100, 80, new SKPaint
			{
				IsAntialias = true,
				Style = SKPaintStyle.Stroke,
				StrokeWidth = 3,
				Color = SKColors.DarkRed
			});

			canvas.DrawCircle(100, 100, 50, new SKPaint
			{
				IsAntialias = true,
				Style = SKPaintStyle.Fill,
				Color = SKColors.DarkCyan
			});

        }
    }
}
