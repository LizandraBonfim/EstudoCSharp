namespace Lizandra.Interfaces.Entities
{
    public class CalculationService
    {
        public static decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }
        
        public static decimal Double(decimal a, decimal b)
        {
            return a * b;
        }
        
        public static decimal Max(decimal a, decimal b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
    }
}