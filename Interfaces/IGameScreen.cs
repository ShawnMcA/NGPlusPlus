using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.Interfaces
{
    public interface IGameScreen
    {
        int AnimationSpeed { get; }
        List<string> Screen1();
        List<List<string>> AnimationPackage();
    }
}
