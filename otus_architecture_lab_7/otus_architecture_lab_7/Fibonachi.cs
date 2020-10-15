using System;


namespace otus_architecture_lab_7
{
    public class Fibonachi
    {
        private const float psi = 1.618f;

        public int Compute(int n)
        {
            var result = (Math.Pow(psi, n) - Math.Pow(-psi, -n)) / (2 * psi - 1);
            return (int)(result + 0.5f);
        }
    }
}
