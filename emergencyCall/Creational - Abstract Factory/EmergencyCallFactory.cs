using System;
using System.Collections.Generic;
using System.Text;

namespace EmergencyCall.Creational___Abstract_Factory
{
    public abstract class EmergencyCallFactory
    {
        public abstract EmergencyCall CreateEmergencyCalled();
        public abstract Patient CreatePatient(string symptom, Priority priority);
    }
}
