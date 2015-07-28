namespace Bridge
{
    public class BetterAlgorithm : Algorithm
    {
        public BetterAlgorithm(AlgorithmOperations algorithmOperations)
            : base(algorithmOperations)
        {
        }

        public override byte[] ProcessSignal(byte[] data)
        {
            return AlgorithmOperations.Filter(AlgorithmOperations.MedianFilter(data));
        }

        public override byte[] Postprocessing(byte[] data)
        {
            return AlgorithmOperations.Derivative(AlgorithmOperations.Derivative(data));
        }
    }
}
