using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;


namespace MaxG {

    /// <summary>
    ///  Class for main game rules
    /// </summary>
    public sealed class GameLogic : MonoBehaviour
    {
        [SerializeField] private StuffTakenEvent _eventController;
        private int _keysAmount = 0;
        
        public StuffTakenEvent StuffTakenEvent { get => _eventController; }

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