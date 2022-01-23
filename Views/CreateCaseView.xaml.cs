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
using uppgift1Datalagring.Models;
using uppgift1Datalagring.Services;

namespace uppgift1Datalagring.Views
{
    /// <summary>
    /// Interaction logic for CreateCaseView.xaml
    /// </summary>
    public partial class CreateCaseView : UserControl
    {
        SqlService _sqlservice = new SqlService();

        public CreateCaseView()
        {
            InitializeComponent();
            
        }

        //private void btnArende_Click(object sender, RoutedEventArgs e)
        //{
           
        //}

        private void AddrendeToDatabase()
        {
            _sqlservice.CreatArende(new Models.Arende { Kund = tbKund.Text, Beskrivning = tbBeskrivning.Text, Rubrik = tbRubrik.Text, Status = tbStatus.Text, Datum = DateTime.Today, DatumChange = DateTime.Now });
            
        }
        private void ClearTextBox()
        {
            tbKund.Text = "";
            tbRubrik.Text = "";
            tbStatus.Text = "";
            tbBeskrivning.Text = "";
        }

        private void btnArende_Click_1(object sender, RoutedEventArgs e)
        {
            AddrendeToDatabase();

            ClearTextBox();
        }
    }
}
