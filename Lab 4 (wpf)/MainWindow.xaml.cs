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

namespace Lab_4__wpf_
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

        static double Inch = 2.54;//в сантиметрах
        static double Foot = 30.48;//в сантиметрах
        static double Mile = 1609;//в метрах
        static double Versta = 1066.8;//в метрах

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resEuro = rateEuro * sumEuro;
            resSum1.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rate2.Text);
            double sumGrivna = Convert.ToDouble(sum2.Text);
            double resGrivna = rateGrivna * sumGrivna;
            resSum2.Text = resGrivna.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rate3.Text);
            double sumDrama = Convert.ToDouble(sum3.Text);
            double resDrama = rateDrama * sumDrama;
            resSum3.Text = resDrama.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double InchToMeter = Convert.ToDouble(longInch.Text);
            double resultLong = InchToMeter * Inch/100;
            resultLongInch. Text= resultLong.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double FootToMeter = Convert.ToDouble(longFoot.Text);
            double resultLong1 = FootToMeter * Foot/100;
            resultLongFoot.Text = resultLong1.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double MileToMeter = Convert.ToDouble(longMile.Text);
            double resultLong2 = MileToMeter * Mile;
            resultLongMile.Text = resultLong2.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double VerstaToMeter = Convert.ToDouble(longVersta.Text);
            double resultLong3 = VerstaToMeter * Versta;
            resultLongVersta.Text = resultLong3.ToString();
        }
    }
}
