using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;


namespace MaxG {

    /// <summary>
    ///  Class for main game rules
    /// </summary>
    public sealed class GameLogic : MonoBehaviour {
        private int _keysAmount = 0;

        public void CountAddedKey() {
            ++_keysAmount;
        }

        public void CountCollectedKey() {
            if (--_keysAmount == 0) {
                // Открыть дверь лабиринта
            }
        }

        public void GameOver() {
            Log("You loose");
        }
    }
}