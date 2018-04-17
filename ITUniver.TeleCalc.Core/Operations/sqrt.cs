namespace ITUniver.TeleCalc.Core.Operations
{
    public class Sqrt : IOperation
    {
        public string Name => "Sqrt";

        public double[] Args
        {
            set
            {
                var res = value[0];
                for (int i = 1; i < value.Length; i++)
                {
                    res = System.Math.Sqrt(res+value[1]);
                }
                Result = res;
            }
            get { return new double[0]; }
        }

        public string Error { get; }

        public double? Result { get; private set; }
    }
}