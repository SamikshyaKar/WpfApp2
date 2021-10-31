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

namespace WpfApp2frmBookbon2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnclickMe_Click(object sender, RoutedEventArgs e)
        {
            string yourname = txtName.Text.Trim();
            string yourjob = txtJob.Text.Trim();
            if (yourname.Length > 0 && yourjob.Length > 0)
            {

                string msg = string.Format("Hello {0} \n your Job Is {1} : Thank You ", yourname, yourjob);

                MessageBox.Show(msg, "information ");
                txtName.Clear();
                txtJob.Clear();
                txtName.Focus();

            }

            else MessageBox.Show("Enter name and Job ", "Error");
        }
    }
    }

