using System.Windows;

namespace Warehouse
{
    /// <summary>
    /// Логика взаимодействия для Aunt.xaml
    /// </summary>
    public partial class Aunt : Window
    {
        public Aunt()
        {
            InitializeComponent();

        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnLog_Click(object sender, RoutedEventArgs e)
        {
            if (TbLogin.Text == "ad" && TbPass.Password == "666")
            {
                MainWindow win7 = new MainWindow();
                win7.Show();
                Close();
            }
            else if (TbLogin.Text == "TitZP" && TbPass.Password == "12345")
            {
                MainWindow win7 = new MainWindow();
                win7.Show();
                Close();
            }
            else if (TbLogin.Text == "SinMA" && TbPass.Password == "23456")
            {
                MainWindow win7 = new MainWindow();
                win7.Show();
                Close();
            }
            else if (TbLogin.Text == "BelLD" && TbPass.Password == "34567")
            {
                MainWindow win7 = new MainWindow();
                win7.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }
    }
}
