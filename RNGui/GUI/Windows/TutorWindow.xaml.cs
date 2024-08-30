﻿using RNGui.GUI.Pages;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace RNGui.Views.Windows
{
    /// <summary>
    /// Interaction logic for InstructionsWindow.xaml
    /// </summary>
    public partial class TutorWindow : Window
    {
        private static ObservableCollection<string> Pages =>
            new() { "Overview", "Tasks", "References", "Renaming", "Tools", "Log", "Misc" };

        public TutorWindow()
        {
            InitializeComponent();

            PageList.Items.Clear();
            PageList.ItemsSource = Pages;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
            => LoadPage(Pages[0]);

        private void PageList_SelectionChanged(object sender, SelectionChangedEventArgs e)
            => LoadPage(PageList.SelectedItem as string);

        private void LoadPage(string? content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                return;
            }

            InstructionsTemplate page = new();
            Pager.Content = page;

            page.SetData(Pages.Contains(content) ? content : Pages[0]);
        }
    }
}