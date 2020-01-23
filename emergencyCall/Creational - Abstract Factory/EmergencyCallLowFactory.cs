using EmergencyCall.Creational___Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmergencyCall
{
    public class EmergencyCallLowFactory : EmergencyCallFactory
    {

        public override EmergencyCall CreateEmergencyCalled()
        {
            return EmergencyCallCreator.Create(Priority.Low);
        }

        public override Patient CreatePatient(string symptom, Priority priority)
        {
            return PatientCreator.Create(symptom, priority);
        }
    }
}
