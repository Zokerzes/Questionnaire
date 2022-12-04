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

namespace Questionnaire
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int countSymbol;
        public MainWindow()
        {
            InitializeComponent();
            ProgramerProfile programerProfile = new ProgramerProfile();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            countSymbol = countText.Text.Length;
            labelCoutText.Content = $"{countSymbol.ToString()}/500";
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            likeProgramming.Content = $"{Convert.ToInt16(sliderLike.Value*10).ToString()} %";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
