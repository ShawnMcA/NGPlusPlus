using NGPlusPlus.Abilities;
using NGPlusPlus.Core;
using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.Enums;
using NGPlusPlus.Interfaces;
using NGPlusPlus.PlayerNameSpace;
using NGPlusPlus.SceneManagerNamespace;
using System.Diagnostics;

namespace NGPlusPlus.BattleManagerNamespace
{
    internal class BattleManager
    {
        private bool BattleActive = true;
        private bool BattleWon = false;

        private Player Player;
        private ICreature Enemy;

        private List<ICreature> TurnOrder = new List<ICreature>();

        private SceneManager SceneManager;
        private IGameScreen EnemyScreen;
        private bool IsAmbushed = false;

        public BattleManager(ICreature enemy, SceneManager sceneManager, IGameScreen enemyScreen, bool isAmbushed = false) 
        {
            Player = Player.GetInstance();
            Enemy = enemy;
            SceneManager = sceneManager;
            EnemyScreen = enemyScreen;
            IsAmbushed = isAmbushed;
        }

        #region Game Loop
        public bool CoreLoop()
        {
            SceneManager.PlayFightScreen(EnemyScreen);
            SetTurnOrder();

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


            return BattleWon;
        }
        #endregion Game Loop

        #region Turn/Round Actions
        private void BeginningOfTurnActions() {}

        private void CreatureTurnActions(ICreature creature)
        {
            IAbility ability = creature.PickAbility();

            ICreature target = GetTarget(ability.TargetType, creature.CreatureType == CreatureType.Player);

            ResolveAction(target, creature, ability);
        }

        private void EndOfTurnActions()
        {
            SceneManager.PlayFightScreen(EnemyScreen);
            CheckForDeath();
        }

        private void BeginningOfRoundActions() {}
        private void EndOfRoundActions()
        {
            //ResetStats();
        }
        #endregion Turn/Round Actions


        #region General
        private void SetTurnOrder()
        {
            if(!IsAmbushed && Player.CalculateSpeed() > Enemy.CalculateSpeed())
            {
                TextLogger.ClearWriteTextAndWait($"You caught {Enemy.Name} off guard...");
                TurnOrder.Add(Player);
                TurnOrder.Add(Enemy);
            } else
            {
                TextLogger.ClearWriteTextAndWait($"You were ambushed by {Enemy.Name}!!!");
                TurnOrder.Add(Enemy);
                TurnOrder.Add(Player);
            }
        }

        private void CheckForDeath()
        {
            BattleActive = !Player.Stats.IsDead() && !Enemy.Stats.IsDead();
            BattleWon = !Player.Stats.IsDead() && Enemy.Stats.IsDead();

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
                    return isPlayer ? Player : Enemy;
                case TargetType.Other:
                case TargetType.OtherAll:
                    return isPlayer ? Enemy : Player;
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
        }

        private void HandleDamage(ICreature target, ICreature attacker, Damage ability)
        {
            if (ability.DamageType == DamageType.Physical)
            {
                var damage = attacker.CalculatePhysicalDamage(ability.RangeLow, ability.RangeHigh);

                TextLogger.ClearWriteTextAndWait($"{attacker.Name} used {ability.Name} and swings for {damage}.");
                target.TakePhysicalDamage(damage);
            }

            else if (ability.DamageType == DamageType.Magic)
            {
                var damage = attacker.CalculateMagicDamage(ability.RangeLow, ability.RangeHigh);

                TextLogger.ClearWriteTextAndWait($"{attacker.Name} used {ability.Name} and swings for {damage}.");
                target.TakeMagicDamage(damage);
            }
        }

        private void HandleHeal(ICreature target, ICreature attacker, Heal ability)
        {
            TextLogger.ClearWriteTextAndWait($"{attacker.Name} used {ability.Name}. {target.Name} is healed by {ability.Amount}.");
            target.RestoreHealth(ability.Amount);
        }

        private void HandleBuff(ICreature target, ICreature attacker, Buff ability)
        {
            TextLogger.ClearWriteTextAndWait($"{attacker.Name} used {ability.Name}. {target.Name}'s {ability.StatType} is increased by {ability.Amount}.");
            target.BuffStat(ability.StatType, ability.Amount);
        }

        private void HandleDebuff(ICreature target, ICreature attacker, Debuff ability)
        {
            TextLogger.ClearWriteTextAndWait($"{attacker.Name} used {ability.Name}. {target.Name}'s {ability.StatType} is decreased by {ability.Amount}.");
            target.BuffStat(ability.StatType, ability.Amount * -1);
        }

        private void ResetStats()
        {
            Player.ResetStats();
            Enemy.ResetStats();
        }
        #endregion Battle Actions
    }
}
