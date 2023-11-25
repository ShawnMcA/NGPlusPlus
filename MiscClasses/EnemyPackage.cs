using NGPlusPlus.EnemyNamespace;
using NGPlusPlus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGPlusPlus.MiscClasses
{
    public class EnemyPackage
    {
        public Enemy Enemy { get; set; }
        public IGameScreen EnemyScreen { get; set; }
    }
}
