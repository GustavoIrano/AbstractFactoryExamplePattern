using System;
using System.Collections.Generic;
using System.Text;

namespace EmergencyCall.Creational___Abstract_Factory
{
    public class EmergencyCallClient
    {
        private readonly EmergencyCall _emergencyCall;
        private readonly Patient _patient;

        public EmergencyCallClient(EmergencyCallFactory factory, Patient patient)
        {
            _patient = factory.CreatePatient(patient.Symptom, patient.Priority);
            _emergencyCall = factory.CreateEmergencyCalled();
        }

        public void AnswerCall()
        {
            _emergencyCall.Rescue(_patient);
        }

        public static EmergencyCallClient CreateCall(Patient patient)
        {
            switch(patient.Priority)
            {
                case Priority.High:
                    return new EmergencyCallClient(new EmergencyCallHighFactory(), patient);
                case Priority.Average:
                    return new EmergencyCallClient(new EmergencyCallAverageFactory(), patient);
                case Priority.Low:
                    return new EmergencyCallClient(new EmergencyCallLowFactory(), patient);
                default:
                    throw new ApplicationException("Unable to answer call");
            }
        }
    }
}
