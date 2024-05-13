using System.Windows;
using System.Windows.Controls;
using GlazkiSave.Model;

namespace GlazkiSave.Classes
{
    class Storage
    {
        /// <summary>
        /// Модель базы данных
        /// </summary>
        public static GlazkiSavePerevalovEntities context = new GlazkiSavePerevalovEntities();

        /// <summary>
        /// Фрэйм для перехода между  страницами
        /// </summary>
        public static Frame frame;

        /// <summary>
        /// Окно для вывода информации
        /// </summary>
        /// <param name="text"></param>
        public static void ShowInformation(string text)
            => MessageBox.Show(text, "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

        /// <summary>
        /// Окно для вывода предупреждения
        /// </summary>
        /// <param name="text"></param>
        public static void ShowWarning(string text)
            => MessageBox.Show(text, "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);

        /// <summary>
        /// Окно для вывода ошибки
        /// </summary>
        /// <param name="text"></param>
        public static void ShowError(string text)
            => MessageBox.Show(text, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);


        public static MessageBoxResult ShowQuestion(string text)
                => MessageBox.Show(text, "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
    }

}