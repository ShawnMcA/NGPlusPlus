using NGPlusPlus.PlayerNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGPlusPlus.Core {
    internal sealed class StateManager {
        private StateManager() { }
        private static StateManager Instance;

        public static StateManager GetInstance() { 
            if(Instance == null)
            {
                Instance = new StateManager();
            }

            return Instance;
        }
    }
}
