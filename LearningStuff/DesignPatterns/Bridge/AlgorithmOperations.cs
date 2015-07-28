namespace Bridge
{
    public abstract class AlgorithmOperations
    {
        public abstract byte[] Filter(byte[] data);
        public abstract byte[] MedianFilter(byte[] data);
        public abstract byte[] Derivative(byte[] data);
    }
}
