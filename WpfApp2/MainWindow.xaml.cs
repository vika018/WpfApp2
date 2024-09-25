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

namespace WpfApp2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = 1234;
            string str = a.ToString();
            int[] b = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                b[i] = str[i];
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                int l = 5;
                int[] a = new int[l];
                set(a, 0, 1);
                Console.ReadKey(true);
            }
            static void set(int[] a, int n, int l) 
            {
                for (int i = 0; i < l; i++)
                {
                    int j;
                    for (j = 0; j < n; j++)
                    {
                        if (a[j] == i + 1)
                            break;
                        if (j == n)
                        {
                            a[n] = i + 1;
                            if (n < l - 1) set(a, n + 1, l);
                            else
                            {
                             for (int k = 0; k < l; k++)
                                    Console.Write(a[k]);
                             Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }
    }
}
