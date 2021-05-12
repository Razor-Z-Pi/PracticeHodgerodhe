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

namespace PracticeHodgerodhe.Pages
{
    /// <summary>
    /// Логика взаимодействия для Block_1.xaml
    /// </summary>

    public partial class Block_1 : Page
    {
        public Block_1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Кнопка решения
        /// </summary>

        private void Hope_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = 0;
                Double z = Double.Parse(ground.Text);
                Ravn.Content = ground.Text; // Присваевание Label число которо мы ввели

                if (ground.Text == "") // Проверка на пустоту
                {
                    MessageBox.Show("Введите пожалуйста число", "Внимание");
                }

                if (z > 0) // Сравнение по условию задачи, и в конечном итоге решение!!!
                {
                    x = Math.Sqrt(z);
                    sravn.Content = "z > 0";
                }
                else
                {
                    x = (3 * Math.Pow(z, 3) - z) - 5;
                    sravn.Content = "z <= 0";
                }
                double y = Math.Cos(5 * x) + Math.Sin(1 / 5 * x) + Math.Exp(x);
                otvet.Content = y;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
