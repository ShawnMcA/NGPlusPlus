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

        public static int CalculateDamageOutput(int baseDamage, int accuracy, int attack)
        {
            Random rnd = new Random();
            var hitRoll = rnd.Next(0, 101);

            var damage = (int)Math.Ceiling(baseDamage * (attack / 100m));

            return hitRoll <= accuracy ? damage : 0; // TODO: Apply the secret sauce.
        }

        public static int CalculateDamageInput(int damage, int defense)
        {
            if (damage <= 0)
                return 0;

            var total = (int)Math.Floor(damage * ((100 - defense) / 100m));// TODO: Apply the secret sauce.

            return total > 0 ? total : 0;
        }
    }
}
