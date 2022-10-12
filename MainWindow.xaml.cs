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
           
           // var listCategory =
            InitializeComponent();
            using (WriteUrSpendEntities writeUrSpendEntities = new WriteUrSpendEntities())
            {
                var listCategory = writeUrSpendEntities.CategoriesBuy.Select(c => c.Category).ToList();
                NameCategory.ItemsSource = listCategory;
                NameCategory.SelectedIndex = 0;
            }
            TypePayment.ItemsSource = new string[] {"Картой", "Наличные" };
            TypePayment.SelectedIndex = 0;

        }

        private void SaveOperation_Click(object sender, RoutedEventArgs e)
        {
            using (WriteUrSpendEntities writeUrSpendEntities = new WriteUrSpendEntities())
            {
                
                try
                {
                    HistoryBuy historyBuy = new HistoryBuy()
                    {
                        DateBuy = DateTime.Now,
                        NameProduct = NameBuy.Text,
                        IsBuyMadeCard = true,
                        SumBuy = (float)Convert.ToDouble(Sum.Text),
                        NameCategory = NameCategory.SelectedItem.ToString()
                    };
                    if (TypePayment.SelectedItem.ToString() == "Наличные") historyBuy.IsBuyMadeCard = false;

                    writeUrSpendEntities.HistoryBuy.Add(historyBuy);
                    writeUrSpendEntities.SaveChanges();
                    
                    
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                


            }
        }
    }
}
