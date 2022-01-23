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
using System.Windows.Navigation;
using System.Windows.Shapes;
using uppgift1Datalagring.Services;

namespace uppgift1Datalagring.Views
{
    /// <summary>
    /// Interaction logic for CustomersView.xaml
    /// </summary>
    public partial class CustomersView : UserControl
    {
        SqlService _sqlservice = new SqlService();
        public CustomersView()
        {
            InitializeComponent();
        }

        private void AddArendeTolist()
        {
            var _customer = _sqlservice.GetAllCustomer(); 
            if (_customer != null)
            {
                lvCustomer.Items.Clear();
                foreach (var customer in _customer)
                    lvCustomer.Items.Add(customer);
            }
        }




        private void btnCustomerLista_Click(object sender, RoutedEventArgs e)
        {
            AddArendeTolist();
        }
    }

}
