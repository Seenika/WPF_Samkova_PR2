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

namespace WPF_Samkova_PR2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Itog.Text = "Ст. гр. ИСиП Самкова К.С.";
        }

        private void Reshiti_Click(object sender, RoutedEventArgs e)
        {
            Itog.Text += Environment.NewLine + "Практическая работа 2";
            Itog.Text += Environment.NewLine + "Вариант 14";
            //Считывание и вывод значения А
            double A = double.Parse(TextA.Text);
            Itog.Text += Environment.NewLine + "A = " + A.ToString();
            //Считывание и вывод значения B
            double B = double.Parse(TextB.Text);
            Itog.Text += Environment.NewLine + "B = " + B.ToString();
            //Считывание и вывод значения C
            double C = double.Parse(TextC.Text);
            Itog.Text += Environment.NewLine + "C = " + C.ToString();
            //Считывание и вывод значения p
            double p = double.Parse(Textp.Text);
            Itog.Text += Environment.NewLine + "p = " + p.ToString();
            //Считывание и вывод значения q
            double q = double.Parse(Textq.Text);
            Itog.Text += Environment.NewLine + "q = " + q.ToString();
            //Вычисления
            double Ap = A * p;
            double Bq = B * q;
            double AA = A * A;
            double BB = B * B;
            double Ver = Ap + Bq + C;
            double Niz = Math.Sqrt(AA + BB);
            double S = Ver / Niz;
            //Вывод результата
            Itog.Text += Environment.NewLine + "Результат S = " + S.ToString();
        }
    }
}
