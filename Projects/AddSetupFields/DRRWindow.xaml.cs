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

namespace AddSetupFields
{
    /// <summary>
    /// Interaction logic for DRRWindow.xaml
    /// </summary>
    public partial class DRRWindow : Window
    {
        public string DRRparameters { get; set; }
        public bool Prone { get; set; }
        public DRRWindow()
        {
            InitializeComponent();
            AddSetupFields.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (BoneButton.IsChecked == true)
            {
                DRRparameters = "Bone";
            }
            else if (ChestButton.IsChecked == true)
            {
                DRRparameters = "Chest";
            }

            if (ProneCheckBox.IsChecked == true)
            {
                Prone = true;
            }
            else
            {
                Prone = false;
            }
            Close();
        }

        private void BoneButton_Checked(object sender, RoutedEventArgs e)
        {
            AddSetupFields.IsEnabled = true;
        }

        private void ChestButton_Checked(object sender, RoutedEventArgs e)
        {
            AddSetupFields.IsEnabled = true;
        }
    }
}
