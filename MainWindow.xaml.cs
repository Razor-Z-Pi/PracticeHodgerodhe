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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticeHodgerodhe
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        // Файл с заданием
        string patch = @"Задания.docx";

        public MainWindow()
        {
            InitializeComponent(); 
            AppFrame.frame = frm; // Подключили класс фрема, для отображения страниц (Позволят не вызывать фрейм для каждой страницы), Класс называется (AppFrame.cs) 
        }

        /// <summary>
        /// Открытие страничек при нажатие соответсвуюшей кнопки
        /// </summary>

        private void btmBl1_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frame.Navigate(new Pages.Block_1());
        }

        private void btmBl2_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frame.Navigate(new Pages.Block_2());
        }

        private void btmBl3_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frame.Navigate(new Pages.Block_3());
        }

        private void btmBl4_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frame.Navigate(new Pages.Block_4());
        }

        private void btmBl5_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frame.Navigate(new Pages.Block_5());
        }

        private void btmBl6_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frame.Navigate(new Pages.Block_6());
        }

        private void btmBl7_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frame.Navigate(new Pages.Block_7());
        }

        /// <summary>
        /// Анимация левого окна с бургером (Сужение, задвежения) 
        /// </summary>

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            if (GridLeft.Width == 50)
            {
                DoubleAnimation doubleAnimation = new DoubleAnimation();
                doubleAnimation.From = 50;
                doubleAnimation.To = GridLeft.Width + 100;
                doubleAnimation.Duration = TimeSpan.FromSeconds(0.1);
                GridLeft.BeginAnimation(Grid.WidthProperty, doubleAnimation);
                if (Go.Width == 50)
                {
                    doubleAnimation.From = 50;
                    doubleAnimation.To = Go.Width - 50;
                    doubleAnimation.Duration = TimeSpan.FromSeconds(0.1);
                    Go.BeginAnimation(Button.WidthProperty, doubleAnimation);
                    doubleAnimation.From = 0;
                    doubleAnimation.To = Back.Width + 50;
                    doubleAnimation.Duration = TimeSpan.FromSeconds(0.1);
                    Back.BeginAnimation(Button.WidthProperty, doubleAnimation);
                }
            }
        }

        /// <summary>
        /// Анимация левого окна с бургером (Расширение, раздвижение) 
        /// </summary>

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (GridLeft.Width == 150)
            {
                DoubleAnimation doubleAnimation = new DoubleAnimation();
                doubleAnimation.From = 150;
                doubleAnimation.To = GridLeft.Width - 100;
                doubleAnimation.Duration = TimeSpan.FromSeconds(0.1);
                GridLeft.BeginAnimation(Grid.WidthProperty, doubleAnimation);
                if (Back.Width == 50)
                {
                    doubleAnimation.From = 50;
                    doubleAnimation.To = Back.Width - 50;
                    doubleAnimation.Duration = TimeSpan.FromSeconds(0.1);
                    Back.BeginAnimation(Button.WidthProperty, doubleAnimation);
                    doubleAnimation.From = 0;
                    doubleAnimation.To = Go.Width + 50;
                    doubleAnimation.Duration = TimeSpan.FromSeconds(0.1);
                    Go.BeginAnimation(Button.WidthProperty, doubleAnimation);
                }
            }
        }

        /// <summary>
        /// INFO окно 
        /// </summary>

        private void Avtor_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Собственность Попова Павла, не смейте копировать и списывать!!!",
                            "Я предупреждаю",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
        }

        /// <summary>
        /// Вызов документа с заданием
        /// </summary>

        private void Practica_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WordPad.exe", patch);
        }
    }
}
