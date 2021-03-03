using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;


namespace MaxG {

    /// <summary>
    ///  Class for main game rules
    /// </summary>
    public sealed class GameLogic : MonoBehaviour {
        [SerializeField] private Canvas _canvas;
        private int _keysAmount = 0;
        private StringsKiller _strKiller;
        private GameObject _winScreen; 

        // [SerializeField] private StuffTakenEvent _eventController;
        // public StuffTakenEvent StuffTakenEvent { get => _eventController; }
        
        private void Awake() {
            _strKiller = new StringsKiller();
            _winScreen = Resources.Load<GameObject>(_strKiller.path.prefsFolder + _strKiller.path.winScreenName);
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
            Instantiate(_winScreen, _canvas.transform);
        }
    }
}