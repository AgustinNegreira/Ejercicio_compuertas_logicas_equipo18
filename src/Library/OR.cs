namespace Gates
{
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