﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClassAbstract1.Entities
{
    internal class Individual : TaxPayer
    {
        public double HeathExpenditures { get; set; }

        public Individual(string name, double anualIncome, double heathExpenditures) : base(name, anualIncome)
        {
            HeathExpenditures = heathExpenditures;
        }
        public override double Tax()
        {
           if(AnualIncome < 20000.00)
            {
               return (AnualIncome * 0.15) - (HeathExpenditures * 0.50);
            }
            else
            {
                return (AnualIncome * 0.25) - (HeathExpenditures * 0.50);
            }
        }
    }
}
