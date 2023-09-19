namespace Gates
{
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
}