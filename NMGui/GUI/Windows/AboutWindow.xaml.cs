﻿using System.ComponentModel;
using System.Windows;

namespace NMGui.Views.Windows
{
    /// <summary>
    /// Interaction logic for AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : Window, INotifyPropertyChanged
    {
        public AboutWindow()
        {
            InitializeComponent();

            DataContext = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}