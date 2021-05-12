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
    /// Логика взаимодействия для Block_3.xaml
    /// </summary>

    public partial class Block_3 : Page
    {
        public Block_3()
        {
            InitializeComponent();
            
        }

        /// <summary>
        ///  Кнопка работы со вторым массивом
        /// </summary>

        private void GoVin_Click(object sender, RoutedEventArgs e)
        {
            arrayN.Clear(); // Очищаем поле: TextBox
            try
            {
                int zet = 0; // Счётчик для поиска первого положительного элемента
                int inde = 0; // Индекс для положительного числа, в процессе мы поменяем местами пололжительный с отрицательным числом
                int indeotr = 0; // Индекс для отрицательного числа
                double pol = 0, otr = 0; // Переменные для положительного и отрицательного числа!!! 
                Random random = new Random(); // Класс позволяющей использовать метод для случайного числа
                double[] array = new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // Массив из 10 элементов, решил разнообразить код, и сделал таким способом

                for (int i = 0; i < 15; i++)
                {
                    double xzy = random.Next(-20, 50); // Заполняем по условию задачи от - 20 до 50
                    array[i] = xzy;
                    arrayN.Text += array[i].ToString() + " ";
                }

                arrayN.Text += "\n" + "Удалить из него все элементы, в которых есть цифра 5 -> \n";

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 5)
                    {
                        continue; // Пропускаем шаг цикла
                    }
                    else
                    {
                        arrayN.Text += array[i].ToString() + " ";
                    }
                }

                arrayN.Text += "\n" + "вставить число k после всех элементов, кратных своему номеру -> \n";

                for (int i = 0; i < array.Length; i++)
                {
                    if ( (i % Convert.ToInt32(knumber.Text) == 0) && (i != 0)) // Делим на номер индекса число введённое пользователем, 
                    {                                                          // и сравниваем число чтобы не было равно 0 
                        arrayN.Text += array[i].ToString() + " ";              // (Почемe сравниваем, потому что если делить число на 0 то ответ будет равен 0, и программа будет считать что число кротно номеру)
                        arrayN.Text += knumber.Text + " ";
                    }
                    else
                    {
                        arrayN.Text += array[i].ToString() + " ";
                    }
                }


                arrayN.Text += "\n" + " поменять местами первый положительный и последний отрицательный элементы \n";

                for (int i = 0; i < array.Length; i++)
                {
                    if ( (array[i] > 0) && zet == 0)
                    {
                        zet = 1;
                        inde = i;
                        pol = array[i];
                    }

                    if (array[i] < 0)
                    {
                        indeotr = i;
                        otr = array[i];
                    }
                }

                for (int i = 0; i < array.Length; i++) // Запись с замещёнными с друг другом элементами
                {
                    if (i == inde)
                    {
                        arrayN.Text += otr + " ";
                        continue;
                    }

                    if (i == indeotr) 
                    {
                        arrayN.Text += pol + " ";
                        continue;
                    }

                    arrayN.Text += array[i].ToString() + " ";
                }
                array[inde] = otr; // Меняем  местами
                array[indeotr] = pol;
                arrayN.Text += "\n" + $"перый поло-ый = {pol} и посл. отрец. = {otr} ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        /// <summary>
        ///  Кнопка добавления чисел в первый массив, и работа с первым массивом
        /// </summary>

        private void addList_Click(object sender, RoutedEventArgs e)
        {
            arrayBox.Clear();
            try // Для не предвиденных ситуаций с пользователем
            {   // Проверка на пустоту полей
                if (BoxNumber1.Text == "" || BoxNumber2.Text == "" || BoxNumber3.Text == "" || BoxNumber4.Text == "" || BoxNumber5.Text == "" ||
                    BoxNumber6.Text == "" || BoxNumber7.Text == "" || BoxNumber8.Text == "" || BoxNumber9.Text == "" || BoxNumber10.Text == "")
                {
                    MessageBox.Show("Заполните поля массива");
                }
                else
                {  // Заполнения массива
                    int z = 0;
                    double summ = 0;
                    double x1 = Convert.ToInt32(BoxNumber1.Text);
                    double x2 = Convert.ToInt32(BoxNumber2.Text);
                    double x3 = Convert.ToInt32(BoxNumber3.Text);
                    double x4 = Convert.ToInt32(BoxNumber4.Text);
                    double x5 = Convert.ToInt32(BoxNumber5.Text);
                    double x6 = Convert.ToInt32(BoxNumber6.Text);
                    double x7 = Convert.ToInt32(BoxNumber7.Text);
                    double x8 = Convert.ToInt32(BoxNumber8.Text);
                    double x9 = Convert.ToInt32(BoxNumber9.Text);
                    double x10 = Convert.ToInt32(BoxNumber10.Text);
                    double[] array = new double[] { x1, x2, x3, x4, x5, x6, x7, x8, x9, x10 };
                    for (int i = 0; i < array.Length; i++)  // Поиск нечётных чисел в массиве, и сразу же подсчёт суммы
                    {
                        arrayBox.Text += array[i].ToString() + " ";  
                        if (array[i] % 2 != 0)
                        {
                            summ += array[i];
                        }
                    }
                    arrayBox.Text += "\n" + "Сумма не чётных чисел = " + summ;
                    arrayBox.Text += "\n" + $"Индекс(ы) массивы, которые больше числа {Anumber.Text} -> ";
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] > Convert.ToInt32(Anumber.Text))
                        {
                            arrayBox.Text += i + " ";
                        }
                        else
                        {
                            arrayBox.Text += "Нету" + " ";
                        }
                    }

                    arrayBox.Text += "\n" + $"положительные элементы, кратные {knumber.Text} -> ";
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] > 0)
                        {
                            if (array[i] % Convert.ToInt32(knumber.Text) == 0)
                                arrayBox.Text += array[i].ToString() + " ";
                        }
                    }

                    arrayBox.Text += "\n" + $"Заменить первый элемент, кратный 5, нулем -> ";
                    for (int i = 0; i < array.Length; i++)
                    {
                        if ((array[i] % 5 == 0) && (z == 0))
                        {
                            z = 1;
                            array[i] = 0;
                        }
                        arrayBox.Text += array[i].ToString() + " ";
                    }
                }
            }
            catch (Exception ex) // Вывод об ошибке
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
