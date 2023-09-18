using System.Reflection.Metadata;

namespace Gates
{
    public interface ILogicGate
    {
        bool Evaluate();
    }
    
    public class ANDGate : ILogicGate
    {
        private ILogicGate input1;
        private ILogicGate input2;
        
        public ANDGate (ILogicGate input1, ILogicGate input2 )
        {
            this.input1 = input1;
            this.input2 = input2;
        }

        public bool Evaluate()
        {
            return input1.Evaluate() && input2.Evaluate();
        }
    }
    public class NOTGate : ILogicGate
    {
            private ILogicGate input;

            public NOTGate(ILogicGate input)
            {
                this.input = input;
            }
            public bool Evaluate()
            {
                return !input.Evaluate();
            }
    }
    public class ORGate : ILogicGate
    {
            private ILogicGate input1;
            private ILogicGate input2;

            public ORGate(ILogicGate input)
            {
                this.input1 = input1;
                this.input2 = input2;
            }
            public bool Evaluate()
            {
                return input1.Evaluate() || input2.Evaluate();
            }
    }
}
