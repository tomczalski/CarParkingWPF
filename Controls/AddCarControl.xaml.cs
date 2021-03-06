using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


namespace ParkingSystem.Controls
{
    /// <summary>
    /// Logika interakcji dla klasy AddCarControl.xaml
    /// </summary>
    public partial class AddCarControl : UserControl
    {
        public AddCarControl()
        {
            InitializeComponent();
        }

        

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            if (txtBrand.Text == "" || txtModel.Text == "" || txtRegNr.Text == "" || txtSurname.Text == "" || txtBrand.Name == "" || cbType.Text == "")
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd zapisywania", MessageBoxButton.OK);
            }
            else
            {
                //Cars.Add(new Car(txtBrand.Text, txtModel.Text, txtRegNr.Text, txtSurname.Text, txtName.Text, cbType.Text));
                txtBrand.Clear(); txtModel.Clear(); txtRegNr.Clear(); txtSurname.Clear(); txtName.Clear(); cbType.SelectedIndex = -1;
                MessageBox.Show("Dodano samochód", "Dodawanie pomyślne", MessageBoxButton.OK); 
            }
            
        }

        
    }
}
