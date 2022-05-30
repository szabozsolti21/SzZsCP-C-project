using AsszisztensKliens.DataProviders;
using Common_Library.Models;
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

namespace AsszisztensKliens
{
    /// <summary>
    /// Interaction logic for PatientWindow.xaml
    /// </summary>
    public partial class PatientWindow : Window
    {

        private readonly Patient _patient;
        public PatientWindow(Patient patient)
        {
            InitializeComponent();

            if(patient != null)
            {
                _patient = patient;

                NameTextBox.Text = _patient.Name;
                AdressTextBox.Text = _patient.Adress;
                TAJTextBox.Text = _patient.TAJ;

                CreateButton.Visibility = Visibility.Collapsed;
                UpdateButton.Visibility = Visibility.Visible;
                DeleteButton.Visibility = Visibility.Visible;

            }
            else
            {
                _patient = new Patient();

                CreateButton.Visibility = Visibility.Visible;
                UpdateButton.Visibility = Visibility.Collapsed;
                DeleteButton.Visibility = Visibility.Collapsed;
            }
        }
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidatePatient())
            {
                _patient.Name = NameTextBox.Text;
                _patient.Adress = AdressTextBox.Text;
                _patient.TAJ = TAJTextBox.Text;
                _patient.Complaint = ComplaintTextBox.Text;

                PatientDataProvider.CreatePatient(_patient);

                DialogResult = true;
                Close();
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidatePatient())
            {
                _patient.Name = NameTextBox.Text;
                _patient.Adress = AdressTextBox.Text;
                _patient.TAJ = TAJTextBox.Text;
                _patient.Complaint = ComplaintTextBox.Text;


                PatientDataProvider.UpdatePatient(_patient);

                DialogResult = true;
                Close();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete?", "Question", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                PatientDataProvider.DeletePatient(_patient.Id);

                DialogResult = true;
                Close();
            }
        }

        private bool ValidatePatient()
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                MessageBox.Show("Name should not be empty.");
                return false;
            }

            if (string.IsNullOrEmpty(AdressTextBox.Text))
            {
                MessageBox.Show("Adress should not be empty.");
                return false;
            }

            if (string.IsNullOrEmpty(TAJTextBox.Text))
            {
                MessageBox.Show("TAJ should not be empty.");
                return false;
            }

            //TAJ formátum 
            //if (Ha TAJ formatuma nem okés okés)
            //{
            //    MessageBox.Show("TAJ should be 000 000 000");
            //    return false;
            //}

            if (string.IsNullOrEmpty(ComplaintTextBox.Text))
            {
                MessageBox.Show("Complaint should not be empty.");
                return false;
            }

            return true;
        }
    }
}
