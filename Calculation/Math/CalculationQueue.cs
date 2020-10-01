using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation.Math
{
    public class CalculationQueue
    {
        private List<Brackets> bracketsList;

        public CalculationQueue(string expression)
        {
            bracketsList = new List<Brackets>();

            char[] expressionSymbols = expression.ToCharArray();
            for (int i = 0; i < expressionSymbols.Length; i++)
            {
                if (expressionSymbols[i].Equals('('))
                {
                    char[] symbols = new char[expressionSymbols.Length - i];
                    for (int j = 0; j < symbols.Length; j++)
                        symbols[j] = expressionSymbols[i + j];
                    Brackets brackets = new Brackets();
                    i += brackets.CheckSymbols(symbols);
                    if (i == -1)
                        return;
                }
            }
        }
    }
}
