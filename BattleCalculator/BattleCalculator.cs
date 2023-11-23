namespace NGPlusPlus.BattleCalculatorNamespace
{
    public static class BattleCalculator
    {
        public static int CalculateSpeed(int currentSpeed) 
        {
            //Random rnd = new Random();
            //return rnd.Next(currentSpeed * 1, currentSpeed * 2); // TODO: Apply the secret sauce.

            return currentSpeed;
        }

        public static int CalculateDamageOutput(int rangeLow, int rangeHigh, int attack)
        {
            Random rnd = new Random();
            return rnd.Next(rangeLow, rangeHigh + 1) + attack; // TODO: Apply the secret sauce.
        }

        public static int CalculateDamageInput(int damage, int defense)
        {
            var total = damage - defense; // TODO: Apply the secret sauce.

            return total > 0 ? total : 1;
        }
    }
}
