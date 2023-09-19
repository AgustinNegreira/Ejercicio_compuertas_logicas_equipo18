using System.Reflection.Metadata;

namespace Gates
{
    public interface ILogicGate
    {
        bool Evaluate();
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
}
