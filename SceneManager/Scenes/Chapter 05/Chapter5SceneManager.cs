using NGPlusPlus.Core;
using NGPlusPlus.Enums;
using NGPlusPlus.PlayerNameSpace;
using NGPlusPlus.ScreenRendererNamespace;
using NGPlusPlus.GameScreens.Scenes;
using NGPlusPlus.Data;
using NGPlusPlus.GameScreensNamespace;
using NGPlusPlus.SceneManager.Core;
using NGPlusPlus.Interfaces;

namespace NGPlusPlus.SceneManagerNamespace
{
    internal class Chapter5SceneManager : IStorySceneManager, IChapterSceneManager
    {
        private Player Player;
        public Chapter5SceneManager(Player player)
        {
            Player = player;
        }

        public void PlaySet()
        {
            PlayChapterScene();
            TheSages();
            PreCompetition();
            FindingTheJumprope();
            Competition();
        }

        public void PlayChapterScene()
        {
            ScreenRenderer.RenderAnimation(new Chapter5Screen());
            TextLogger.ClearWriteTextAndWait("");
        }
        private void TheSages()
        {
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);
            TextLogger.ClearWriteTextAndWait($"(Lost on all accounts, you sit outside of Adam’s study to think for a while)");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Well... Not entirely sure where to start looking.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I wish I could just go back to walking through spiderwebs at this point.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: It’s at least better than dealing with an entire world basically imploding because of me.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Why am I putting the world on a timer?");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I’m not even sure still where I am.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Maybe I'm 'The Forgetful'?");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I really feel like it.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Well... I could at least go visit Starla at the competition.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I really hope she doesn’t plan to use that snake as a jump rope.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: That sounds dangerous to all parties involved.");
        }
        private void PreCompetition()
        {
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);
            TextLogger.ClearWriteTextAndWait($"(You head to the jump rope competition)");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: {CharacterNames.NPC_GIRL}! {CharacterNames.NPC_GIRL}! Hey! {CharacterNames.NPC_GIRL}!");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Hey! Hey! HEY!");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_GIRL}: {Player.Name}!");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_GIRL}: You actually made it!");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Of course.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I needed to get my mind off of some things.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_GIRL}: Did you find my dad? I could really use that jump rope.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_GIRL}: {CharacterNames.NPC_GIRL_PET_FN} also agrees...");
            TextLogger.ClearWriteTextAndWait($"({CharacterNames.NPC_GIRL_PET_FN} gives you a look of fear.)");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Let me see what I can do.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_GIRL}: Please hurry... I can't stand the thought of losing.");
            TextLogger.ClearWriteTextAndWait($"(You scurry off in hopes of finding a replacement jump rope)");
        }

        private void FindingTheJumprope()
        {
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Hmm… I’m not entirely sure how I’m going to get this jump rope.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: My pockets already determined I don’t have any coins on me.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I do give some crisp high-fives, but not sure if I could use that as currency.");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I have an idea though...");
            TextLogger.ClearWriteTextAndWait($"(You quickly make your way back to where {CharacterNames.NPC_GIRL} first found you sleeping.)");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Nice! It’s still here...");
            TextLogger.ClearWriteTextAndWait($"(You reach down to grab that snake you took out from earlier.)");

            BattleSceneManager.StartBattle(EnemyType.Snake, $"Not a dead Snake", 1, true);
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);

            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Well... Apparently that wasn’t the same snake, but this will work.");
            TextLogger.ClearWriteTextAndWait($"(You quickly rush back to the competition with your new jump rope)");
        }

        private void Competition()
        {
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I fou...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I found you a ju...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: Ugh...");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: I should probably do more cardio.");
            TextLogger.ClearWriteTextAndWait($"(You pause to catch your breath)");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: {CharacterNames.NPC_GIRL}, I found your jump rope.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_GIRL}: FINALLY... Jeeez.");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_GIRL}: Good timing though, the competition is about to start.");
            TextLogger.ClearWriteTextAndWait($"(Bill Boa looks at you with a sigh of relief.)");
            TextLogger.ClearWriteTextAndWait($"(You watch as 20+ competitors line up with various types of jump ropes)");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_JUDGE}: Alright... To remind you all of what you are competing for, the winner of this year’s 12th annual Jump Rope-Athon");
            TextLogger.WriteTextAndWait($"will receive $10k, a large trophy, and a lifetime supply of free socks.");
            TextLogger.ClearWriteTextAndWait($"(You look at {CharacterNames.NPC_GIRL} confused, but she just shrugs, equally confused.)");
            TextLogger.ClearWriteTextAndWait($"{CharacterNames.NPC_GIRL}: Come on! Start the competition already!");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_JUDGE}: Hold your horses. As you know, this is a competition to see who can remain jumping rope the longest.");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_JUDGE}: If you stop jumping for any reason you are immediately disqualified.");
            TextLogger.ClearWriteTextAndWait($"({CharacterNames.NPC_GIRL} starts jumping before the rest of the crowd)");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_JUDGE}: Uhhh... I guess go?");
            TextLogger.ClearWriteText($"(The judge shoots a flare gun and the competition is underway)");
            TextLogger.ClearWriteText($"(One by one competitors start dropping out as the competition goes on.)");
            TextLogger.ClearWriteText($"(20... 19.. 17... 14... 9... 6... 4...)");
            TextLogger.ClearWriteText($"(All that remains after 15 minutes go by are two competitors.)");
            TextLogger.ClearWriteText($"({CharacterNames.NPC_GIRL} and a shady looking lady.)");
            TextLogger.ClearWriteText($"(You look in the crowd and see a suspicious group of ladies looking up to no good.)");
            TextLogger.ClearWriteText($"(So, you investigate.)");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_CONTEST_LADY_1}: This little girl is going to jump forever...");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_CONTEST_LADY_2}: I think we need step in otherwise she’ll take the prize.");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_CONTEST_LADY_3}: I have an idea... Release {CharacterNames.NPC_CONTEST_BIRD_BOSS}...");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_CONTEST_LADY_1}: Should we do that? That’s risky...");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_CONTEST_LADY_3}: We have to... {CharacterNames.NPC_CONTESTANT} will lose otherwise...");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_CONTEST_LADY_2}: I agree, we have to.");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_CONTEST_LADY_1}: Alright let’s do it...");
            TextLogger.ClearWriteText($"(Uh oh… That doesn’t sound good.)");
            TextLogger.ClearWriteText($"(The ladies proceed to open a large cage containing an equally large bird that flies out.)");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_CONTEST_BIRD_BOSS}: SQUAAAAAAAAAKKKKKKKKK");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_CONTEST_BIRD_BOSS}: EEEEEEEEEEEEECKKKKKKKKK");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_CONTEST_BIRD_BOSS}: SQUAAAAAAAAAKKKKKKKKK");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_GIRL}: {Player.Name}!! Do something about that bird!! It’s distracting!!");
            TextLogger.ClearWriteText($"(You rush to confront the ladies and the bird)");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_CONTEST_LADY_1}: Don’t you lay a finger on our {CharacterNames.NPC_CONTEST_BIRD_BOSS}!!");
            TextLogger.ClearWriteText($"(The large bird flies down to your level looking for a fight making horrible screeching noises along the way)");

            BattleSceneManager.StartBattle(EnemyType.Snake, $"{CharacterNames.NPC_CONTEST_BIRD_BOSS}", 1, true);
            CoreSceneManager.PlayMiscScene(MiscScenes.Blank);


            TextLogger.ClearWriteText($"(The sound of the fight caused {CharacterNames.NPC_CONTESTANT} to lose concentration and stop jumping)");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_JUDGE}: (BZZZZZZZTTT) We have a winner!!!");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_JUDGE}: Congratulations goes out to Ms. {CharacterNames.NPC_GIRL} for winning the 12th Annual Jump Rope-athon.");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_GIRL}: WE DID IT!!!");
            TextLogger.ClearWriteTextAndWait($"{Player.Name}: You did it! Congrats...");
            TextLogger.ClearWriteText($"{CharacterNames.NPC_GIRL}: I couldn’t have done it without your help with that loud bird...");
            TextLogger.ClearWriteText($"(You watch as the group of people all rush to congratulate Starla.)");
            TextLogger.ClearWriteText($"(You couldn’t be prouder...)");
        }
    }
}
