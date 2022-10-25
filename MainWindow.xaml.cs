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
    /// 



    public partial class MainWindow : Window
    {


        public static string DateToday { get; set; }
        public MainWindow()
        {
            //NavigationFrame.Navigate(new IncomePage());

            DateToday = DateTime.Today.ToShortDateString();
            InitializeComponent();
            NavigationService navigation = NavigationService.GetNavigationService(this);

            //lblDateToday.Content = DateToday;
            using (WriteUrSpendEntities writeUrSpendEntities = new WriteUrSpendEntities())
            {
                var listCategory = writeUrSpendEntities.CategoriesBuy.Select(c => c.Category).ToList();
                NameCategory.ItemsSource = listCategory;
                NameCategory.SelectedIndex = 0;
                //string balanceCard = writeUrSpendEntities.CurrentBalance.Select(c => c.CurrentBalanceCard).FirstOrDefault().ToString();
                //var result1 = balanceCard  == null || balanceCard=="" ? BalanceCard.Text = "Oшибка!": BalanceCard.Text = balanceCard; 
                
                //string balanceCash = writeUrSpendEntities.CurrentBalance.Select(c => c.CurrentbalanceCash).FirstOrDefault().ToString();
                //var result2 = balanceCash== null ? BalanceCash.Text = "Oшибка!" : BalanceCash.Text = balanceCash;
                //BalanceCash.Text = writeUrSpendEntities.CurrentBalance.Select(c => c.CurrentbalanceCash).FirstOrDefault().ToString();
                var GeneralBalance = writeUrSpendEntities.CurrentBalance.ToArray();
                if (GeneralBalance.Count() < 1)
                {
                    BalanceCash.Text = "Oшибка!";
                    BalanceCard.Text = "Oшибка!";
                }
                else
                {
                    BalanceCard.Text = GeneralBalance[0].CurrentBalanceCard.ToString();
                    BalanceCash.Text = GeneralBalance[0].CurrentbalanceCash.ToString();
                }
                
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

        private void GotoIncomePage_Click(object sender, RoutedEventArgs e)
        {
            IncomePage incomePage = new IncomePage();
            NavigationFrame.Navigate(incomePage);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NavigationService navigation = NavigationService.GetNavigationService(this);
        }
    }
}
