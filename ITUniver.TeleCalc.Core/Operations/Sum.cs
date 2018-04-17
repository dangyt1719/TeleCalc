namespace ITUniver.TeleCalc.Core.Operations
{
    public class Sum : IOperation
    {
        public string Name => "Sum";
        IOperation operation = .FirstOrDefault(o => o.Name == operName);
        public double[] Args {
            set
            {
                var sum = 0d;
                foreach (var item in value)
                {
                    sum = sum + item;
                }
                Result = sum;
            }
            get { return new double[0]; }
        }

        public string Error { get; }

        public double? Result { get; private set; }
    }
}
