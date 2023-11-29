using NGPlusPlus.Abilities;
using NGPlusPlus.Core;
using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;
using NGPlusPlus.MiscClasses;
using NGPlusPlus.PlayerNameSpace;
using NGPlusPlus.SceneManager.Core;

namespace NGPlusPlus.BattleManagerNamespace
{
    internal class BattleManager
    {
        private bool BattleActive = true;
        private bool BattleWon = false;

        private Player Player;
        private EnemyPackage EnemyPackage;

        private List<ICreature> TurnOrder = new List<ICreature>();

        private bool IsAmbushed = false;

        public BattleManager(EnemyPackage enemyPackage, bool isAmbushed = false) 
        {
            Player = Player.GetInstance();
            EnemyPackage = enemyPackage;
            IsAmbushed = isAmbushed;
        }

        #region Game Loop
        public bool StartCoreLoop()
        {
            do
            {
                BeginningOfRoundActions();

                foreach (var c in TurnOrder)
                {
                    BeginningOfTurnActions();
                    CreatureTurnActions(c);
                    EndOfTurnActions();

                    if (!BattleActive)
                        break;
                }

                if (!BattleActive)
                    break;

                EndOfRoundActions();

            } while (BattleActive);

            Player.Stats.ResetAll();

            return BattleWon;
        }
        #endregion Game Loop

        #region Turn/Round Actions
        private void BeginningOfTurnActions() {}

        private void CreatureTurnActions(ICreature creature)
        {
            IAbility ability = creature.PickAbility();

            ICreature target = GetTarget(ability.TargetType, creature.CreatureType == CreatureType.Player);

            HandlePayMana(creature, ability);

            ResolveAction(target, creature, ability);
        }

        private void EndOfTurnActions()
        {
            CheckForDeath();
        }

        private void BeginningOfRoundActions() 
        {
            SetTurnOrder();
        }

        private void EndOfRoundActions()
        {
            HandleStatRestore();
        }
        #endregion Turn/Round Actions


        #region General
        private void SetTurnOrder()
        {
            TurnOrder = new List<ICreature>();

            if(IsAmbushed)
            {
                IsAmbushed = false;

                TextLogger.ClearWriteTextAndWait($"You were ambushed by {EnemyPackage.Enemy.Name}!!!");
                TurnOrder.Add(EnemyPackage.Enemy);

                return;
            }

            if(!IsAmbushed && Player.CalculateBattleSpeed() > EnemyPackage.Enemy.CalculateBattleSpeed())
            {
                TurnOrder.Add(Player);
                TurnOrder.Add(EnemyPackage.Enemy);
            } 
            
            else
            {
                TurnOrder.Add(EnemyPackage.Enemy);
                TurnOrder.Add(Player);
            }
        }

        private void CheckForDeath()
        {
            BattleActive = !Player.Stats.IsDead() && !EnemyPackage.Enemy.Stats.IsDead();
            BattleWon = !Player.Stats.IsDead() && EnemyPackage.Enemy.Stats.IsDead();

            return;
        }
        #endregion General

        #region Battle Actions
        private ICreature GetTarget(TargetType targetType, bool isPlayer)
        {
            switch (targetType)
            {
                case TargetType.Self:
                case TargetType.SelfAll:
                    return isPlayer ? Player : EnemyPackage.Enemy;
                case TargetType.Other:
                case TargetType.OtherAll:
                    return isPlayer ? EnemyPackage.Enemy : Player;
            }

            return null;
        }

        private void ResolveAction(ICreature target, ICreature attacker, IAbility ability)
        {
            switch (ability.AbilityType)
            {
                case AbilityType.Damage:
                    HandleDamage(target, attacker, (Damage)ability);
                    break;
                case AbilityType.Heal:
                    HandleHeal(target, attacker, (Heal)ability);
                    break;
                case AbilityType.Buff:
                    HandleBuff(target, attacker, (Buff)ability);
                    break;
                case AbilityType.Debuff:
                    HandleDebuff(target, attacker, (Debuff)ability);
                    break;
            }

            HandleRerender(target);
        }

        private void HandleStatRestore() 
        {
            EnemyPackage.Enemy.Stats.IncrementalStatRestore();
            Player.Stats.IncrementalStatRestore();
        }

        private void HandleDamage(ICreature target, ICreature attacker, Damage ability)
        {
            var damage = attacker.CalculateDamageOutput(ability.BaseDamage, ability.Accuracy, ability.DamageType);

            if(damage > 0)
            {
                TextLogger.ClearWriteTextAndWait($"{attacker.Name} used {ability.Name} and swings for {damage}.");
                target.TakeDamage(damage, ability.DamageType);
            }
                
            else
            {
                TextLogger.ClearWriteTextAndWait($"{attacker.Name} used {ability.Name}... But the attack missed...");
            }
        }

        private void HandleHeal(ICreature target, ICreature attacker, Heal ability)
        {
            TextLogger.ClearWriteTextAndWait($"{attacker.Name} used {ability.Name}. {target.Name} is healed by {ability.Amount}.");
            target.Stats.RestoreHealth(ability.Amount);
        }

        private void HandleBuff(ICreature target, ICreature attacker, Buff ability)
        {
            TextLogger.ClearWriteTextAndWait($"{attacker.Name} used {ability.Name}. {target.Name}'s {ability.StatType} is increased by {ability.Amount}.");
            target.Stats.BuffStat(ability.StatType, ability.Amount);
        }

        private void HandleDebuff(ICreature target, ICreature attacker, Debuff ability)
        {
            TextLogger.ClearWriteTextAndWait($"{attacker.Name} used {ability.Name}. {target.Name}'s {ability.StatType} is decreased by {ability.Amount}.");
            target.Stats.BuffStat(ability.StatType, ability.Amount * -1);
        }

        private void HandlePayMana(ICreature creature, IAbility ability) 
        {
            creature.SpendMana(ability.ManaCost);
        }

        private void HandleRerender(ICreature target)
        {
            BattleSceneManager.RerenderStats();

            if (target.CreatureType == CreatureType.Enemy)
            {
                BattleSceneManager.RerenderEnemy(EnemyPackage);
            }
        }

        private void ResetStats()
        {
            Player.Stats.ResetAll();
            EnemyPackage.Enemy.Stats.ResetAll();
        }
        #endregion Battle Actions
    }
}
