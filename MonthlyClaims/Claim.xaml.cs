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
using System.Windows.Shapes;

namespace MonthlyClaims
{
    /// <summary>
    /// Interaction logic for Claim.xaml
    /// </summary>
    public partial class Claim : Window
    {
        public Claim()
        {
            InitializeComponent();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Homepage HomePage = new Homepage();
            HomePage.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CheckClaim checkClaim = new CheckClaim();
            checkClaim.Show();
        }

    }
}
