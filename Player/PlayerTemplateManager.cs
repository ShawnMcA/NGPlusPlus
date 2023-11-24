using NGPlusPlus.Data;
using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.PlayerNameSpace
{
    public static class PlayerTemplateManager
    {
        public static IPlayerTemplate GetPlayerTemplate(PlayerClass playerClass, int level) 
        {
            return playerClass switch {
                PlayerClass.Knight => new KnightTemplate(level),
                PlayerClass.Archer => new ArcherTemplate(level),
                PlayerClass.Wizard => new WizardTemplate(level),
                _ => new KnightTemplate(level)
            };
        }
    }
}
