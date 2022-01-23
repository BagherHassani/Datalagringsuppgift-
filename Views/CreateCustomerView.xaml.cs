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
using uppgift1Datalagring.Views;

namespace uppgift1Datalagring.Views
{
    /// <summary>
    /// Interaction logic for CreatCustomerView.xaml
    /// </summary>
    public partial class CreatCustomerView : UserControl
    {
        SqlService _sqlservice = new SqlService();
        public CreatCustomerView()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, RoutedEventArgs e)
        {
            
            CustomerAddToDatebase();
            
           

            
            
        }
       private void CustomerAddToDatebase()
        {
            
                _sqlservice.CreatCustomer(new Models.Customer { Name = tbNamn.Text,
                    Email = tbEmail.Text, telefonummer = int.Parse(tbTelefonummer.Text),
                    Mobilenummer = int.Parse( tbTelefonummer.Text),


                    Adress = new Models.Adress
                    {
                        StreetName = tbGatuadress.Text,
                        PostalCode = tbPostNummer.Text,
                        City = tbStad.Text,
                        Country = tbLand.Text
                    }
                });
           
        }
       
    }
}
