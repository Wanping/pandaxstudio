using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace pandax
{
    /// <summary>
    /// Homepage.xaml 的交互逻辑
    /// </summary>
    public partial class Homepage : Page
    {
        public Homepage()
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
                wrap_1.Children.Remove(grid_local);
            }
            else
            {
                MessageBox.Show("操作已取消");
            }
        }
        private void Apache_install_service_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("开始安装Apahce服务...");
            Process.Start("cmd.exe");

            ServiceController sc = new ServiceController("Server");
        }
        private void Op_apache_conf_click(object sender, RoutedEventArgs e)
        {
            try
            {
                string op_apache_config = path_app + @"\plugins\apache\conf\httpd.conf";

                Process.Start("notepad.exe", op_apache_config);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Op_mysql_conf_click(object sender, RoutedEventArgs e)
        {
            try
            {
                string op_mysql_config = path_app + @"\plugins\mysql\my.ini";

                Process.Start("notepad.exe", op_mysql_config);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Composer_open_Click(object sender, RoutedEventArgs e)
        {


        }


        private void Option_1_Click_1(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindResource("cmButton_1") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }

        private void Start_1_Click(object sender, RoutedEventArgs e)
        {
            //调用httpd
            string path_httpd = path_app + @"\plugins\apache\bin\httpd.exe";

            if (start_1.Content.ToString() == "开始")
            {
                //如果当前存在已经启动的Apache进程，则先结束
                Process[] process = Process.GetProcessesByName("httpd");

                foreach (Process p in process)
                {
                    p.Kill();
                }

                try
                {
                    //声明一个程序信息类 
                    ProcessStartInfo httpd = new ProcessStartInfo();
                    //设置外部程序名
                    httpd.FileName = path_httpd;
                    //设置隐藏窗口 
                    httpd.WindowStyle = ProcessWindowStyle.Hidden;
                    Process p = new Process();
                    p = Process.Start(httpd);
                    MessageBox.Show("执行成功");
                    start_1.Content = "停止";
                    start_1.Background = new SolidColorBrush(Color.FromRgb(12, 204, 108));
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                try
                {
                    Process[] process = Process.GetProcessesByName("httpd");
                    foreach (Process p in process)
                    {
                        p.Kill();
                    }
                    MessageBox.Show("程序已停止");
                    start_1.Content = "开始";
                    start_1.Background = new SolidColorBrush(Color.FromRgb(245, 246, 247));

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void Start_2_Click(object sender, RoutedEventArgs e)
        {
            //调用mysql
            string path_mysql = path_app + @"plugins\mysql\bin\mysqld.exe";

            if (start_2.Content.ToString() == "开始")
            {
                //如果当前存在已经启动的Apache进程，则先结束
                Process[] process = Process.GetProcessesByName("mysqld");

                foreach (Process p in process)
                {
                    p.Kill();
                }

                try
                {
                    //声明一个程序信息类 
                    ProcessStartInfo mysql = new ProcessStartInfo();
                    //设置外部程序名
                    mysql.FileName = path_mysql;
                    //设置隐藏窗口 
                    mysql.WindowStyle = ProcessWindowStyle.Hidden;
                    Process p = new Process();
                    p = Process.Start(mysql);
                    MessageBox.Show("执行成功");
                    start_2.Content = "停止";
                    start_2.Background = new SolidColorBrush(Color.FromRgb(12, 204, 108));
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                try
                {
                    Process[] process = Process.GetProcessesByName("mysqld");
                    foreach (Process p in process)
                    {
                        p.Kill();
                    }


                    MessageBox.Show("程序已停止");
                    start_2.Content = "开始";
                    start_2.Background = new SolidColorBrush(Color.FromRgb(245, 246, 247));

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void Start_3_Click(object sender, RoutedEventArgs e)
        {
            //调用系统默认的浏览器 打开phpmyadmin
            try
            {
                Process.Start("http://127.0.0.1/phpmyadmin");
            }
            catch (Exception)
            {

                throw;
            }
            start_3.Background = new SolidColorBrush(Color.FromRgb(245, 246, 247));
        }

        private void Start_4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("http://127.0.0.1/phpinfo.php");
            }
            catch (Exception)
            {

                throw;
            }
            start_3.Background = new SolidColorBrush(Color.FromRgb(245, 246, 247));
        }

        private void Start_5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("http://127.0.0.1/thinkphp5/public");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Start_7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("http://127.0.0.1/wordpress/");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Start_8_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("正在开发");
        }

        private void Start_9_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string path_filezilla_server = path_app + @"plugins\ftpserver\FileZilla Server Interface.exe";
                Process.Start(path_filezilla_server);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Start_12_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("正在开发");
        }

        private void Label_14_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("正在开发");
        }

        private void Option_2_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindResource("cmButton_2") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }

        private void Option_4_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindResource("cmButton_4") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }

        private void Option_3_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindResource("cmButton_3") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }

        private void Option_5_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindResource("cmButton_5") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }

        private void Option_6_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindResource("cmButton_6") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }
        private void Option_7_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindResource("cmButton_7") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }
        private void Option_8_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindResource("cmButton_8") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }

        

        private void Option_9_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindResource("cmButton_9") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }

        private void Option_10_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindResource("cmButton_10") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }
    }
}
