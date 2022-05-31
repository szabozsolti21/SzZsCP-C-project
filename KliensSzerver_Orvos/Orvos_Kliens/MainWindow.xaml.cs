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
using Common_Library.Models;
using OrvosKliens.DataProviders;

namespace Orvos_Kliens
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdatePatientsListBox();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            var selectedPatient = PatientsListBox.SelectedItem as Patient;

            if (selectedPatient != null)
            {
                var window = new PatientWindow(selectedPatient);
                if (window.ShowDialog() ?? false)
                {
                    UpdatePatientsListBox();
                }

                PatientsListBox.UnselectAll();
            }
        }

        private void Reload_Click(object sender, RoutedEventArgs args)
        {
            UpdatePatientsListBox();
        }

        private void UpdatePatientsListBox()
        {
            var patients = PatientDataProvider.GetPatients().ToList();
            PatientsListBox.ItemsSource = patients;
        }
    }
}
