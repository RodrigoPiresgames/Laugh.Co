using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace DefaultNamespace
{
    public class ConsumableManager : MonoBehaviour
    {
        [SerializeField] public Consumable consumable;
        [SerializeField] public ShiftManager sM;

        public Patient patient;

        private void Update()
        {
            patient = sM.shiftPatients[0];
        }

        public ProblemType[] GetApplicableTypesForPatient()
        {
            ProblemType[] applicableTypes = consumable.TreatableTypes.Where(type => patient.problems.Any(problem => problem.Type == type)).ToArray();
            if (applicableTypes.Length == 0)
            {
                return null;
            }
            return applicableTypes;
        }

        public void UseConsumableOnPatient()
        {
            ProblemType[] applicableTypes = GetApplicableTypesForPatient();
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