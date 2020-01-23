using EmergencyCall.Creational___Abstract_Factory;
using System;

namespace EmergencyCall
{
    public abstract class EmergencyCall
    {
        public EmergencyCall(Priority priority)
        {
            Priority = priority;
        }

        public abstract void Rescue(Patient patient);

        public Priority Priority { get; set; }
    }

    public class EmergencyCallHigh : EmergencyCall
    {
        public EmergencyCallHigh(Priority priority) :base (priority)
        {
        }

        public override void Rescue(Patient patient)
        {
            Console.WriteLine("Rescue emergency called high with symptom: " + patient.Symptom);
        }
    }

    public class EmergencyCallAverage : EmergencyCall
    {
        public EmergencyCallAverage(Priority priority) : base(priority)
        {
        }

        public override void Rescue(Patient patient)
        {
            Console.WriteLine("Rescue emergency called average with symptom: " + patient.Symptom);
        }
    }

    public class EmergencyCallLow : EmergencyCall
    {
        public EmergencyCallLow(Priority priority) : base(priority)
        {
        }

        public override void Rescue(Patient patient)
        {
            Console.WriteLine("Rescue emergency called low with symptom: " + patient.Symptom);
        }
    }

    public class EmergencyCallCreator
    {
        public static EmergencyCall Create(Priority priority)
        {
            switch(priority)
            {
                case Priority.High:
                    return new EmergencyCallHigh(priority);
                case Priority.Average:
                    return new EmergencyCallAverage(priority);
                case Priority.Low:
                    return new EmergencyCallLow(priority);
                default:
                    throw new ApplicationException("Inconsistent call");
            }
        }
    }
}
