using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ModularCircle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public double _circleRadius;
        public int _circlePointCount;
        public double _pointRadius;


        public readonly Brush _mainCircleBrush = Brushes.OrangeRed;
        public  Brush _pointBrush;
        public readonly Brush _lineBrush = Brushes.CornflowerBlue;

        public static object[] array = new object[] {
            Brushes.CornflowerBlue,
            Brushes.Black,
            Brushes.OrangeRed,
            Brushes.Yellow,
            Brushes.Silver,
            Brushes.Red,
            Brushes.Pink,
            Brushes.PaleGreen,
            Brushes.MediumSpringGreen,
            Brushes.MediumPurple,
            Brushes.LimeGreen,
            Brushes.LightYellow,
            Brushes.LightCoral,
            Brushes.LemonChiffon,
            Brushes.Firebrick,
            Brushes.YellowGreen,
            Brushes.WhiteSmoke,
            Brushes.Thistle,
            Brushes.SteelBlue,
            Brushes.SkyBlue,
            Brushes.AliceBlue,
            Brushes.Azure,
            Brushes.BlanchedAlmond,
            Brushes.Brown,
            Brushes.Chocolate,
            Brushes.CornflowerBlue
        };

        public const double _factor = 2;

        public MainWindow()
        {
            InitializeComponent();
        }

        public Brush Color()
        {
            _pointBrush =  (Brush)array[new Random().Next(0, array.Length)];
            return _pointBrush;
        }

        private void Start()
        {
 
            object counter = Convert.ToInt32(count.Text) + 1;

            count.Text = counter.ToString();
            double marginX = (canvas.Width - 2 * _circleRadius) / 2;
            double marginY = (canvas.Height - 2 * _circleRadius) / 2;

            //рассчитываем координаты точек на окружности
            Point[] circlePoints = CirclePointsCalculator.CalcCirclePoints(_circlePointCount, _circleRadius, marginX + _circleRadius, marginY + _circleRadius);

            //рисуем основную окружность
            DrawCircle(_circleRadius, _mainCircleBrush, marginX, marginY);

            //рисуем точки на окружности ввиде маленьких кружочков
            foreach (var point in circlePoints)
            {
                DrawCircle(_pointRadius, _pointBrush, point.X - _pointRadius, point.Y - _pointRadius, true);
            }


                for (int i = 0; i < circlePoints.Length; i++)
                {
                   Brush color = Color();
                   DrawLine(circlePoints[i], circlePoints[i * (int)counter % circlePoints.Length], color);
                }

        }

        private void DrawLine(Point from, Point to, Brush brush)
        {
            Line line = new Line()
            {
                X1 = from.X,
                Y1 = from.Y,
                X2 = to.X,
                Y2 = to.Y,
                Stroke = brush,
                StrokeThickness = 1
            };

            canvas.Children.Add(line);
        }

        private void DrawCircle(double radius, Brush brush, double x, double y, bool fill = false)
        {
            var circle = new Ellipse()
            {
                Stroke = brush,
                Width = 2 * radius,
                Height = 2 * radius,
                StrokeThickness = 1
            };

            if (fill)
                circle.Fill = brush;

            Canvas.SetLeft(circle, x);
            Canvas.SetTop(circle, y);

            canvas.Children.Add(circle);
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            _circleRadius = (canvas.Height - 20) / 2;
            _circlePointCount = 200;
            _pointRadius = 2;
            buttonStart.IsEnabled = false;
            timerStart();
        }

        private DispatcherTimer timer = null;

        private void timerStart()
        {
            timer = new DispatcherTimer(); 
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            canvas.Children.Clear();
            Start();
        }


        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            buttonStart.IsEnabled = true;
            timer.Stop();
        }
    }
}
