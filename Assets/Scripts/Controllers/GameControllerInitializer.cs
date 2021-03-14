using UnityEngine;

namespace MaxG {
    
    public sealed class GameControllerInitializer {
        
        public GameControllerInitializer(GameController gameController, ConfigsManager configsManager) {
            var uiController = new UIController(configsManager.UIConfig);
            gameController.Add(uiController);
            
            var gameLogic = new GameLogic(configsManager.LogicConfig, uiController.MainCanvas);
            
            gameController.Add(new MapController(configsManager.MapConfig));
            
            gameController.Add(new PlayerController(configsManager.SpawnsConfig, gameLogic));
            
            var pickupsController = new PickupsController(configsManager.SpawnsConfig, gameLogic);
            gameController.Add(pickupsController);
        }

    }
}