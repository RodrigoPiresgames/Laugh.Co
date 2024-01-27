using System.Linq;

namespace DefaultNamespace
{
    static public class ConsumableManager
    {
        

        public static ProblemType[] GetApplicableTypesForPatient(Consumable consumable, Patient patient)
        {
            ProblemType[] applicableTypes = consumable.TreatableTypes.Where(type => patient.problems.Any(problem => problem.Type == type)).ToArray();
            if (applicableTypes.Length == 0)
            {
                return null;
            }
            return applicableTypes;
        }

        public static void UseConsumableOnPatient(Consumable consumable, Patient patient)
        {
            ProblemType[] applicableTypes = GetApplicableTypesForPatient(consumable, patient);
            if (applicableTypes == null)
            {
                return;
            }
            foreach (ProblemType type in applicableTypes)
            {
                Problem problem = patient.problems.First(p => p.Type == type);
                problem.Strength -= consumable.ConsumableStrength;
                if (problem.Strength <= 0)
                {
                    patient.problems = patient.problems.Where(p => p.Type != type).ToArray();
                }
            }
        }
        
    }
}