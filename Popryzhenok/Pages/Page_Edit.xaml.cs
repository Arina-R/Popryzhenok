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
    /// Логика взаимодействия для Page_EditAdd.xaml
    /// </summary>
    public partial class Page_EditAdd : Page
    {

        private AgentCompany currentagent= new AgentCompany();
        public Page_EditAdd(AgentCompany selectedAgent)
        {
            InitializeComponent();

            if (selectedAgent != null)
                currentagent = selectedAgent;

            DataContext = currentagent;
            
        }

 

        private void AgentSaveBtn_Click_1(object sender, RoutedEventArgs e)
        {
            PopryzhenokEntities.GetContext().SaveChanges();
            MessageBox.Show("Информация сохранена");
            Manager.MainFrame.GoBack();
        }

  

        private void AgentBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Page_Agents());
        }
    }
}
