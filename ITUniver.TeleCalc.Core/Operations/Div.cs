namespace ITUniver.TeleCalc.Core.Operations
{
    public class Div : IOperation
    {
        public string Name => "Div";

        public double[] Args {
            set
            {
                var res = value[0];
               
                for (int i = 1; i < value.Length; i++)
                {
                    res = res /value[i];
                    
                }
                Result = res;
            }
            get { return new double[0]; }

        }

        public string Error { get; }

        public double? Result { get; private set; }
    }
}
