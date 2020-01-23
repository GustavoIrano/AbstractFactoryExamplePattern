using EmergencyCall.Creational___Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmergencyCall
{
    public class EmergencyCallAverageFactory : EmergencyCallFactory
    {

        public override EmergencyCall CreateEmergencyCalled()
        {
            return EmergencyCallCreator.Create(Priority.Average);
        }

        public override Patient CreatePatient(string symptom, Priority priority)
        {
            return PatientCreator.Create(symptom, priority);
        }
    }
}
