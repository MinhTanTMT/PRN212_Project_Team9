﻿using PRN212_Project_Team9.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PRN212_Project_Team9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SalesManagementDbContext context = new SalesManagementDbContext();
        public MainWindow()
        {
            InitializeComponent();
            dgv.ItemsSource = context.Products.ToList();
        }
    }
}