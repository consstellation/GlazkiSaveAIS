using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using GlazkiSave.Model;
using static GlazkiSave.Classes.Storage;

namespace GlazkiSave.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewingAgents.xaml
    /// </summary>
    public partial class ViewingAgents : Page
    {
        public ViewingAgents() => InitializeComponent();

        /// <summary>
        /// Подгрузка данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var list = new List<AgentType>() { new AgentType { ID = -1, Title = "Все типы" } };
            ((INotifyCollectionChanged)listViewAgents.Items).CollectionChanged += ProductsListChanged;
            list.AddRange(context.AgentType.ToList());
            filterBox.ItemsSource = list;
            filterBox.SelectedIndex = 0;
            sortyBox.SelectedIndex = 0;
            listViewAgents.ItemsSource = context.Agent.ToList();
        }

        /// <summary>
        /// отображение количества агентов на странице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsListChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            try
            {
                countTextBlock.Text = $"Показано {listViewAgents.Items.Count} из {context.Agent.Count()} \n агентов";
            }
            catch (Exception ex)
            {
                ShowError(ex.Message.ToString());
                countTextBlock.Text = string.Empty;
            }
        }

        /// <summary>
        ///  обновление 
        /// </summary>
        public void UpdatingListiew()
        {
            try
            {
                var list = context.Agent.ToList();

                string search = textBoxSearch.Text;
                if (!string.IsNullOrWhiteSpace(search))
                    list = list.Where(a => a.Title.StartsWith(search) || a.Email.StartsWith(search) || a.Phone.StartsWith(search)).ToList();

                var type = filterBox.SelectedItem as AgentType;
                if (type.ID != -1)
                    list = list.Where(a => a.AgentTypeID == type.ID).ToList();

                switch (sortyBox.SelectedIndex)
                {
                    case 1:
                        list = list.OrderBy(a => a.Title).ToList();
                        break;
                    case 2:
                        list = list.OrderByDescending(a => a.Title).ToList();
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:
                        list = list.OrderBy(a => a.Priority).ToList();
                        break;
                    case 6:
                        list = list.OrderByDescending(a => a.Priority).ToList();
                        break;
                }

                listViewAgents.ItemsSource = list;
            }
            catch (Exception ex)
            {
                ShowError(ex.Message.ToString());
            }
        }



        /// <summary>
        /// переход на страницу добавления агента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new AddAgents());
        }


        /// <summary>
        /// переход на страницу редактирования агента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            Agent selected = listViewAgents.SelectedItem as Agent;
            AddAgents materials = new AddAgents() { DataContext = selected, Agent = selected };
            frame.Navigate(materials);
        }


        /// <summary>
        /// удаление агента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var agent = listViewAgents.SelectedItem as Agent;
                if (agent.ProductSale.Count > 0)
                {
                    ShowWarning("У агента есть продажи!");
                    return;
                }

                MessageBoxResult result = ShowQuestion("Вы действительно хотите удалить выбранного агента?");

                if (result == MessageBoxResult.No)
                    return;

                agent.Shop.Clear();
                agent.AgentPriorityHistory.Clear();

                context.Agent.Remove(agent);
                context.SaveChanges();
                ShowInformation("Агент успешно удален!");
                UpdatingListiew();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message.ToString());
            }
        }

        /// <summary>
        /// фильтрация по поиску
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearch_TextChanged(object sender, TextChangedEventArgs e) => UpdatingListiew();

        /// <summary>
        /// фильтрация по типу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => UpdatingListiew();

        /// <summary>
        /// филтррация по имени, цене, приоритету
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortyFilter_SelectionChanged(object sender, SelectionChangedEventArgs e) => UpdatingListiew();

        /// <summary>
        /// выбор нескольких агентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewAgents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            changePriorityButton.Visibility = listViewAgents.SelectedItems.Count > 1 ? Visibility.Visible : Visibility.Collapsed;
            editButton.IsEnabled = deleteButton.IsEnabled = listViewAgents.SelectedItem != null;
        }

        /// <summary>
        /// переход на страницу приорета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changePriorityButton_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Priority());
        }
    }
}

