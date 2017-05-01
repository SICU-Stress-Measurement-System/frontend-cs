using StressMeasurementSystem.Models;

namespace StressMeasurementSystem.ViewModels
{
    public class PatientViewModel
    {
        private Patient _patient;

        public PatientViewModel()
        {
            _patient = new Patient();
        }

        public PatientViewModel(Patient patient)
        {
            _patient = patient;
        }
    }
}