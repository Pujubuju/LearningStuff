namespace Prototype
{
    public abstract class NeuralNetwork
    {
        protected NeuralNetwork()
        {
            ExpensiveAndTimeConsumingCreation();
        }

        private void ExpensiveAndTimeConsumingCreation()
        {         
        }

        public abstract NeuralNetwork DeepClone();
    }
}
