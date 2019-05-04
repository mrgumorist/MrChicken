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

namespace Mr.Chicken.AdminPages
{
    /// <summary>
    /// Interaction logic for BotPanel.xaml
    /// </summary>
    public partial class BotPanel : Page
    {
        ServiceReferenceMrChicken.ProgrammServiceClient client = 
            new ServiceReferenceMrChicken.ProgrammServiceClient();

        public BotPanel()
        {
            InitializeComponent();
        }

       
        private async void btnStart_Click(object sender, RoutedEventArgs e)
        {
            await client.StartBotAsync();
        }

        private async void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
        }

        private async void btnStop_Click(object sender, RoutedEventArgs e)
        {
            await client.StopBotAsync();
        }
    }
}
