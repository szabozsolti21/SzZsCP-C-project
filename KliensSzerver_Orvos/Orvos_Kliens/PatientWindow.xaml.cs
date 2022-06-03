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
using Common_Library.Models;
using OrvosKliens.DataProviders;

namespace Orvos_Kliens
{
    
    public partial class PatientWindow : Window
    {

        private readonly Patient _patient;
        public PatientWindow(Patient patient)
        {
            InitializeComponent();

            if (patient != null)
            {
                _patient = patient;

                NameLabel.Content = _patient.Name;
                AdressLabel.Content = _patient.Adress;
                TAJLabel.Content = _patient.TAJ;
                ComplaintLabel.Content = _patient.Complaint;

                UpdateButton.Visibility = Visibility.Visible;
                DeleteButton.Visibility = Visibility.Visible;

            }
            else
            {
                _patient = new Patient();

                UpdateButton.Visibility = Visibility.Collapsed;
                DeleteButton.Visibility = Visibility.Collapsed;
            }
        }
        
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if(ValidatePatient())
            {
                _patient.Diagnose = DiagnoseTextBox.Text;

                PatientDataProvider.UpdatePatient(_patient);

                DialogResult = true;

                Close();
            }
        }

        private bool ValidatePatient()
        {
            if (String.IsNullOrEmpty(DiagnoseTextBox.Text))
            {
                MessageBox.Show("A diagnózis mező nem lehet üres!");
                return false;
            }

            return true;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Valóban törölni szeretné a pácienst?", "Question", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                PatientDataProvider.DeletePatient(_patient.Id);

                DialogResult = true;

                Close();
            }
        }
    }
}
