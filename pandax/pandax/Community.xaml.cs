using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace pandax
{
    /// <summary>
    /// Community.xaml 的交互逻辑
    /// </summary>
    public partial class Community : Page
    {
        public Community()
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
                wrap_Community.Children.Remove(grid_local);
            }
            else
            {
                MessageBox.Show("操作已取消");
            }
        }
        private void Shequ_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("https://www.oschina.net/");

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Shequ_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("https://gitee.com/");
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Shequ_3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("https://wanwang.aliyun.com/");
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Shequ_4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("https://dnspod.cloud.tencent.com");
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Shequ_5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("https://github.com/");
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Shequ_6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("https://flatuicolors.com/");
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Shequ_7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("https://www.iconfont.cn/");
            }
            catch (Exception)
            {

                throw;
            }

        }







        private void Shequ_8_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Process.Start("https://npm.taobao.org/");
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void Shequ_9_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Process.Start("https://mirrors.cloud.tencent.com/");
            }
            catch (Exception)
            {

                throw;
            }

        }


        private void Shequ_10_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("https://opsx.alibaba.com/mirror");

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Shequ_11_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("https://mirrors.tuna.tsinghua.edu.cn/");
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
