using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    class StringEquationCalculator
    {

        StringToSignsAndNumbersExtractor extractor;
        ReduceNumbersAndSignsToNumber reducer;
        public StringEquationCalculator(StringToSignsAndNumbersExtractor extractor, ReduceNumbersAndSignsToNumber reducer)
        {
            this.extractor = extractor;
            this.reducer = reducer;
        }

        public double? Calculate(string equation)
        {
            List<object> numbersAndSigns = extractor.Extract(equation);

            return reducer.Reduce(numbersAndSigns);
        }



    }
}
