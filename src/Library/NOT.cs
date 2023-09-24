namespace Gates
{
    public class NOTGates
    {
        public static bool Evaluar(bool input1, bool input2)
        {
            bool resultA = !input1;
            bool resultB = !input2;

            return resultA && resultB;
        }
    }
}
