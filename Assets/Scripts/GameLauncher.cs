using System;
using MaxG;
using UnityEngine;

namespace MaxG {
    
    public sealed class GameLauncher : MonoBehaviour {
        public ConfigsManager ConfigsManager {
            get {
                if (!_configsManager)
                    _configsManager = Resources.Load<ConfigsManager>(_configsManagerPath);
                if (!_configsManager)
                    throw new Exception($"{this}: configs pather hasn't been loaded");
                return _configsManager;
            }
        }
        
        [SerializeField] private string _configsManagerPath;
        private ConfigsManager _configsManager;
        private GameController _gameController;

        private void Awake() {
            _gameController = new GameController();
            new GameControllerInitializer(_gameController, ConfigsManager);
            _gameController.Init();
        }
        
        private void Update() {
            _gameController.DoUpdate(Time.deltaTime);
        }

        private void OnDestroy() {
            _gameController.CleanUp();
        }
    }
}