namespace ITUniver.TeleCalc.Core.Operations
{
    public class Pow : IOperation
    {
        public string Name => "Pow";

        public double[] Args
        {
            set
            {
                var res = value[0];
                for (int i = 1; i < value.Length; i++)
                {
                   res = System.Math.Pow(res,value[i]);
                }
                Result = res;
            }
            get { return new double[0]; }
        }

        public string Error { get; }

        public double? Result { get; private set; }
    }
}