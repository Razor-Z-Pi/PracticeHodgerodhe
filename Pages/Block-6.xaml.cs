using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Block_6.xaml
    /// </summary>
    public partial class Block_6 : Page
    {
        /// <summary>
        ///  Определение путей и ссылок для текстовых файлов
        /// </summary>

        string patch = @"Doc.txt";
        string patch1 = @"Doc33.txt";

        string fileZ = "f1.txt";
        string fileY = "f2.txt";

        string fi = "f3.txt";
        string fe = "f4.txt";

        string tex1 = "text0.txt";
        string tex2 = "text1.txt";

        string roza = "fsravnenie.txt";
        string roza1 = "ffsravnenie.txt";

        public Block_6()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Кнопка для создания файла по заданию 6.1
        /// </summary>

        private void Creates_Click(object sender, RoutedEventArgs e)
        {
            ff.Content = ""; // Предварительная чистка полей
            ff2.Content = "";
            int[] array = new int[4]; // Массив для чисел
            int zet = 7; // Переменная для отчёта с определённого числа, то есть тут будет начинаться с 7
            DirectoryInfo directoryInfo = new DirectoryInfo(patch); // Для создания, перемещения и перечисления в каталогах и подкаталогах. Поиск файла в катологе
            DirectoryInfo directoryInfo1 = new DirectoryInfo(patch1);
            FileInfo info = new FileInfo(patch); // Метод для работы с файлом (Например при отсуствие его в катологе, то есть создание).
            FileInfo info1 = new FileInfo(patch1);

            if (!directoryInfo.Exists) // Для поиска существование файла
            {
                using (StreamWriter sw = info.CreateText()) // Создание файла
                {
                    for (int i = 0; i < 4; i++) // Заполение массива с определённого числа
                    {
                        array[i] = zet;
                        zet += 1;
                        sw.Write(array[i]);
                        ff.Content += " " + array[i]; // Помещения информации в Label
                    }
                }
            }

            int[] array1 = new int[5]; // Массив для задания, в 5-й элемент 33
            zet = 7;
            if (!directoryInfo1.Exists)
            {
                using (StreamWriter sw = info1.CreateText())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        array1[i] = zet;
                        zet += 1;
                        array1[array1.Length - 1] = 33;
                        sw.Write(array1[i]);
                        ff2.Content += " " + array1[i];
                    }
                }
            }
        }

        /// <summary>
        /// Кнопка для создания файла по заданию 6.2
        /// </summary>

        private void Addword_Click(object sender, RoutedEventArgs e)
        {
            f1.Content = "";
            f2.Content = "";
            int[] array = new int[7];
            Random random = new Random(); // Класс позволяющей использовать метод для случайного числа
            DirectoryInfo directoryInfo = new DirectoryInfo(fileZ);
            DirectoryInfo directoryInfo1 = new DirectoryInfo(fileY);
            FileInfo info = new FileInfo(fileZ);
            FileInfo info1 = new FileInfo(fileY);

            if (!directoryInfo.Exists)
            {
                using (StreamWriter sw = info.CreateText())
                {
                    for (int i = 0; i < 7; i++)
                    {
                        array[i] = random.Next(1, 40); // Заполняем случайными числами то 1 до 40; 

                        sw.Write(array[i]);
                        f1.Content += " " + array[i];
                    }
                }
            }

            /// <summary>
            /// Поиск значения которых меньше  «20». Вывести на экран файл  f2.
            /// </summary>

            if (!directoryInfo1.Exists)
            {
                using (StreamWriter sw = info1.CreateText())
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (array[i] < 20)
                        {
                            sw.Write(array[i]);
                            f2.Content += " " + array[i];
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Кнопка для создания файла по заданию 6.3
        /// </summary>

        private void Addnum_Click(object sender, RoutedEventArgs e)
        {
            f3.Content = "";
            f4.Content = "";
            int[] array = new int[7]; // Массив для первого файла
            int[] array1 = new int[7];// Массив для второго файла
            Random random = new Random();
            DirectoryInfo directoryInfo = new DirectoryInfo(fi);
            DirectoryInfo directoryInfo1 = new DirectoryInfo(fe);
            FileInfo info = new FileInfo(fi);
            FileInfo info1 = new FileInfo(fe);
            int sum = 0; // Переменная для суммы с посчётом двух файлов 

            if (!directoryInfo.Exists)
            {
                using (StreamWriter sw = info.CreateText())
                {
                    for (int i = 0; i < 7; i++)
                    {
                        array[i] = random.Next(1, 20);
                        if (array[i] < 4)
                            sum += array[i];
                        sw.Write(array[i]);
                        f3.Content += " " + array[i];
                    }
                }
            }

            if (!directoryInfo1.Exists)
            {
                using (StreamWriter sw = info1.CreateText())
                {
                    for (int i = 0; i < 7; i++)
                    {
                        array1[i] = random.Next(1, 20);
                        if (array1[i] < 7)
                            sum += array1[i];
                        sw.Write(array1[i]);
                        f4.Content += " " + array1[i];                        
                    }
                }
            }
            obsh.Content = sum;

        }

        /// <summary>
        /// Кнопка для создания файла по заданию 6.4
        /// </summary>

        private void Udvoit_Click(object sender, RoutedEventArgs e)
        {
            f5.Content = "";
            f6.Content = "";
            DirectoryInfo directoryInfo = new DirectoryInfo(tex1);
            DirectoryInfo directoryInfo1 = new DirectoryInfo(tex2);
            FileInfo info = new FileInfo(tex1);
            FileInfo info1 = new FileInfo(tex2);
            string str = udv.Text, s; // Первая переменная получает данные введёные пользователем в соответствующее поле, вторая переменная для работы с  подстрокой 

            if (!directoryInfo.Exists)
            {
                using (StreamWriter sw = info.CreateText())
                {
                    sw.Write(str);
                    f5.Content = str;
                }
            }

            int n = str.Length; //  Длина введённого текста пользователем
            String[] list = new string[n]; // Создания строкового массива для слова

            if (!directoryInfo1.Exists)
            {
                using (StreamWriter sw = info1.CreateText())
                {
                    for (int i = 0; i < n; i++) // Цикл считает по длине и каждой буквы
                    {
                        s = str.Substring(i, 1); //Помещяем каждую букву в массив
                        list[i] = s;
                        if (list[i] == "к" || list[i] == "К") // Для сравнения есть ли такие буквы, и в итоге удваиваем!!!
                        {
                            sw.Write(list[i]);                          
                            f6.Content += list[i];
                        }
                        sw.Write(list[i]);
                        f6.Content += list[i];
                    }

                }
            }
        }

        /// <summary>
        /// Кнопка для создания файла по заданию 6.5
        /// </summary>

        private void Sravn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                k.Content = "";
                DirectoryInfo directoryInfo = new DirectoryInfo(roza);
                DirectoryInfo directoryInfo1 = new DirectoryInfo(roza1);
                FileInfo info = new FileInfo(roza);
                FileInfo info1 = new FileInfo(roza1);
                string str = texter.Text;

                if (!directoryInfo.Exists)
                {
                    using (StreamWriter sw = info.CreateText())
                    {
                        sw.Write(str);
                    }
                }

                int n = str.Length;
                int number = Int32.Parse(numberSr.Text); // Число введённое с поля самим пользователем, переводим тип со строкового в целочисленный

                if (!directoryInfo1.Exists)
                {
                    using (StreamWriter sw = info1.CreateText()) 
                    {
                        if (n > number) // Сравение для строки со числом
                            k.Content = $"{number} < длины строки {n}";
                        else
                            k.Content = $"{number} > длины строки {n}";

                        if (n == number)
                            k.Content = $"{number} = с длиной строки {n}";
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        /// <summary>
        /// Кнопки для просмотра всех фалов, для проверки соответствия с заданием
        /// </summary>

        private void File_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", patch);
            System.Diagnostics.Process.Start("notepad.exe", patch1);
        }

        private void File1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", fileZ);
            System.Diagnostics.Process.Start("notepad.exe", fileY);
        }

        private void File2_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", fi);
            System.Diagnostics.Process.Start("notepad.exe", fe);
        }

        private void File3_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", tex1);
            System.Diagnostics.Process.Start("notepad.exe", tex2);
        }

        private void File4_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", roza);
        }
    }
}