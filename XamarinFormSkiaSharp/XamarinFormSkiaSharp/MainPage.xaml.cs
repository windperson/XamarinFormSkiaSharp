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

            var circleFill = new SkiaSharp.SKPaint
            {
                IsAntialias = true,
                Style = SKPaintStyle.Fill,
                Color = SKColors.Blue
            };

            canvas.DrawCircle(300, 200, 100, circleFill);

        }
    }
}
