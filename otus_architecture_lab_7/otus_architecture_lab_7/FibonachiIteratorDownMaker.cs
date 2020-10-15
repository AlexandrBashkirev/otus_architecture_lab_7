
namespace otus_architecture_lab_7
{
    class FibonachiIteratorDownMaker : IFibonachiIteratorMaker
    {
        public IIterable<int> Make(int strat, int end)
        {
            return new FibonachiIteratorDown(strat, end);
        }
    }
}
