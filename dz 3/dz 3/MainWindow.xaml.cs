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

namespace dz_3
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
        private int Ujebombit()
        {
            Random rand = new Random();
            int x = rand.Next(1, 10);
            int y = rand.Next(1, 10);
            a.Text = String.Format("{0}", x);
            b.Text = String.Format("{0}", y);
            int k = rand.Next(1,5);
            int randoms1 = rand.Next(-100,100);
            int randoms2 = rand.Next(-100, 100);
            int randoms3 = rand.Next(-100, 100);

            if (k == 1)
            {
                Button1.Content = Convert.ToString(x*y);
                Button2.Content = Convert.ToString(randoms1);
                Button3.Content = Convert.ToString(randoms2);
                Button4.Content = Convert.ToString(randoms3);
            }
            else if (k == 2)
            {
                Button2.Content = Convert.ToString(x*y);
                Button1.Content = Convert.ToString(randoms1);
                Button3.Content = Convert.ToString(randoms2);
                Button4.Content = Convert.ToString(randoms3);
            }
            else if (k == 3)
            {
                Button3.Content = Convert.ToString(x*y);
                Button2.Content = Convert.ToString(randoms1);
                Button1.Content = Convert.ToString(randoms2);
                Button4.Content = Convert.ToString(randoms3);
            }
            else if (k == 4)
            {
                Button4.Content = Convert.ToString(x*y);
                Button2.Content = Convert.ToString(randoms1);
                Button3.Content = Convert.ToString(randoms2);
                Button1.Content = Convert.ToString(randoms3);
            }
            return k;
        }

        int i = 0;
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (Button1.Content == "Проверь")
            {
                i = Ujebombit();
            }

            else
            {
                if (i == 1)
                {
                    TextBox1.Text = (Convert.ToInt32(TextBox1.Text) + 1).ToString();
                    Otvet.Text = "Правильно.";
                }
                else
                {
                    TextBox2.Text = (Convert.ToInt32(TextBox2.Text) + 1).ToString();
                    Otvet.Text = "Неправильно.";
                }

                i = Ujebombit();
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (Button2.Content == "Себя")
            {
                i = Ujebombit();
            }

            else
            {
                if (i == 2)
                {
                    TextBox1.Text = (Convert.ToInt32(TextBox1.Text) + 1).ToString();
                    Otvet.Text = "Правильно.";
                }
                else
                {
                    TextBox2.Text = (Convert.ToInt32(TextBox2.Text) + 1).ToString();
                    Otvet.Text = "Неправильно.";
                }

                i = Ujebombit();
            }
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (Button3.Content == "Прямо")
            {
                i = Ujebombit();
            }

            else
            {
                if (i == 3)
                {
                    TextBox1.Text = (Convert.ToInt32(TextBox1.Text) + 1).ToString();
                    Otvet.Text = "Правильно.";
                }
                else
                {
                    TextBox2.Text = (Convert.ToInt32(TextBox2.Text) + 1).ToString();
                    Otvet.Text = "Неправильно.";
                }

                i = Ujebombit();
            }
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (Button4.Content == "Сейчас")
            {
                i = Ujebombit();
            }

            else
            {
                if (i == 4)
                {
                    TextBox1.Text = (Convert.ToInt32(TextBox1.Text) + 1).ToString();
                    Otvet.Text = "Правильно.";
                }
                else
                {
                    TextBox2.Text = (Convert.ToInt32(TextBox2.Text) + 1).ToString();
                    Otvet.Text = "Неправильно.";
                }

                i = Ujebombit();
            }
        }
    }
}
