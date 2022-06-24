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

namespace ParkingSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this.GetCars();
        }

        public ObservableCollection<Car> Cars = new ObservableCollection<Car>();

        public ObservableCollection<Car> GetCars()
        {
            Cars.Add(new Car() { Brand = "BMW", Model = "e39", RegNr = "RZ 12345", Surname = "Nowak", Name = "Piotr", Type = "Samochód osobowy" });

            return Cars;
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            if (txtBrand.Text == "" || txtModel.Text == "" || txtRegNr.Text == "" || txtSurname.Text == "" || txtBrand.Name == "" || cbType.Text == "")
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Błąd zapisywania", MessageBoxButton.OK);
            }
            else
            {

                Cars.Add(new Car() { Brand = txtBrand.Text, Model = txtModel.Text, RegNr = txtRegNr.Text, Surname = txtSurname.Text, Name = txtName.Text, Type = cbType.Text });
                txtBrand.Clear(); txtModel.Clear(); txtRegNr.Clear(); txtSurname.Clear(); txtName.Clear(); cbType.SelectedIndex = -1;
                MessageBox.Show("Dodano pojazd.", "Dodawanie pomyślne", MessageBoxButton.OK);
            }
        }

        private void delBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (Car el in Cars)
            {
                if (el.RegNr.Equals(txtDelete.Text))
                {
                    Cars.Remove(el);
                    MessageBox.Show("Usunięto pojazd.", "Usuwanie pomyślne", MessageBoxButton.OK);
                    break;
                }
                

            }
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (Car el in Cars)
            {
                if (el.RegNr.Equals(txtSearch.Text))
                {
                    tbBrand.Text = el.Brand;
                    tbModel.Text = el.Model;
                    tbRegNr.Text = el.RegNr;
                    tbSurname.Text = el.Surname;
                    tbName.Text = el.Name;
                    tbType.Text = el.Type;
                }
            }
        }
    }
}
