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
    /// Логика взаимодействия для DayCard.xaml
    /// </summary>
    public partial class DayCard : UserControl
    {

        public string Day { get; set; } = "29";
        public DayCard()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Image_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show(Day);
        }

    }
}
