using System.Collections.Generic;
using StressMeasurementSystem.Models;

namespace StressMeasurementSystem.ViewModels
{
    public class PatientViewModel
    {
        private Patient _patient;

        public PatientViewModel()
        {
            _patient = null;
        }

        public PatientViewModel(Patient patient)
        {
            _patient = patient;
        }
    }
}