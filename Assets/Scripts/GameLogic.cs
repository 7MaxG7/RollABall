using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;


namespace MaxG {

    /// <summary>
    ///  Class for main game rules
    /// </summary>
    public sealed class GameLogic {

        private Transform _canvas;
        private int _keysAmount = 0;
        private LogicConfig _logicConfig;
        
        public GameLogic(LogicConfig logicConfig, Transform canvas) {
            if (!logicConfig || !canvas)
                throw new Exception($"{this}: logic config or canvas link is null");
            
            _logicConfig = logicConfig;
            _canvas = canvas;
        }
        
        public void CountAddedKey() {
            ++_keysAmount;
        }

        public void CountCollectedKey() {
            if (--_keysAmount == 0) {
                WinGame();
            }
        }

        public void GameOver() {
            Log("You loose");
        }

        private void WinGame() {
            GameObject.Instantiate(_logicConfig.WinScreenPref, _canvas);
        }
    }
}