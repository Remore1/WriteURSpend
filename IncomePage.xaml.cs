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

namespace WriteUrSpend
{
    /// <summary>
    /// Логика взаимодействия для IncomePage.xaml
    /// </summary>
    public partial class IncomePage : Page
    {
        public IncomePage()
        {
            InitializeComponent();
            NavigationService navigation = NavigationService.GetNavigationService(this);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            NavigationService navigation = NavigationService.GetNavigationService(this);
        }
    }
}
