using System;
using System.Windows;
using static GlazkiSave.Classes.Storage;
using GlazkiSave.Pages;
//чтобы открыть код, сочетание клавиш ctrl + M,  ctrl + L
namespace GlazkiSave
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                frame = mainFrame;
                frame.Navigate(new ViewingAgents());
            }
            catch (Exception ex)
            {
                ShowError(ex.ToString());
            }
        }

        /// <summary>
        /// Выход из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (res == MessageBoxResult.No)
                e.Cancel = true;
        }
    }
}
//flashforward
//qqw//PIA//
