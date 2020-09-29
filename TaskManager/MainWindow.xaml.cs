using System.ComponentModel;
using System.Windows;
using TaskManager.Models;


namespace TaskManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<Model> _toDate;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _toDate = new BindingList<Model>()
            {
                new Model(){Task = "test"}
            };

        }
    }
}
