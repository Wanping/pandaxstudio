using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace pandax
{
    /// <summary>
    /// Appstore.xaml 的交互逻辑
    /// </summary>
    public partial class Appstore : Page
    {
        public Appstore()
        {
            InitializeComponent();
        }
        string path_app = AppDomain.CurrentDomain.BaseDirectory;
        private void Grid_Effect_MouseLeave(object sender, MouseEventArgs e)
        {
            Grid sen = sender as Grid;
            DropShadowEffect myDropShadowEffect = new DropShadowEffect();
            // Set the color of the shadow to Black.

            myDropShadowEffect.Color = Color.FromRgb(240, 240, 240);
            myDropShadowEffect.Opacity = 0.5;
            sen.Effect = myDropShadowEffect;
            sen.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));

        }
        private void Grid_Effect_MouseEnter(object sender, MouseEventArgs e)
        {
            Grid sen = sender as Grid;

            DropShadowEffect myDropShadowEffect = new DropShadowEffect();
            // Set the color of the shadow to Black.

            myDropShadowEffect.Color = Color.FromRgb(18, 33, 247);
            myDropShadowEffect.Opacity = 1;
            myDropShadowEffect.ShadowDepth = 0;
            myDropShadowEffect.Direction = 300;
            myDropShadowEffect.BlurRadius = 10;
            sen.Effect = myDropShadowEffect;

        }
        private void Delete_card_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menu = sender as MenuItem;
            string grid_name = "grid_" + menu.Name.Substring(12);

            Grid grid_local = FindName(grid_name) as Grid;

            MessageBoxResult result = MessageBox.Show("卡片移除仅本次有效，是否仍要继续？", "是否删除卡片", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                wrap_appstore.Children.Remove(grid_local);
            }
            else
            {
                MessageBox.Show("操作已取消");
            }
        }

        private void App_start_1_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://dl1.cdn.filezilla-project.org/client/FileZilla_3.42.1_win64-setup.exe?h=5T8cwBZc4-y9aKM2yZ0e6Q&x=1559448125";
        }
    }
}
