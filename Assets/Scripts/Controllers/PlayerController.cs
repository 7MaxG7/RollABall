using UnityEngine;

namespace MaxG {
    
    public class PlayerController : IInitializer {

        private SpawnsConfig _spawnsConfig;
        private GameLogic _gameLogic;

        public PlayerController(SpawnsConfig spawnsConfig, GameLogic gameLogic) {
            _spawnsConfig = spawnsConfig;
            _gameLogic = gameLogic;
        }
        
        public void Init() {
            GameObject[] spawns = GameObject.FindGameObjectsWithTag(_spawnsConfig.BallSpawnPointTag);
            foreach (var spawn in spawns) {
                var ball = GameObject.Instantiate(_spawnsConfig.BallPref, spawn.transform.position, Quaternion.identity);
                ball.GetComponent<Player>().gameLogic = _gameLogic;
            }
        }
    }
}