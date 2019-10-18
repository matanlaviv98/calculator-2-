using System;
using System.Collections.Generic;

namespace calculator
{
    class Program
    {
        


        static void Main(string[] args)
        {
            while (true)
            {

                var extractor = new DefualtStringToSignsAndNumbersExtractor();
                
                
                var reducer = new MasterChiefReducer(slaves);
                var calculator = new StringEquationCalculator(extractor, reducer);
                
            }
        }
    }

}



