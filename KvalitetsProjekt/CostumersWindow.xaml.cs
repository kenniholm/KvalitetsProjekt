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

namespace GUI
{
    /// <summary>
    /// Interaction logic for CostumersWindow.xaml
    /// </summary>
    public partial class CostumersWindow : Window
    {
        public CostumersWindow()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void CheckBtn_Click(object sender, RoutedEventArgs e)
        {
            // Call method in Controller
            _2ApplicationLayer.Controller control = new _2ApplicationLayer.Controller();
            control.CheckCustomer();

            // Save ReadLine as string in Controller?

            // Call method in DBcontroller to fetch the list of customer ids on the DB

            // Send list back to Controller, maybe substring the list, and compare the two.

            // If same = true, else false
            

        }

        private void AddCustomerBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
