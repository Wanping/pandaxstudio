using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Path = System.IO.Path;
namespace pandax
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //检查数据库文件是否存在，如果不存在则进行错误提示
            string dbfile = Path.Combine(path_app, @"config\pandax.db");
            if (!File.Exists(dbfile))
            {
                MessageBox.Show("程序异常，数据库文件不存在!", "注意", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        string path_app = AppDomain.CurrentDomain.BaseDirectory;

        private void Current_option_Click(object sender, RoutedEventArgs e)
        {
            Settings set = new Settings();
            set.Show();
        }

       

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
            this.Close();
        }

        

        private void Cmd_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("cmd.exe", "/k echo 欢迎使用Pandax Studio命令行工具");
        }


        private void option_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindResource("cmButton_1") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;

        }

        private void Service_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Process.Start("services.msc");
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void Current_dir_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Process.Start(path_app);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Aboutme_Click(object sender, RoutedEventArgs e)
        {
            Readme about = new Readme();
            about.Show();
        }

        private void Www_dir_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string path_www = Path.Combine(path_app, "www");
            try
            {
                Process.Start(path_www);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Current_bro_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //调用系统默认的浏览器
            try
            {
                Process.Start("http://127.0.0.1");
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Hosts_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.Start("notepad.exe", @"C:\Windows\System32\drivers\etc\hosts");
        }
        private void Check_update_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("当前已是最新版本!");
        }

        private void More_link_Click(object sender, RoutedEventArgs e)
        {
            //调用系统默认的浏览器
            try
            {
                Process.Start("http://www.pandaxstudio.com/");
            }
            catch (Exception)
            {

                throw;
            }
        }




        private void home_site_click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("http://www.pandaxstudio.com/");
            }
            catch (Exception)
            {

                throw;
            }
        }





        private void port_check_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("正在开发");
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

        
        private void Home_site_click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("http://www.pandaxstudio.com/");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Btn_doc_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = new Uri("Documents.xaml", UriKind.Relative);
        }

        private void Btn_app_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = new Uri("Appstore.xaml", UriKind.Relative);
        }
        private void Btn_com_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = new Uri("Community.xaml", UriKind.Relative);
        }

        private void Btn_home_Click(object sender, RoutedEventArgs e)
        {
            frame.Source = new Uri("Homepage.xaml", UriKind.Relative);
        }

        private void Check_init_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("配置文件已刷新");
        }
        private void Bar_tool_Click(object sender, RoutedEventArgs e)
        {
            if (pd_toolbar.Visibility == Visibility.Visible)
            {
                pd_toolbar.Visibility = Visibility.Collapsed;
                bar_tool.Icon = "";
            }
            else
            {
                pd_toolbar.Visibility = Visibility.Visible;

                bar_tool.Icon = new System.Windows.Controls.Image
                {
                    Source = new BitmapImage(new Uri("source/image/checked.png", UriKind.Relative))
                };
            }


        }
        private void Bar_state_Click(object sender, RoutedEventArgs e)
        {
            if (pd_statusbar.Visibility == Visibility.Visible)
            {
                pd_statusbar.Visibility = Visibility.Collapsed;
                bar_state.Icon = "";
            }
            else
            {
                pd_statusbar.Visibility = Visibility.Visible;

                bar_state.Icon = new Image
                {
                    Source = new BitmapImage(new Uri("source/image/checked.png", UriKind.Relative))
                };
            }
        }

        private void Download_dir_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string path_download = Path.Combine(path_app, "download");
            try
            {
                Process.Start(path_download);
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        private void If_help_Click(object sender, RoutedEventArgs e)
        {
           

            if (btn_doc.Visibility == Visibility.Visible)
            {
                btn_doc.Visibility = Visibility.Collapsed;
                if_help.Icon = "";
            }
            else
            {
                btn_doc.Visibility = Visibility.Visible;

                if_help.Icon = new Image
                {
                    Source = new BitmapImage(new Uri("source/image/checked.png", UriKind.Relative))
                };
            }
        }

        private void If_appstore_Click(object sender, RoutedEventArgs e)
        {

            if (btn_app.Visibility == Visibility.Visible)
            {
                btn_app.Visibility = Visibility.Collapsed;
                if_appstore.Icon = "";
            }
            else
            {
                btn_app.Visibility = Visibility.Visible;

                if_appstore.Icon = new Image
                {
                    Source = new BitmapImage(new Uri("source/image/checked.png", UriKind.Relative))
                };
            }
        }

        private void If_community_Click(object sender, RoutedEventArgs e)
        {
            if (btn_com.Visibility == Visibility.Visible)
            {
                btn_com.Visibility = Visibility.Collapsed;
                if_community.Icon = "";
            }
            else
            {
                btn_com.Visibility = Visibility.Visible;

                if_community.Icon = new Image
                {
                    Source = new BitmapImage(new Uri("source/image/checked.png", UriKind.Relative))
                };
            }
        }

        private void Init_path_Click(object sender, RoutedEventArgs e)
        {
            //初始化apache配置文件
            string path_app = AppDomain.CurrentDomain.BaseDirectory;
            string path_apache = Path.Combine(path_app, @"plugins\apache").Replace(@"\", @"/");
            string path_www = Path.Combine(path_app, @"www").Replace(@"\", @"/");
            string path_apache_original = Path.Combine(path_app, @"config\httpd.conf");
            string path_php = Path.Combine(path_app, @"plugins\php\").Replace(@"\", @"/");

            string path_apache_conf = Path.Combine(path_app, @"plugins\apache\conf\httpd.conf");
            string path_apache_bak = Path.Combine(path_app, @"config\backup\httpd.conf");
            //读取Apache配置文件
            StreamReader sr = new StreamReader(path_apache_original);
            string txt = "";
            string line = "";
            int i = 0;
            while ((line = sr.ReadLine()) != null)
            {
                i++;
                if (line.Contains("Define SRVROOT "))
                {

                    line = "Define SRVROOT \"" + path_apache + "\"";

                }
                else if (line.Contains("DocumentRoot "))
                {

                    line = "DocumentRoot \"" + path_www + "\"";

                }
                else if (i == 249 & line.Contains("Directory "))
                {
                    MessageBox.Show(line + "..." + i.ToString());


                }

                txt += line;
            }
        }

        private void Localhost_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("http://127.0.0.1");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void export_all_Click(object sender, RoutedEventArgs e)
        {

        }

        private void export_www_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Port_manager_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Check_update_Click(object sender, MouseButtonEventArgs e)
        {
            /// <summary>
            /// 获取本地软件的版本号
            /// </summary>
          
              string  nowversion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\n";
               MessageBox.Show(nowversion);
            
        }

    }
}
