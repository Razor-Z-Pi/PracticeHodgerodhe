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
    /// Логика взаимодействия для Block_2.xaml
    /// </summary>

    public partial class Block_2 : Page
    {
        public Block_2()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Кнопка решения
        /// </summary>

        private void btnResh_Click(object sender, RoutedEventArgs e)
        {
            int x, y, z; // Переменные для разделения числа на части
            int s1 = 0; // Переменная для суммы кратны чисел на 13
            int s2 = 0; // Переменная для суммы кратны чисел на 5
            
            try  // Проверка на пустоту
            {
                if (natNum.Text == "")
                {
                    MessageBox.Show("Введите натуральное число");
                }
                else if (Povtor.Text == "")
                {
                    MessageBox.Show("Введите натуральное число");
                }
                else if (Srawnn.Text == "")
                {
                    MessageBox.Show("Введите натуральное число");
                }
                else if (A.Text == "")
                {
                    MessageBox.Show("Введите натуральное число");
                }
                else if (B.Text == "")
                {
                    MessageBox.Show("Введите натуральное число");
                }

                int naturalNum = Int32.Parse(natNum.Text); // Число которое мы введля для поля (Натуральное число)
                natural.Content = natNum.Text; // Также мы присвоили Label для доп информации
                int povtorNum = Int32.Parse(Povtor.Text); // Число при помощи которым мы проверям это же число на повторение!!!)
                int srav = Int32.Parse(Srawnn.Text); // Число для сравнения
                int a = Int32.Parse(A.Text); // Числа по заданию 2.2 (сумму всех чисел из промежутка от А до В, кратных 13 и 5)
                int b = Int32.Parse(B.Text);

                if ( 1 == natNum.Text.Length) // Проверка на повторения числа с 70 строки по 116
                {
                    if (povtorNum == naturalNum)
                    {
                        povtor.Content = 1;
                    }
                    else
                    {
                        povtor.Content = 0;
                    }
                }

                if (2 == natNum.Text.Length) 
                {
                    x = naturalNum % 100 / 10;
                    y = naturalNum % 10;
                    if (povtorNum == x)
                    {
                        povtor.Content = 1;
                    }
                    if (povtorNum == y)
                    {
                        povtor.Content = 1;
                    }
                    if ( (povtorNum == x) && (povtorNum == y) ) povtor.Content = 2;
                }

                if (3 == natNum.Text.Length)
                {
                    x = naturalNum % 1000 / 100;
                    y = naturalNum % 100 / 10;
                    z = naturalNum % 10;
                    if ((povtorNum == x) && (povtorNum == y) && (povtorNum == z)) povtor.Content = 3;
                    else if ((povtorNum == x) && (povtorNum == y)) povtor.Content = 2;
                    else if ((povtorNum == x) && (povtorNum == z)) povtor.Content = 2;
                    else if ((povtorNum == y) && (povtorNum == z)) povtor.Content = 2;
                    else if (povtorNum == z) povtor.Content = 1;
                    else if(povtorNum == x)
                    {
                        povtor.Content = 1;
                    }
                    else if (povtorNum == y)
                    {
                        povtor.Content = 1;
                    }

                }

                numbers.Content = povtorNum; // Вывод на экран для доп. информации!!!
                int Be = naturalNum / srav; // Для сравнения, по условию задачи (верно ли, что в данном числе сумма цифр больше В, а само число делится на В (В вводится  с клавиатуры))

                if (srav > Be)
                {
                    MessageBox.Show($"{srav} > {Be}, Да число больше");
                }
                else
                    MessageBox.Show($"{srav} < {Be}, Число меньше");

                while(b > a) // Выполнения последнего задания, для суммы кратных 13 и 5 
                {
                    if (a % 13 == 0)
                    {
                        s1 += a;
                        chisla.Content = " " + s1;
                    }
                    else if (a % 5 == 0)
                    {
                        s2 += a;
                        chisla.Content = " " + s2;
                    }
                    a++;
                }
                int sum1 = s2 + s1;
                sumers.Content = sum1;
            } catch ( Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
