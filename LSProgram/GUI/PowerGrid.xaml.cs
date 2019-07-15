using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LSProgram.GUI
{
    public partial class PowerGrid : Window
    {
        internal static ObservableCollection<Oplitis> Persons;

        public PowerGrid()
        {
            InitializeComponent();
            fillTable();
            //Persons = new ObservableCollection<Oplitis>();

            //for (int i = 0; i < 10; i++)
            //{
            //    Oplitis op1 = new Oplitis();
            //    op1.AM = "12345";
            //    op1.Onoma = "Hlias";
            //    op1.Epwnimo = "Μπακλαγής";
            //    op1.Swma = "ΕΠ";
            //    op1.Enoplos = false;

            //    Persons.Add(op1);
            //}

            //dataGrid.ItemsSource = Persons;

        }

        private void fillTable()
        {
            var jsonText = File.ReadAllText(@"D:\Desktop\oplites.txt", Encoding.UTF8);
            var model = JsonConvert.DeserializeObject<List<Oplitis>>(jsonText);
            dataGrid.ItemsSource = model;
        }

        internal void updateContents(Oplitis opl)
        {
            dataGrid.Items.Add(opl);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //new DimiourgiaOpliti(this).Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButton.YesNo, MessageBoxImage.Question);
            Console.WriteLine(confirmResult);
            if (confirmResult == MessageBoxResult.Yes)
            {
                dataGrid.Items.RemoveAt(dataGrid.SelectedIndex);
            }
        }


        private void DataGrid_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int iColumn = dataGrid.CurrentCell.Column.DisplayIndex;
                int iRow = dataGrid.Items.IndexOf(dataGrid.CurrentItem);
                if (iColumn == dataGrid.Columns.Count - 1)
                {
                    if (dataGrid.Items.Count > (iRow + 1))
                    {
                        //  dataGrid.CurrentCell = dataGrid[1, iRow + 1];
                    }
                    else
                    {
                        //focus next control
                    }
                }
                else
                    //dataGrid.CurrentCell = dataGrid.Columns[iColumn+1,Row];
            }
        }
    }
}
