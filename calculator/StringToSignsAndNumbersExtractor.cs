using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace calculator
{
    interface StringToSignsAndNumbersExtractor
    {
        List<object> Extract(string equation);
    }

    class DefualtStringToSignsAndNumbersExtractor : StringToSignsAndNumbersExtractor
    {
        List<object> Extract(string equation)
        {

        }
    }
}
