using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft;
using Newtonsoft.Json;


namespace Exam_Isupov_42012_v3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        JsonClass jsonClass = new JsonClass();
        string fileName;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            try
            {
                string json = File.ReadAllText(ofd.FileName);
                fileName = ofd.FileName;
                jsonClass.jsonString = json;
                var tourList = JsonConvert.DeserializeObject<Json[]>(json);
                DataTable.ItemsSource = tourList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowAdd addWindow = new WindowAdd (jsonClass); ;
            addWindow.ShowDialog();
        }

        private void BtnSaveAs_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.ShowDialog();
                string filename = saveFileDialog.FileName;
                File.Create($"{filename}.json").Close();
                File.WriteAllText($"{filename}.json", jsonClass.jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                File.WriteAllText(fileName, jsonClass.jsonString);
                MessageBox.Show("Файл сохранен");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
