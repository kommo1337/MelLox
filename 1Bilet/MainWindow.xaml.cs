using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace _1Bilet
{
    /* 
        может содержать любые цифры, буквы и символ подчеркивания, 
        при этом первый символ в имени должен быть буквой или символом подчеркивания

        // Это однострочный комментарий
        /* Это уже
        многострочный комментарий *(Без пробела)/
        Еще есть XML комментраии, начинаються с 3 Слэшей и дескриптора служат для созжания документации
        /// <summary>
        ///  Класс Program
        ///  основной класс программы
        ///  выводящий текст "Hello, World!" 
        /// </summary>

        Префекс 0x ??

        1376BCA597A, 137590881B9 175F9081B9A

     */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement el in Calculater.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "AC")
                ResultBox.Text = "";
            else if (str == "=")
            {
                string value = new DataTable().Compute(ResultBox.Text, null).ToString();
                ResultBox.Text = value;
            }
            else
                ResultBox.Text += str;
        }
    }
}
