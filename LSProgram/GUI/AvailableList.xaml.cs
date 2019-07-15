using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace LSProgram.GUI
{
    /// <summary>
    /// Interaction logic for AvailableList.xaml
    /// </summary>
    public partial class AvailableList : Window
    {
        public AvailableList()
        {
            InitializeComponent();
            
            listBox1.ItemsSource = PowerGrid.Persons.Select(l => l.Epwnimo).ToList();
        }


    }
}
