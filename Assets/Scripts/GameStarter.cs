using System;
using MaxG;
using UnityEngine;

namespace MaxG {
    
    public sealed class GameStarter : MonoBehaviour {
        private GameController _gameController;

        private void Awake() {
            _gameController = new GameController();
            new GameInitializer(_gameController);
            _gameController.Init();
        }
        
        private void Update() {
            _gameController.DoUpdate();
        }

        private void OnDestroy() {
            _gameController.CleanUp();
        }
    }
}