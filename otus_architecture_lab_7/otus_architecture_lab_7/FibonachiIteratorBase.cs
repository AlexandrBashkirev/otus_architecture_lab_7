using System;


namespace otus_architecture_lab_7
{
    public class FibonachiIteratorBase : IIterable<int>
    {
        #region Variables

        private int currentN = 0;
        private int endN = 0;
        private int step = 1;

        private Fibonachi fibonachi = new Fibonachi();

        #endregion



        #region Class lifecycle

        public FibonachiIteratorBase(int startN, int endN,  int step)
        {
            currentN = startN;
            this.endN = endN;
            this.step = step;

            if( (currentN > endN && step > 0) ||
                (currentN < endN && step < 0))
            {
                throw new Exception("Wrong interval");
            }
        }

        #endregion



        #region Methods

        public bool HasNext()
        {
            return (currentN <= endN && step > 0) ||
                (currentN >= endN && step < 0);
        }


        public int Next()
        {
            int result = fibonachi.Compute(currentN);
            currentN += step;

            return result;
        }

        #endregion
    }
}
