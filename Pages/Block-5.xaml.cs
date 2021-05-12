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
    /// Логика взаимодействия для Block_5.xaml
    /// </summary>
    
    public partial class Block_5 : Page
    {
        public Block_5()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            numchetChet.Content = "";
            try
            {
                /// <summary>
                /// Первое задание со строкой
                /// </summary

                string text = textWork.Text, s1; // Первая переменная получает данные введёные пользователем в соответствующее поле, вторая переменная для работы с  подстрокой 
                int n = text.Length; //  Длина введённого текста пользователем
                String[] list = new string[n]; // Создания строкового массива для слова
                for (int i = 0; i < n; i++)
                {
                    s1 = text.Substring(i, 1); //Помещяем каждую букву в массив
                    list[i] = s1;

                }
                if ((text.Length > 2) && (text.Length > 4)) // Чтобы срабатывало условие задачи
                {
                    if (text.Length % 2 == 0) // Если чётная длина, то удаляются 2 первых и 2 последних символа. 
                    {
                        numchet.Content = "Длина чётная";
                        for (int i = 0; i < n; i++)
                        {
                            list[0] = "";
                            list[1] = "";
                            list[list.Length - 1] = "";
                            list[list.Length - 2] = "";
                        }
                    }
                    else
                    {
                        numchet.Content = "Длина нечётная";
                    }
                }
                else
                {
                    MessageBox.Show("Строка маленькая, введите больше 4 букв");
                }

                for (int i = 0; i < n; i++)
                {
                    numchetChet.Content += list[i];
                }

                /// <summary>
                /// Второе задание со строкой
                /// </summary
                /// 
                string text1 = "Ина; Володя; Тамара; Василий; Пользователь:";
                txt.Content = text1;

                // разбиваем строку на массив
                var array = text1.Replace(":", "").Split(';');

                // получаем количество слов, заканчивающийся на 'а'.
                // можно было прогнать массив в цикле, но так думаю будет лаконичнее запись
                int count = (from a in array where a[a.Length - 1] == 'а' select a).Count();
                strA.Content = count;
            }
            catch ( Exception ex )
            {
                MessageBox.Show($"{ex.Message}");
            }

        }
    }
}
