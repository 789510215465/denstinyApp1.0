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

namespace destinyApp1._0
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 載入圖片路徑,其實這路徑不對時會出錯,可是我被Image搞昏了,我解決不了這問題QAQ,唉這是什麼悲催的註解...
            image.Source = new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\00.jpg", UriKind.Absolute));        
        }

        private void RandBtn_Click(object sender, RoutedEventArgs e)
        {
            // 亂數
            Random rand = new Random();
            int r = rand.Next(0, 15);

            switch ( r )
            {
                case 0 :
                    image.Source =
                        new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\01.jpg"));
                    break;

                case 1:
                    image.Source =
                        new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\02.jpg"));
                    break;

                case 2:
                    image.Source =
                        new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\03.jpg"));
                    break;

                case 3:
                    image.Source =
                        new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\04.jpg"));
                    break;

                case 4:
                    image.Source =
                        new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\05.jpg"));
                    break;

                case 5:
                    image.Source =
                        new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\06.jpg"));
                    break;

                case 6:
                    image.Source =
                        new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\07.jpg"));
                    break;

                case 7:
                    image.Source =
                        new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\08.jpg"));
                    break;

                case 8:
                    image.Source =
                        new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\09.jpg"));
                    break;

                case 9:
                    image.Source =
                        new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\10.jpg"));
                    break;

                case 10:
                    image.Source =
                        new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\11.jpg"));
                    break;

                case 11:
                    image.Source =
                        new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\12.jpg"));
                    break;

                case 12:
                    image.Source =
                        new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\13.jpg"));
                    break;

                case 13:
                    image.Source =
                        new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\14.jpg"));
                    break;

                case 14:
                    image.Source =
                        new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\15.jpg"));
                    break;
            }
        }

        private void ReBtn_Click(object sender, RoutedEventArgs e)
        {
            image.Source =
                new BitmapImage(new Uri(@"C:\git\destinyApp1.0\picture\00.jpg"));
        }
    }
}
