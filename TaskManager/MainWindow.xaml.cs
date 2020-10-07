using System;
using System.ComponentModel;
using System.Windows;
using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string PATH = $"{Environment.CurrentDirectory}\\DataList.json";
        private BindingList<Model> _DataList;
        private FileService _fileService;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _fileService = new FileService(PATH);
            try
            {
                _DataList = _fileService.DataLoad();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Close();
                return;
            }
           

            dgList.ItemsSource = _DataList;
            _DataList.ListChanged += DataList_ListChanged;

        }

        private void DataList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _fileService.DataSave(sender);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    Close();
                }
            }

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Delete__Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
