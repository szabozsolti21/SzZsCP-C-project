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

                FirstNameTextBox.Text = _patient.FirstName;
                LastNameTextBox.Text = _patient.LastName;
                DateOfBirthPicker.SelectedDate = _patient.DateOfBirth;

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
                _patient.FirstName = FirstNameTextBox.Text;
                _patient.LastName = LastNameTextBox.Text;
                _patient.DateOfBirth = DateOfBirthPicker.SelectedDate.Value;

                PatientDataProvider.CreatePatient(_patient);

                DialogResult = true;
                Close();
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidatePatient())
            {
                _patient.FirstName = FirstNameTextBox.Text;
                _patient.LastName = LastNameTextBox.Text;
                _patient.DateOfBirth = DateOfBirthPicker.SelectedDate.Value;

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
            if (string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                MessageBox.Show("First name should not be empty.");
                return false;
            }

            if (string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                MessageBox.Show("Last name should not be empty.");
                return false;
            }

            if (!DateOfBirthPicker.SelectedDate.HasValue)
            {
                MessageBox.Show("Please select a date of birth.");
                return false;
            }
            return true;
        }
    }
}
