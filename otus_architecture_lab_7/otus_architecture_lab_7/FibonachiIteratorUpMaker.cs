
namespace otus_architecture_lab_7
{
    class FibonachiIteratorUpMaker : IFibonachiIteratorMaker
    {
        public IIterable<int> Make(int strat, int end)
        {
            return new FibonachiIteratorUp(strat, end);
        }
    }
}
