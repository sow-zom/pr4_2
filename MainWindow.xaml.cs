    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
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

    namespace Pr4_2
    {
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>

        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
            }

            async public void t2()
            {
                for (int i = 0; i < 19; i++)
                {
                    Random x = new Random();
                    int y = x.Next(5);
                    Random x1 = new Random();

                    switch (y)
                    {
                        case 0:
                            {
    Rectangle rect = new Rectangle();
    int jj = x.Next(11);
                   rect.Height = 100 + 10 * jj;
             jj = x.Next(0, 11);  rect.Width = 200 + 10 * jj;
     SolidColorBrush GreenBrush = new SolidColorBrush();
     GreenBrush.Color = Colors.Green;
      rect.StrokeThickness = 4;
      grid1.Children.Add(rect);
   await PutTaskDelay();
     grid1.Children.Remove(rect);
                            }
                            break;
                        case 1:
                            {
 Line li = new Line();
        int jj = x.Next(0, 11); li.X1 = 100 + 10 * jj;
                            
jj = x.Next(0, 11);  li.Y1 = 100 + 10 * jj;
    jj = x.Next(0, 11);
li.X2 = 400 + 10 * jj;
 jj = x.Next(0, 11);  li.Y2 = 400 + 10 * jj;
                                SolidColorBrush GreenBrush = new SolidColorBrush(); GreenBrush.Color = Colors.Green;li.StrokeThickness = 4;li.Stroke = GreenBrush;
                                grid1.Children.Add(li);await PutTaskDelay(); grid1.Children.Remove(li);
                               
                         }
                            break;
                        case 2:
                            {
Ellipse cir = new Ellipse();
                                int jj = x.Next(0, 11);
cir.Height = 200 + 10 * jj;
cir.Width = 200 + 10 * jj;
                                SolidColorBrush GreenBrush = new SolidColorBrush();
GreenBrush.Color = Colors.Green;
                                cir.StrokeThickness = 4;
cir.Stroke = GreenBrush;
                                grid1.Children.Add(cir);
 await PutTaskDelay();
grid1.Children.Remove(cir);
                            }
                            break;
                        case 3:
                            {
                                Ellipse ellip = new Ellipse();
                                int jj = x.Next(0, 11);
 ellip.Height = 200 + 10 * jj;
jj = x.Next(0, 11);
  ellip.Width = 300 + 10 * jj;
    SolidColorBrush GreenBrush = new SolidColorBrush();
  GreenBrush.Color = Colors.Green;
  ellip.StrokeThickness = 4;
ellip.Stroke = GreenBrush;
   grid1.Children.Add(ellip);
     await PutTaskDelay();
      grid1.Children.Remove(ellip);
                            }
 break;
  case 4:
 {
  Ellipse elli = new Ellipse();
                                                                SolidColorBrush GreenBrush = new SolidColorBrush();
 GreenBrush.Color = Colors.Green;
 elli.StrokeThickness = 10;
 elli.Stroke = GreenBrush;
grid1.Children.Add(elli);
await PutTaskDelay();
 grid1.Children.Remove(elli);
                            }
  break;
                    }
                }
                Random z = new Random();
                int t = z.Next(5);

                switch (t)
                {
                    case 0:
                        {
 Rectangle rect = new Rectangle();
                            rect.Height = 100;
 rect.Width = 200;
                            SolidColorBrush GreenBrush = new SolidColorBrush();
  GreenBrush.Color = Colors.Green;
                            rect.StrokeThickness = 4;
 rect.Stroke = GreenBrush;
grid1.Children.Add(rect);
await PutTaskDelay();
                        }
 break;
 case 1:
{
Line li = new Line();
                                                       li.X1 = 100;
li.X2 = 400;
li.Y2 = 400;
                            SolidColorBrush GreenBrush = new SolidColorBrush();
 GreenBrush.Color = Colors.Green;
 li.StrokeThickness = 4;
 li.Stroke = GreenBrush;
grid1.Children.Add(li);
await PutTaskDelay();
}
break;
case 2:
{
 Ellipse cir = new Ellipse();
   cir.Height = 200 + t;
cir.Width = 200 + t;                       SolidColorBrush GreenBrush = new SolidColorBrush();
GreenBrush.Color = Colors.Green;
                                                        cir.Stroke = GreenBrush;
grid1.Children.Add(cir);
await PutTaskDelay();
                        }
 break;
case 3:
{
 Ellipse ellip = new Ellipse();
                        
ellip.Height = 200;
                        
 ellip.Width = 300;
SolidColorBrush GreenBrush = new SolidColorBrush();GreenBrush.Color = Colors.Green;
                        
ellip.StrokeThickness = 4;ellip.Stroke = GreenBrush;
 grid1.Children.Add(ellip);
await PutTaskDelay();
 }
 break;
case 4:
 {

 Ellipse elli = new Ellipse();
 elli.Height = 10 + t;
elli.Width = 10 + t;

SolidColorBrush GreenBrush = new SolidColorBrush();                      
elli.StrokeThickness = 10 + t;
GreenBrush.Color = Colors.Green;
                        
 elli.Stroke = GreenBrush;
grid1.Children.Add(elli);
     await PutTaskDelay();
                        }
                        break;
                }
            }

 private void Button_Click(object sender, RoutedEventArgs e)
            {
                t2();
            }

private void Button_Click_1(object sender, RoutedEventArgs e)
            {
                grid1.Children.Clear();
            }
 async Task PutTaskDelay()
            {
                await Task.Delay(2603);
            }
        }
    }
