﻿using System;
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
    /// Interaction logic for AcademicManager.xaml
    /// </summary>
    public partial class AcademicManager : Window
    {
        public AcademicManager()
        {
            InitializeComponent();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }
    }
}
