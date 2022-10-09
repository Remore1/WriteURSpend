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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveOperation_Click(object sender, RoutedEventArgs e)
        {
            using (WriteUrSpendEntities writeUrSpendEntities = new WriteUrSpendEntities())
            {
                // HistoryOperation historyOperation = new HistoryOperation();
                //historyOperation.SumOperation
                try
                {
                    HistoryBuy historyBuy = new HistoryBuy();
                    historyBuy.DateBuy = DateTime.Now;
                    historyBuy.NameProduct = NameBuy.Text;
                    historyBuy.IsBuyMadeCard = true;
                    historyBuy.SumBuy = (float)Convert.ToDouble(Sum.Text);
                    historyBuy.NameCategory = NameCategory.Text;
                }
                catch (Exception exc)
                {

                    MessageBox.Show(exc.Message);
                }
                


            }
        }
    }
}
