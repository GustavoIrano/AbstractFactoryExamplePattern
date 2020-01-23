using System;

namespace EmergencyCall.Creational___Abstract_Factory
{
    public abstract class Patient
    {
        public Patient(string symptom, Priority priority)
        {
            Symptom = symptom;
            Priority = priority;
        }

        public string Symptom { get; set; }
        public Priority Priority { get; set; }
    }

    public class PatientPriorityHigh : Patient
    {
        public PatientPriorityHigh(string symptom, Priority priority) : base(symptom, priority)
        {
        }
    }

    public class PatientPriorityAverage : Patient
    {
        public PatientPriorityAverage(string symptom, Priority priority) : base(symptom, priority)
        {
        }
    }

    public class PatientPriorityLow : Patient
    {
        public PatientPriorityLow(string symptom, Priority priority) : base(symptom, priority)
        {
        }
    }

    public class PatientCreator
    { 
        public static Patient Create(string symptom, Priority priority)
        {
            switch(priority)
            {
                case Priority.High:
                    return new PatientPriorityHigh(symptom, priority);
                case Priority.Average:
                    return new PatientPriorityAverage(symptom, priority);
                case Priority.Low:
                    return new PatientPriorityLow(symptom, priority);
                default:
                    throw new ApplicationException("Incorrectly informed patient");
            }
        }
    }
}