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

namespace kalendarik
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        DateTime day = DateTime.Now;
        public Page1()
        {
            InitializeComponent();
            GenerateSigma();

        }

        private void GenerateSigma()
        {
            sigmaPanel.Children.Clear();
            datemama.Text = day.ToString("MMMM, yyyy, г.");


            for (int i = 1; i <= DateTime.DaysInMonth(day.Year, day.Month); i++)
            {
                DayCard d = new DayCard();
                d.Day = i.ToString();
                sigmaPanel.Children.Add(d);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            day = day.AddMonths(1);
            GenerateSigma();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            day = day.AddMonths(-1);
            GenerateSigma();
        }
    }
}
