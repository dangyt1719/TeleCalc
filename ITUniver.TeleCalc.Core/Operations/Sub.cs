namespace ITUniver.TeleCalc.Core.Operations
{
    public class Sub : IOperation
    {
        public string Name => "Sub";

        public double[] Args {
            set
            {
                var sum = 0d;
                foreach (var item in value)
                {
                    sum = sum - item;
                }
                Result = sum;
            }
            get { return new double[0]; }
        }

        public string Error { get; }

        public double? Result { get; private set; }
    }
}
