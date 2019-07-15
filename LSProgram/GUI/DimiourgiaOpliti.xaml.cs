using Newtonsoft.Json;
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
using System.Windows.Shapes;

namespace LSProgram.GUI
{
    /// <summary>
    /// Interaction logic for DimiourgiaOpliti.xaml
    /// </summary>
    public partial class DimiourgiaOpliti : Window
    {
        private PowerGrid pwg;

        public DimiourgiaOpliti(PowerGrid pwg)
        {
            this.pwg = pwg;
            InitializeComponent();
        }

        

        private void Button_Click(object sender, EventArgs e)
        {
            //open file stream
            using (StreamWriter file = File.CreateText(@"D:\Desktop\oplites.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                Oplitis op1 = getOpliti();
                serializer.Serialize(file, op1);
                pwg.updateContents(op1);
                this.Close();
            }
        }

        private Oplitis getOpliti()
        {
            Oplitis opl = new Oplitis();
            opl.Onoma = nameTB.Text;
            opl.Epwnimo = surnameTB.Text;
            opl.Swma = swmaTB.Text;
            opl.Enoplos =  (bool)yesRB.IsChecked;
            return opl;

        }

    }
}
