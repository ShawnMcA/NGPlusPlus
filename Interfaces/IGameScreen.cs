using NGPlusPlus.EnemyNamespace;

namespace NGPlusPlus.Interfaces
{
    public interface IGameScreen
    {
        int AnimationSpeed { get; }
        List<string> Screen1();
        List<List<string>> AnimationPackage();
    }

    public interface IEnemyScreen : IGameScreen
    {
        Enemy enemy { get; }
    }
}
