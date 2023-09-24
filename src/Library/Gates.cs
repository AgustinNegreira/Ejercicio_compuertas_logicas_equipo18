namespace Gates
{
    public interface ILogicGate //creo la interfaz
    {
        bool Evaluate(); //metodo global para evaluar
    }

    public class AndGate : ILogicGate //implemento interfaz
    {
        private bool input1; //campos para almacenar lo que vale cada input en cada objeto (compuerta)
        private bool input2;

        public AndGate(bool input1, bool input2) //constructor para meterle la entradas
        {
            this.input1 = input1;
            this.input2 = input2;
        }

        public bool Evaluate() //metodo global con funcionalidad especial
        {
            return this.input1 && this.input2; //uso del operador and
        }
    }

    //de aqui para abajo lo mismo para todos.
    public class OrGate : ILogicGate
    {
        private bool input1;
        private bool input2;

        public OrGate(bool input1, bool input2)
        {
            this.input1 = input1;
            this.input2 = input2;
        }
        public bool Evaluate()
        {
            return this.input1 || this.input2;
        }
    }
     public class NotGate : ILogicGate
    {
        private bool input;

        public NotGate(bool input)
        {
            this.input = input;
        }
        public bool Evaluate()
        {
            return !this.input;
        }
    }
}