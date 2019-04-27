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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mr.Chicken
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void Clear()
        {
            Login.Text = "";
            Password.Password = "";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Recover recover = new Recover();
            recover.Show();
            Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            Register register = new Register();
            register.ShowDialog();
            Clear();
            Show();
        }
        //Вхід в адмін панель
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.P&& (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                MessageBox.Show("You press Ctrl+P :) Welcome to admin panel");
            }
        }
    }
}
