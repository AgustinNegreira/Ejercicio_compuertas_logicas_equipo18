namespace Gates
{
    public class GarageGate : ILogicGate //clase garage implementando la interfaz con el metodo evaluate
    {
        private bool a {get; set;}
        private bool b {get; set;}
        private bool c {get; set;}
        public GarageGate(bool a, bool b, bool c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool Evaluate() //funcionalidad especial
        {
            ILogicGate And1 = new AndGate(this.a, this.b);
            ILogicGate NotA = new NotGate(this.a);
            ILogicGate NotB = new NotGate(this.b);
            //instanciamos los objetos para crear las compuertas (siguendo el esquema de la consigna de izq a derecha)
            bool resultnota = NotA.Evaluate();
            bool resultnotb = NotB.Evaluate();
            //metemos el resultado del metodo evaluate en las variables para usarlo en otras compuertas.
            ILogicGate And2 = new AndGate(resultnota, resultnotb);
            //creo compuerta
            bool resultand1 = And1.Evaluate();
            bool resultand2 = And2.Evaluate();
            //meto en variables
            ILogicGate Or = new OrGate(resultand1, resultand2);
            //creo compuerta
            bool resultor = Or.Evaluate();
            //meto en variable
            ILogicGate andfinal = new AndGate(resultor, this.c);
            //creo compuerta
            return andfinal.Evaluate();
            //la retorno.
        }
    }
}