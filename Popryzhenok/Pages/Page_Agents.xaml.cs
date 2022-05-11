using Popryzhenok.Classes;
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

namespace Popryzhenok.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page_Agents.xaml
    /// </summary>
    public partial class Page_Agents : Page
    {
        public Page_Agents()
        {
            InitializeComponent();
            LVAgents.ItemsSource = PopryzhenokEntities.GetContext().AgentCompany.ToList();
        }

        private void But_edit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_EditAdd((sender as Button).DataContext as AgentCompany));
        }
    }
}
