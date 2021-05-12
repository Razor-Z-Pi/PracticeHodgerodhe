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
using Microsoft.VisualBasic;

namespace PracticeHodgerodhe.Pages
{
    /// <summary>
    /// Логика взаимодействия для Block_7.xaml
    /// </summary>

    public partial class Block_7 : Page
    {       
        public Block_7()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Создали метод-структуру для записей!!!:)
        /// </summary>

        public struct State
        {
            public string Name;
            public string Locations;
            public string editesh;
            public double dlina;
            public string ineac;
        }

        private void BtnSerarch_Click(object sender, RoutedEventArgs e)
        {
            try // Заполняем и создаём записи
            {
                State[] states = new State[] { new State() { Name = "Дозорщик-император", Locations = "Псковское озеро", editesh =  "России", dlina = 78, ineac = "см"},
                                           new State() { Name = "Дыбка степная", Locations = "Астраханская", editesh = "России", dlina = 80, ineac = "мм"},
                                            new State() { Name = "Толстун степной", Locations = "Воронежской губернии", editesh = "России", dlina = 80, ineac = "мм"},
                                            new State() { Name = "Паук-охотник", Locations = "Вся область", editesh = "Япония", dlina = 30, ineac = "см"},
                                            new State() { Name = "Муравьей Мадагаскара", Locations = "Тропичексий лес", editesh = "Мадагаскар", dlina = 4, ineac = "мм"}};

                // Октрываем файл для записи - сопоставляем его с ключем 1
                FileSystem.FileOpen(1, "States.bin", OpenMode.Random);
                for (int i = 0; i < states.Length; i++)
                {
                    // Записываем в файл одну структуру
                    FileSystem.FilePut(1, states[i]);
                }

                // Перематываем файл на начало для последующего чтения, поскольку после записи указатель
                // находится в конце файла. Но мы могли бы также просто закрыть файл и просто открыть.
                FileSystem.Seek(1, 1);

                //---------------------------------------------------------
                // Чтение файла

                // Список, в который заносим значения из файла
                List<State> newStates = new List<State>();

                // Пока не обнаружен конец файла,читаем его
                while (!(FileSystem.EOF(1)))
                {
                    // Создаем новую структуру
                    ValueType tempState = new State();
                    // Заносим в нее данные
                    FileSystem.FileGet(1, ref tempState);
                    //Добавляем ее в список
                    newStates.Add((State)tempState);
                }

                // Закрываем файл
                FileSystem.FileClose(1);

                switch (cmbLocation.SelectedIndex)
                {
                    case 0:
                        // Выводим содержимое списка на экран по выбору пользователя из comboBox
                            Name.Text =  newStates[0].Name;
                            Location.Text = newStates[0].Locations;
                            addition.Text = newStates[0].editesh;
                            liner.Text = newStates[0].dlina.ToString();
                            dl.Content = newStates[0].ineac;
                        break;
                    case 1:
                            Name.Text = newStates[1].Name;
                            Location.Text = newStates[1].Locations;
                            addition.Text = newStates[1].editesh;
                            liner.Text = newStates[1].dlina.ToString();
                            dl.Content = newStates[1].ineac;
                        break;
                    case 2:
                            Name.Text = newStates[2].Name;
                            Location.Text = newStates[2].Locations;
                            addition.Text = newStates[2].editesh;
                            liner.Text = newStates[2].dlina.ToString();
                            dl.Content = newStates[2].ineac;
                        break;
                    case 3:
                            Name.Text = newStates[3].Name;
                            Location.Text = newStates[3].Locations;
                            addition.Text = newStates[3].editesh;
                            liner.Text = newStates[3].dlina.ToString();
                            dl.Content = newStates[3].ineac;
                        break;
                    case 4:
                            Name.Text = newStates[4].Name;
                            Location.Text = newStates[4].Locations;
                            addition.Text = newStates[4].editesh;
                            liner.Text = newStates[4].dlina.ToString();
                            dl.Content = newStates[4].ineac;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
