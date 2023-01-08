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

namespace Prb.ShoppingCart.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double price = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Als de checkbox geselecteerd is, voeg het artikel toe aan de lijst

        private void CkbCroissant_Checked(object sender, RoutedEventArgs e)
        {
            if (ckbCroissant.IsChecked == true)
            {
                lstOrder.Items.Add("Croissant €1.5");
            }
        }

        private void CkbDonutChocolade_Checked(object sender, RoutedEventArgs e)
        {
            if (ckbDonutChocolade.IsChecked == true)
            {
                lstOrder.Items.Add("Chocolade Donut €1.5");
            }
        }

        private void CkbDonutWit_Checked(object sender, RoutedEventArgs e)
        {
            if (ckbDonutWit.IsChecked == true)
            {
                lstOrder.Items.Add("Witte Donut €1.5");
            }
        }

        private void CkbChocoladeKoek_Checked(object sender, RoutedEventArgs e)
        {
            if (ckbChocoladeKoek.IsChecked == true)
            {
                lstOrder.Items.Add("ChocoladeKoek €1.5");
            }
        }

        private void CkbBoterKoek_Checked(object sender, RoutedEventArgs e)
        {
            if (ckbCroissant.IsChecked == true)
            {
                lstOrder.Items.Add("Boterkoek €1.5");
            }
        }

        private void CkbSpeculoosKoek_Checked(object sender, RoutedEventArgs e)
        {
            if (ckbSpeculoosKoek.IsChecked == true)
            {
                lstOrder.Items.Add("SpeculoosKoek €1.5");
            }
        }

        private void CkbSuisse_Checked(object sender, RoutedEventArgs e)
        {
            if (ckbSuisse.IsChecked == true)
            {
                lstOrder.Items.Add("Ronde Suisse €1.5");
            }
        }

        private void CkbRozijnenKoek_Checked(object sender, RoutedEventArgs e)
        {
            if (ckbRozijnenKoek.IsChecked == true)
            {
                lstOrder.Items.Add("RozijnenKoek €1.5");
            }
        }


        //Wanneer er op de knop wordt gedrukt zal deze de geselecteerde items tonen met hun eigen prijs en de totaalprijs

        private void BtnToCart_Click(object sender, RoutedEventArgs e)
        {
            Calculation();
            tbkAmount.Visibility = Visibility.Visible;
            lstOrder.Visibility = Visibility.Visible;
            btnPay.Visibility = Visibility.Visible;
            grbCart.Visibility = Visibility.Visible;

            btnToCart.Visibility = Visibility.Collapsed;
            grbArticles.Visibility = Visibility.Collapsed;
            ckbBoterKoek.Visibility = Visibility.Collapsed;
            ckbChocoladeKoek.Visibility = Visibility.Collapsed;
            ckbCroissant.Visibility = Visibility.Collapsed;
            ckbDonutChocolade.Visibility = Visibility.Collapsed;
            ckbDonutWit.Visibility = Visibility.Collapsed;
            ckbRozijnenKoek.Visibility = Visibility.Collapsed;
            ckbSpeculoosKoek.Visibility = Visibility.Collapsed;
            ckbSuisse.Visibility = Visibility.Collapsed;
        }

        //Er wordt een messagebox getoond aan de klant wanneer de klant de bestelling mag afhalen.
        private void BtnPay_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Beste klant, bedankt voor uw bestelling! u mag deze vanaf 07:00 komen afhalen.",
                            "BEDANKT!", MessageBoxButton.OK, MessageBoxImage.Information);

            lstOrder.Items.Clear();
            ckbBoterKoek.IsChecked = false;
            ckbChocoladeKoek.IsChecked = false;
            ckbCroissant.IsChecked = false;
            ckbDonutChocolade.IsChecked = false;
            ckbDonutWit.IsChecked = false;
            ckbRozijnenKoek.IsChecked = false;
            ckbSpeculoosKoek.IsChecked = false;
            ckbSuisse.IsChecked = false;

            tbkAmount.Visibility = Visibility.Collapsed;

            price = 0;

            lstOrder.Visibility = Visibility.Collapsed;
            tbkAmount.Visibility = Visibility.Collapsed;
            btnPay.Visibility = Visibility.Collapsed;
            grbCart.Visibility = Visibility.Collapsed;



            btnToCart.Visibility = Visibility.Visible;
            grbArticles.Visibility = Visibility.Visible;
            ckbBoterKoek.Visibility = Visibility.Visible;
            ckbChocoladeKoek.Visibility = Visibility.Visible;
            ckbCroissant.Visibility = Visibility.Visible;
            ckbDonutChocolade.Visibility = Visibility.Visible;
            ckbDonutWit.Visibility = Visibility.Visible;
            ckbRozijnenKoek.Visibility = Visibility.Visible;
            ckbSpeculoosKoek.Visibility = Visibility.Visible;
            ckbSuisse.Visibility = Visibility.Visible;
        }


        // berekening van de totaalprijs
        private void Calculation()
        {
            if (ckbCroissant.IsChecked == true)
            {
                price += 1.50;
            }
            if (ckbDonutChocolade.IsChecked == true)
            {
                price += 1.50;
            }
            if (ckbDonutWit.IsChecked == true)
            {
                price += 1.50;
            }
            if (ckbChocoladeKoek.IsChecked == true)
            {
                price += 1.50;
            }
            if (ckbBoterKoek.IsChecked == true)
            {
                price += 1.50;
            }
            if (ckbSpeculoosKoek.IsChecked == true)
            {
                price += 1.50;
            }
            if (ckbSuisse.IsChecked == true)
            {
                price += 1.50;
            }
            if (ckbRozijnenKoek.IsChecked == true)
            {
                price += 1.50;
            }

            tbkAmount.Text = $"€ {Math.Round(price,2).ToString()}";
        }

    }
}
