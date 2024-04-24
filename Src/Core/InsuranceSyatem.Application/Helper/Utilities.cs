namespace InsuranceSystem.Application.Helper
{
    public class Utilities
    {
        public static decimal GetTotalAmout(IEnumerable<decimal> amoubnt)
        {
            return amoubnt.Sum();
        }
    }
}
