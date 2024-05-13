using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using GlazkiSave.Model;
using Microsoft.Win32;
using static GlazkiSave.Classes.Storage;

namespace GlazkiSave.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddAgents.xaml
    /// </summary>
    public partial class AddAgents : Page
    {
        public AddAgents() => InitializeComponent();

        public Agent Agent { get; set; } = new Agent();

        //диалоговое окно выбора фотографии
        System.Windows.Forms.OpenFileDialog fileDialog = new System.Windows.Forms.OpenFileDialog()
        {
            CheckFileExists = true,
            CheckPathExists = true,
            Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png|Все файлы|*.*"
        };
        string oldMainImagePath;

        /// <summary>
        /// Подгрузка данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            oldMainImagePath = Agent.Logo;
            agentTypeComboBox.ItemsSource = context.AgentType.ToList();
            agentsGrid.DataContext = Agent;

            if (Agent.ID != 0)
            {
                idTextBox.IsEnabled = false;
            }
            else
            {
                IDLabel.Visibility = idTextBox.Visibility = Visibility.Collapsed;
            }
        }


        /// <summary>
        /// Выход в главное меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new ViewingAgents());
        }

        /// <summary>
        /// Добавление агента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(titleTextBox.Text) || string.IsNullOrWhiteSpace(agentTypeComboBox.Text) || string.IsNullOrWhiteSpace(priorityTextBox.Text) || string.IsNullOrWhiteSpace(addressTextBox.Text) || string.IsNullOrWhiteSpace(titleTextBox.Text) || 
                    string.IsNullOrWhiteSpace(kPPTextBox.Text) || string.IsNullOrWhiteSpace(directorNameTextBox.Text) || string.IsNullOrWhiteSpace(phoneTextBox.Text) || string.IsNullOrWhiteSpace(emailTextBox.Text))
                    throw new Exception("Основные данные не могут быть пустыми!");
                     
                



                if (Agent.ID == 0)
                {
                    context.Agent.Add(Agent);
                    ShowInformation("Агент добавлен!");
                }
                else
                {
                    context.Entry(Agent).State = System.Data.Entity.EntityState.Modified;
                    ShowInformation("Агент изменен!");
                }

                context.SaveChanges();

                if (!string.IsNullOrWhiteSpace(oldMainImagePath))
                    File.Delete(oldMainImagePath);

                if (!string.IsNullOrWhiteSpace(fileDialog.FileName))
                {
                    if (!string.IsNullOrWhiteSpace(Agent.Logo))
                        File.Delete(Agent.Logo);

                    string format = fileDialog.FileName.Split('.').LastOrDefault();
                    string photoPath = $@"agents/photo_{Agent.ID}.{format}";

                    File.Copy(fileDialog.FileName, photoPath, true);
                    Agent.Logo = photoPath;
                    context.SaveChanges();

                }

            }
            catch (Exception ex)
            {

                ShowError(ex.Message);
            }
            finally
            {
                frame.Navigate(new ViewingAgents());
            }
        }


        /// <summary>
        /// Добавление фотографии агента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UploadImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!(fileDialog.ShowDialog() == DialogResult.OK))
                    return;

                if (new FileInfo(fileDialog.FileName).Length > 1024 * 1024 * 2)
                {
                    ShowWarning("Размер изображения не должен превышать 2 МБ!");
                    fileDialog.FileName = null;
                    return;
                }

                mainImage.Source = new BitmapImage(new Uri(fileDialog.FileName));
            }
            catch (Exception ex)
            {
                ShowError(ex.Message.ToString());
            }
        }


        /// <summary>
        /// Удаление фотографии агента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteImage_Click(object sender, RoutedEventArgs e)
        {
            mainImage.Source = null;
            Agent.Logo = null;
        }


    }
}



