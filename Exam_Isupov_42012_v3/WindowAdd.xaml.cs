using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Exam_Isupov_42012_v3
{

    public partial class WindowAdd : Window
    {
        JsonClass jsonClass;
        string json;
        public WindowAdd()
        {
            InitializeComponent();
        }

        public WindowAdd(JsonClass jsonString)
        {
            InitializeComponent();
            this.jsonClass = jsonString;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            try
            {
                var dataJson = new Json
                {
                    Id = Convert.ToInt32(tbId.Text),
                    Surname = tbSurname.Text,
                    Name = tbName.Text,
                    Patronymic = tbPatronymic.Text,
                    PassportS = Convert.ToInt32(tbPassportS.Text),
                    PassportN = Convert.ToInt32(tbPassportN.Text),
                    Inventory = tbInventory.Text,
                    CostInventory = Convert.ToInt32(tbCostInventory.Text),
                    Deposit = Convert.ToInt32(tbDeposit.Text),
                    Tarrif = Convert.ToInt32(tbTarrif.Text),
                    DateTimeBegin = dpDateBegin.ToString(),
                    DateTimeEnd = dpDateEnd.ToString(),
                    CostRent = Convert.ToInt32(tbCostRent.Text)

                };
                json = JsonConvert.SerializeObject(dataJson);
                Clear();
                var tourList = JsonConvert.DeserializeObject<Json[]>(jsonClass.jsonString);
                mainWindow.DataTable.ItemsSource = tourList;
                mainWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        void Clear()
        {
            try
            {
                if (jsonClass.jsonString != null)
                {
                    json = $"{json}]";
                    jsonClass.jsonString = jsonClass.jsonString.Replace("]", ",");
                    jsonClass.jsonString += json;
                }
                else
                    jsonClass.jsonString = $"[{json}]";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
