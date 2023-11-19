using RPGGame.Data;
using RPGGame.Enums;
using RPGGame.Interfaces;

namespace RPGGame.PlayerNameSpace
{
    public static class TemplateManager
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
