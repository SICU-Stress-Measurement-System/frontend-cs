using System.Collections.Generic;
using StressMeasurementSystem.Models;

namespace StressMeasurementSystem.ViewModels
{
    public class PatientViewModel
    {
        private Patient _patient;

        public PatientViewModel()
        {
            _patient = new Patient(
                new Patient.Name(), 0,
                new Patient.Organization(),
                new List<Patient.PhoneNumber>(),
                new List<Patient.Email>()
            );
        }
    }
}