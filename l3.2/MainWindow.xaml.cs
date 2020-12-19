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

namespace l3._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            try {

                //Получение значения m от пользователя
                int m = int.Parse(Input.Text);
                double n = 0;
                int i = 100;
                
                while (i <= 1000)
                {
                    if ((i * i) % 5 == 0)
                    {
                        n = (double)(i * i) / m;
                    }
                    Output.Text += n + " ";
                    i += 100;
                }
                
                //Вывод результата 
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
