namespace Bridge
{
    public class Algorithm
    {

        protected AlgorithmOperations AlgorithmOperations { get { return _algorithmOperations; } }

        private readonly AlgorithmOperations _algorithmOperations;

        public Algorithm(AlgorithmOperations algorithmOperations)
        {
            _algorithmOperations = algorithmOperations;
        }

        public virtual byte[] ProcessSignal(byte[] data)
        {
            return _algorithmOperations.Filter(_algorithmOperations.MedianFilter(data));
        }

        public virtual byte[] Postprocessing(byte[] data)
        {
            return _algorithmOperations.Derivative(_algorithmOperations.Filter(data));
        }
    }
}
