﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OCROverlay
{
    /// <summary>
    /// Interaction logic for FirstRun.xaml
    /// </summary>
    public partial class FirstRunForm : Window
    {
        public FirstRunForm()
        {
            RunChecks();
            InitializeComponent();
            this.Closing += new CancelEventHandler(FirstRun_Closing);
            RunChecks();
        }

        void FirstRun_Closing(object sender, CancelEventArgs e)
        {
            //closing code
        }

        private void RunChecks()
        {
            if(Screen.AllScreens.Length > 1)
                btn_screens.IsEnabled = true;
        }

        private void btn_languages_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_screens_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
