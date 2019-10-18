using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    interface ReduceNumbersAndSignsToNumber
    {
        public double? Reduce(List<object> signsAndNumbers);
    }

    class MasterChiefReducer : ReduceNumbersAndSignsToNumber
    {
        List<ReduceNumbersAndSignsToNumber> slaves;
        public MasterChiefReducer(List<ReduceNumbersAndSignsToNumber> slaves)
        {
            this.slaves = slaves;
        }

        public double? Reduce(List<object> signsAndNumbers)
        {
            return null;
        }


    }
    static class CreateSalveReducers
    {

        static List<ReduceNumbersAndSignsToNumber> CreateListOfSlaves()
        {
            List<ReduceNumbersAndSignsToNumber> slaves = new List<ReduceNumbersAndSignsToNumber>();
            slaves.Add(new AdditionSlaveReducer());
            slaves.Add(new SubstructionSlaveReducer());
            slaves.Add(new MultiplicationSlaveReducer());
            slaves.Add(new DevisionSlaveReducer());
            slaves.Add(new ParenthesisSlaveReducer());
            return slaves;
        }
    }

    


    class AdditionSlaveReducer : ReduceNumbersAndSignsToNumber
    {

        public double? Reduce(List<object> signsAndNumbers)
        {
            return null;
        }
    }

    class SubstructionSlaveReducer : ReduceNumbersAndSignsToNumber
    {

        public double? Reduce(List<object> signsAndNumbers)
        {
            return null;
        }
    }

    class MultiplicationSlaveReducer : ReduceNumbersAndSignsToNumber
    {

        public double? Reduce(List<object> signsAndNumbers)
        {
            return null;
        }
    }

    class DevisionSlaveReducer : ReduceNumbersAndSignsToNumber
    {

        public double? Reduce(List<object> signsAndNumbers)
        {
            return null;
        }
    }

    class ParenthesisSlaveReducer : ReduceNumbersAndSignsToNumber
    {

        public double? Reduce(List<object> signsAndNumbers)
        {
            return null;
        }
    }
}
