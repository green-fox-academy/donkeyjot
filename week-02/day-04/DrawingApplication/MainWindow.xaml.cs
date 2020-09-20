using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

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

            //LineInTheMiddle(foxDraw);
            //RandomColor();
            //ColoredBox(foxDraw);
            //Diagonals(foxDraw);
            //for (int i = 0; i < 3; i++)
            //{
            //    GoToCenter(foxDraw, 100 + i * 100, 100);
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    HorizontalLines(foxDraw, 100, 100 + i * 100);
            //}
            //CenteredSquare(foxDraw);
            //FourRectangle(foxDraw);
            Triangles(foxDraw, 300.0, 20);


        }
        private static Color RandomColor()
        {
            var list = new List<Color> { Colors.LightGray, Colors.LightSlateGray,Colors.DeepSkyBlue,
                Colors.AliceBlue, Colors.Aqua, Colors.DarkGoldenrod, Colors.Lavender, Colors.MediumOrchid,
                Colors.PapayaWhip, Colors.Peru, Colors.Turquoise };
            var colorNumber = new Random().Next(0, list.Count());
            var color = list[colorNumber];
            return color;
        }
        private Point BeginningPoint()
        {
            return new Point(0, 0);
        }
        private Point Middlepoint()                //calculating the middle point of the canvas
        {
            var middleWidth = Width / 2;
            var middleHeigth = Height / 2;
            return new Point(middleWidth, middleHeigth);
        }
        private void LineInTheMiddle(FoxDraw FoxDraw)
        {
            // draw a red horizontal line to the canvas' middle.
            // draw a green vertical line to the canvas' middle.

            FoxDraw.SetStrokeColor(Colors.Red);
            FoxDraw.DrawLine(Middlepoint(), new Point(0, Width / 2));
            FoxDraw.SetStrokeColor(Colors.Green);
            FoxDraw.DrawLine(Middlepoint(), new Point(Height / 2, 0));
        }
        private void ColoredBox(FoxDraw foxDraw)
        {
            double startingCoordinateX = 50;
            double startingCoordinateY = 50;
            double length = 50;
            Point startingPoint = new Point(startingCoordinateX, startingCoordinateY);
            Point endingPoint = new Point(startingCoordinateX + length, startingCoordinateY + length);

            foxDraw.SetStrokeColor(RandomColor());
            foxDraw.DrawLine(startingPoint, new Point(50 + length, 50));

            foxDraw.SetStrokeColor(RandomColor());
            foxDraw.DrawLine(startingPoint, new Point(50, 50 + length));

            foxDraw.SetStrokeColor(RandomColor());
            foxDraw.DrawLine(new Point(50 + length, 50), endingPoint);

            foxDraw.SetStrokeColor(RandomColor());
            foxDraw.DrawLine(new Point(50, 50 + length), endingPoint);

            //for (int horizontal = 1; horizontal < 3; horizontal++)
            //{
            //    for (int vertical = 1; vertical < 3; vertical++) {
            //        double length = 50
            //        double x = 0 + length * horizontal;
            //        double y = 50 + (50 * j);
            //        double a = 100 - 50 * i;
            //        double b = 100 - 50 * j;
            //        foxDraw.SetStrokeColor(RandomColor());
            //        foxDraw.DrawLine(new Point(x, ), new Point(a, a));
            //    }
            //    for () { }

            //for (int vertical = 1; vertical < 3; vertical++)
            //{
            //    for (int horizontal = 0; horizontal < 2; horizontal++)
            //    {
            //        foxDraw.SetStrokeColor(RandomColor());

            //        if (vertical % 2 != 0)
            //        {
            //            foxDraw.DrawLine(startingPoint, new Point(length + length*horizontal);
            //        }
            //        else
            //        {
            //            foxDraw.DrawLine(new Point(50, 50 + length), endingPoint);
            //        }
            //    }
            //}
        }
        private void Diagonals(FoxDraw foxDraw)
        {
            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    double x = Width * i;
                    double y = Width * j;
                    double a = Width - Width * i;
                    double b = Width - Width * j;
                    Point start = new Point(x, y);
                    Point zero = new Point(0, 0);
                    if (start.Equals(zero))
                    {
                        foxDraw.SetStrokeColor(Colors.Green);
                    }
                    else
                    {
                        foxDraw.SetStrokeColor(Colors.Red);
                    }

                    foxDraw.DrawLine(start, new Point(a, b));
                }

            }

        }
        private void GoToCenter(FoxDraw foxDraw, double x, double y)
        {
            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Draw at least 3 lines with that function using a loop.
            Point center = new Point(Width / 2, Height / 2);
            foxDraw.DrawLine(new Point(x, y), center);
        }
        private void HorizontalLines(FoxDraw foxDraw, double x, double y)
        {
            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the foxDraw
            // and draws a 50 long horizontal line from that point.
            // Draw at least 3 lines with that function using a loop.
            foxDraw.DrawLine(new Point(x, y), new Point(x + 50, y));
        }
        private void CenteredSquare(FoxDraw foxDraw)
        {
            double rectangleSize = 10;
            double x = Width / 2 - rectangleSize / 2;
            double y = Height / 2 - rectangleSize / 2;

            foxDraw.DrawRectangle(x, y, rectangleSize, rectangleSize);
        }
        private void FourRectangle(FoxDraw foxDraw)
        {

        }
        private void Triangles(FoxDraw foxDraw, double sizeOfTriangle, double numberOfTriangles)
        {

            Point startPoint = new Point((Width - sizeOfTriangle) / 2, Height - ((Height - ((Math.Sqrt(3) / 2) * sizeOfTriangle)) / 2));
            Point endingPoint = new Point(Width - ((Width - sizeOfTriangle) / 2), Height - ((Height - ((Math.Sqrt(3) / 2) * sizeOfTriangle)) / 2));
            Point topPoint = new Point(startPoint.X + (sizeOfTriangle / 2), startPoint.Y - ((Math.Sqrt(3) / 2) * sizeOfTriangle));
            double smallTriangleSize = sizeOfTriangle / numberOfTriangles;

            double offset = ((Math.Sqrt(3) / 2) * smallTriangleSize);

            foxDraw.DrawLine(startPoint, endingPoint);
            foxDraw.SetStrokeColor(Colors.Red);
            for (double i = 0; i < ((Math.Sqrt(3) / 2) * sizeOfTriangle); i += offset)
            {
                foxDraw.DrawLine(startPoint, endingPoint);
                startPoint = new Point(startPoint.X + (smallTriangleSize / 2), startPoint.Y - offset);
                endingPoint = new Point(endingPoint.X - (smallTriangleSize / 2), endingPoint.Y - offset);
            }

            endingPoint = new Point(Width - ((Width - sizeOfTriangle) / 2), Height - ((Height - ((Math.Sqrt(3) / 2) * sizeOfTriangle)) / 2));
            startPoint = topPoint;

            for (double i = 0; i < ((Math.Sqrt(3) / 2) * sizeOfTriangle); i += offset)
            {
                foxDraw.DrawLine(startPoint, endingPoint);
                startPoint = new Point(startPoint.X - (smallTriangleSize / 2), startPoint.Y + offset);
                endingPoint = new Point(endingPoint.X - smallTriangleSize, endingPoint.Y);
            }
            
            startPoint = new Point((Width - sizeOfTriangle) / 2, Height - ((Height - ((Math.Sqrt(3) / 2) * sizeOfTriangle)) / 2));
            endingPoint = topPoint;
            for (double i = 0; i < ((Math.Sqrt(3) / 2) * sizeOfTriangle); i += offset)
            {
                foxDraw.DrawLine(startPoint, endingPoint);
                startPoint = new Point(startPoint.X + smallTriangleSize, startPoint.Y);
                endingPoint = new Point(endingPoint.X + (smallTriangleSize / 2), endingPoint.Y + offset);
            }

        }
        
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

    }
}