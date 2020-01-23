using System;
using System.Collections.Generic;
using System.Text;

namespace EmergencyCall.Creational___Abstract_Factory
{
    public class AbstractFactoryExecution
    {
        public static void Execute()
        {
            var emergenciesCalled = new List<Patient>
            {
                PatientCreator.Create("Chest pain", Priority.High),
                PatientCreator.Create("Headache", Priority.Average),
                PatientCreator.Create("Flu", Priority.Low)
            };

            emergenciesCalled.ForEach(e => EmergencyCallClient.CreateCall(e).AnswerCall());
        }
    }
}
