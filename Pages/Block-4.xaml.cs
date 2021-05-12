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
    /// Логика взаимодействия для Block_4.xaml
    /// </summary>
    public partial class Block_4 : Page
    {
        public Block_4()
        {
            InitializeComponent();
        }

        private void Matrica_Click(object sender, RoutedEventArgs e)
        {
            Matr1.Clear(); // Чистим поля 
            Matr2.Clear();
            Matr3.Clear();
            Matr4.Clear();
            try
            {
                Random random = new Random();
                const int n1 = 6;
                const int n2 = 5;
                int[,] array = new int[n1, n2];

                /// <summary>
                /// Первая матрица
                /// </summary>

                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        int rand = random.Next(-10, 50);
                        array[i, j] = rand;
                        Matr1.Text += array[i, j] + "  |   ";
                    }
                    Matr1.Text += "\n";
                }

                Matr1.Text += " Произведения столбцов, чётных и положительных чисел \n";
                Matr1.Text += " __________________________________________________ \n";

                double[] mass = new double[n2];

                for (int j = 0; j < n2; j++)
                {
                    double prozi = 1;
                    for (int i = 0; i < n1; i++)
                    {
                        if ( (array[i, j] % 2 == 0) && (array[i,j] > 0) )
                        {
                            prozi *= array[i, j];
                        }
                    }
                    mass[j] = prozi;
                }
  

                for (int i = 0; i < n2; i++)
                {
                    Matr1.Text += "  " + mass[i].ToString() + "  ";
                }

                /// <summary>
                /// Вторая матрица
                /// </summary>

                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        int rand = random.Next(-10, 50);
                        array[i, j] = rand;
                        Matr2.Text += array[i, j] + "  |   ";
                    }
                    Matr2.Text += "\n";
                }

                Matr2.Text += "  Определить, есть ли в данном массиве строка, в которой ровно два отрицательных элемента. \n";
                Matr2.Text += " __________________________________________________ \n";
                int ke = 0;
                for (int i = 0; i < n1; i++)
                {
                    int index = 0;
                    for (int j = 0; j < n2; j++)
                    {
                        if ( (array[i, j] < 0) && (index < 2) )
                        {
                            index += 1;
                            if (index == 2)
                            {
                                ke = 1;
                            }

                        }
                    }
                }
                if (ke == 0)
                    Matr2.Text += " Нет ";
                else
                    Matr2.Text += " Есть ";

                /// <summary>
                /// Третья матрица
                /// </summary>


                const int n3 = 7;
                int[,] array1 = new int[n3,n3];


                // Формируем массив по условию задачи
                for (int i = 0; i < n3; i++)
                {
                    for (int j = 0; j < n3; j++)
                    {
                        array1[i, j] = 0;
                        array1[i, i] = 1;
                        array1[i, n3 - i - 1] = 1;
                    }
                }


                // Выводит на экран
                for (int i = 0; i < n3; i++)
                {
                    for (int j = 0; j < n3; j++)
                    {
                        Matr3.Text += array1[i, j] + "  |   ";
                    }
                    Matr3.Text += "\n";
                }

                
                /// <summary>
                /// Четвёртая матрица
                /// </summary>

                int max = 0; // Для максимального числа
                int min = 0; // Для минимального числа
                int tablemax = 0; // Для индекса таблицы макс. числа
                int tablemin = 0; // Для индекса таблицы мин. числа 
                int zmax = 0; // Индекс строки макс. числа
                int zmin = 0; // Индекс строки мин. числа

                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        int rand = random.Next(-10, 50); 
                        array[i, j] = rand;
                        if (max < array[i, j]) // Поиск макс. числа
                        {
                            max = array[i, j];
                            zmax = j;
                            tablemax = i;
                        }
                        if (min > array[i, j]) // Поиск мин. числа
                        {
                            min = array[i, j];
                            zmin = j;
                            tablemin = i;
                        }
                        Matr4.Text += array[i, j] + "  |   ";
                    }
                    Matr4.Text += "\n";
                }

                Matr4.Text += " Заменить максимальный элемент каждой строки на противоположный \n";
                Matr4.Text += " __________________________________________________ \n";
                Matr4.Text += $" Максимальный элемент = {max} , противоположный = {min} \n";
                array[tablemax, zmax] = min; // Заменяем макс. на мин. число
                array[tablemin, zmin] = max; // Заменяем мин. на макс. число

                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        Matr4.Text += array[i, j] + "  |   ";
                    }
                    Matr4.Text += "\n";
                }


                /// <summary>
                /// Четвёртая матрица задание №2
                /// </summary>
                
                Matr4.Text += "\n";
                Matr4.Text += "\n";
                Matr4.Text += " Вставить после столбцов с максимальными элементами столбец из нулей \n";
                Matr4.Text += " __________________________________________________ \n";


                const int n4 = 6;
                const int n5 = 5;
                int[,] zero = new int[n1, n2];


                for (int i = 0; i < n4; i++)
                {
                    for (int j = 0; j < n5; j++)
                    {
                        int rand = random.Next(-10, 50);
                        zero[i, j] = rand;
                    }
                }

                for (int i = 0; i < n4; i++)
                {
                    for (int j = 0; j < n5; j++)
                    {
                        if (max < zero[i, j]) // Поиск макс. числа
                        {
                            max = zero[i, j];
                            zmax = j;
                            tablemax = i;
                        }
                        if (min > zero[i, j]) // Поиск мин. числа
                        {
                            min = zero[i, j];
                            zmin = j;
                            tablemin = i;
                        }
                    }
                }

                for (int i = 0; i < n4; i++) zero[i, zmax] = 0;

                for (int i = 0; i < n4; i++)
                {
                    for (int j = 0; j < n5; j++)
                    { 
                        Matr4.Text += zero[i, j] + "  |   ";                    
                    }
                    Matr4.Text += "\n";
                }


                /// <summary>
                /// Четвёртая матрица задание № 3
                /// </summary>

                Matr4.Text += "\n";
                Matr4.Text += " Удалить среднюю строку. \n";
                Matr4.Text += " __________________________________________________ \n";

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                            Matr4.Text += array[i, j] + "  |   ";
                    }
                    Matr4.Text += "\n";
                }

                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        Matr4.Text += array[4, j] + "  |   ";
                    }
                    Matr4.Text += "\n";
                }

                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        Matr4.Text += array[5, j] + "  |   ";
                    }
                    Matr4.Text += "\n";
                }


                /// <summary>
                /// Четвёртая матрица задание № 4
                /// </summary

                Matr4.Text += "\n";
                Matr4.Text += " Поменять местами предпоследний и последний столбцы \n";
                Matr4.Text += " __________________________________________________ \n";

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 5; j ++)
                    {
                        int tmp = array[i, 3];
                        array[i, 3] = array[i, 4];
                        array[i, 4] = tmp;
                    }
                }

                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        Matr4.Text += array[i, j] + "  |   ";
                    }
                    Matr4.Text += "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
