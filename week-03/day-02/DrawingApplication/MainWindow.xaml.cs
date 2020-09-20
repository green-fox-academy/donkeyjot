using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using SharpDX.WIC;
using SkiaSharp;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            // draw from here

            foxDraw.SetFillColor(Colors.White);

            RectangleFractal(foxDraw, 10, 10, 300);
        }

        private static void RectangleFractal(FoxDraw foxDraw, double x, double y, double size)
        {
            foxDraw.DrawRectangle(x, y, size, size);

            if (size <= 1)
            {
                return;
            }
            else
            {
                RectangleFractal(foxDraw, x + size / 3, y, size / 3);
                RectangleFractal(foxDraw, x + 2 * size / 3, y + size / 3, size / 3);
                RectangleFractal(foxDraw, x + size / 3, y + 2 * size / 3, size / 3);
                RectangleFractal(foxDraw, x, y + size / 3, size / 3);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}