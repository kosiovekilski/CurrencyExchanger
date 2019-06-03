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

namespace CurrencyExchanger
{
    public partial class MainWindow : Window
    {

        List<Currency> availableCurrenciesList = new List<Currency>();

        public MainWindow()
        {
            InitializeComponent();

            /* fixed on 21.05.2019 */
            availableCurrenciesList.Add(new Currency("BGN", "Bulgarian Lev", 1));
            availableCurrenciesList.Add(new Currency("EUR", "Euro", 1.95583));
            availableCurrenciesList.Add(new Currency("USD", "United States Dollar", 1.75238));
            availableCurrenciesList.Add(new Currency("GBP", "Pound sterling", 2.23243));
            availableCurrenciesList.Add(new Currency("JPY", "Japanese yen", 1.58662 / 100));

            foreach (Currency c in availableCurrenciesList)
            {
                cmbFrom.Items.Add(c.ToString());
                cmbTo.Items.Add(c.ToString());
            }

            cmbFrom.SelectedIndex = 1;
            cmbTo.SelectedIndex = 2;


        }

        private Currency GetCurrency(String name)
        {
            foreach (Currency c in availableCurrenciesList)
            {
                if (c.name == name)
                    return c;
            }
            return null;
        }

        private void btnExchange_Click(object sender, RoutedEventArgs e)
        {
			Money m = new Money();
			m.amount = Convert.ToDouble(txtFrom.Text);
			m.currency = GetCurrency(cmbFrom.Text);
			
			Currency other = GetCurrency(cmbTo.Text);
			
			if(null == m.currency || null == other){
				MessageBox.Show("fatal error");
				return;
			}

            txtChange.Text = m.changeCurrency(other).ToString();
            
			txtTo.Text = m.amount.ToString();
			
			
        }
    }
}
