using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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

namespace ADO18._12._2024
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DbConnection conn = null;
        DbProviderFactory factory = null;
        string connectionString = "";

        int num = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            conn.ConnectionString = connectionString;
            await conn.OpenAsync();

            DbCommand command = conn.CreateCommand();
            command.CommandText = "WAITFOR DELAY '00:00:10';";

            command.CommandText += textBox.Text;

            DbDataReader reader = await command.ExecuteReaderAsync();
            DataTable table = new DataTable();
            do
            {
                int line = 0;
                while (await reader.ReadAsync())
                {
                    if (line == 0)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            table.Columns.Add(reader.GetName(i));
                        }
                        line++;
                    }

                    DataRow row = table.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader.GetValue(i);
                    }
                    table.Rows.Add(row);
                }
            } while (await reader.NextResultAsync());
            dataGrid.ItemsSource = table.DefaultView;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            conn = factory.CreateConnection();
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Storage;";
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (num % 2 == 0)
                btn.Background = Brushes.Gray;
            else
                btn.Background = Brushes.Red;

            num++;
        }
    }
}
