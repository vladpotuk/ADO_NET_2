using System;
using System.Windows;

namespace ADO_NET_First
{
    public partial class MainWindow : Window
    {
        DBManager dBManager;

        public MainWindow()
        {
            InitializeComponent();
            dBManager = new DBManager();
            dgMain.ItemsSource = dBManager.SelectFromDb();
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string productName = tbProductName.Text;
                dBManager.InsertNewProduct(productName);
                dgMain.ItemsSource = dBManager.SelectFromDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteProductButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int productIdToDelete = int.Parse(tbProductIDToDelete.Text);
                dBManager.DeleteProduct(productIdToDelete);
                dgMain.ItemsSource = dBManager.SelectFromDb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
