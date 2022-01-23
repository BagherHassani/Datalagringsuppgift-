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
    /// Interaction logic for CasesView.xaml
    /// </summary>
    public partial class CasesView : UserControl
    {
        SqlService _sqlservice = new SqlService();
        public CasesView()
        {
            InitializeComponent();
        }

        private void AddArendeTolist()
        {
            var _arende = _sqlservice.GetAll();
            if (_arende != null)
            {
                LvCases.Items.Clear();
                foreach (var arende in _arende)
                    LvCases.Items.Add(arende);
                }
        }

        private void btnLiasta_Click(object sender, RoutedEventArgs e)
        {
            AddArendeTolist();
        }
    }
}
