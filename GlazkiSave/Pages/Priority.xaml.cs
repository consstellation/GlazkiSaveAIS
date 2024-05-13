using System.Windows;
using System.Windows.Controls;
using static GlazkiSave.Classes.Storage;

namespace GlazkiSave.Pages
{
    /// <summary>
    /// Логика взаимодействия для Priority.xaml
    /// </summary>
    public partial class Priority : Page
    {
        public Priority() => InitializeComponent();

        private void BackClick(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ViewingAgents());
        }
    }
}

