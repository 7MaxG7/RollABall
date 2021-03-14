using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.Random;

namespace MaxG {
    
    public class PickupsController : IInitializer {
        
        public List<Traps> Traps { get; } 
        public List<Bonuses> Bonuses { get; }
        
        private readonly TrapsManager _trapsManager;
        private readonly BonusesManager _bonusesManager;
        private readonly SpawnsConfig _spawnsConfig;
        private readonly GameLogic _gameLogic;
        private GameObject _trapPref;
        private GameObject _bonusPref;

        public PickupsController(SpawnsConfig spawnsConfig, GameLogic gameLogic) {
            Traps = new List<Traps>();
            Bonuses = new List<Bonuses>();
            _spawnsConfig = spawnsConfig;
            _gameLogic = gameLogic;
            _trapsManager = new TrapsManager();
            _bonusesManager = new BonusesManager(gameLogic);
        }
        
        
        public void Init() {
            InstantiatePickupObjs(_spawnsConfig.BonusPref, _spawnsConfig.BonusSpawnPointTag, Bonuses, _spawnsConfig.BonusInstatiationRotation);
            InstantiatePickupObjs(_spawnsConfig.TrapPref, _spawnsConfig.TrapSpawnPointTag, Traps, _spawnsConfig.TrapInstatiationRotation);

            foreach (var trap in Traps) {
                trap.trapType = (TrapTypeEnum)Range(0, (int)TrapTypeEnum.Count);
                trap.stuffTakenEvent.AddListener(_trapsManager.GetTrapEffect(trap.trapType));
                trap.stuffTakenEvent.AddListener(Camera.main.GetComponent<CameraController>().ShakeCam);
            }

            foreach (var bonus in Bonuses) {
                bonus.bonusType = (BonusTypeEnum)Range(0, (int)BonusTypeEnum.Count);
                if (bonus.bonusType == BonusTypeEnum.Key) 
                    _gameLogic.CountAddedKey();
                bonus.stuffTakenEvent.AddListener(_bonusesManager.GetBonusEffect(bonus.bonusType));
            }
        }

        private void InstantiatePickupObjs<T>(GameObject pickupPref, string spawPointTag, List<T> pickups
                , Vector3 instantiationRotation = default) where T : PickupStuff {
            GameObject[] spawns = GameObject.FindGameObjectsWithTag(spawPointTag);
            foreach (var spawn in spawns) {
                var pickupObj = GameObject.Instantiate(
                    pickupPref,
                    spawn.transform.position,
                    Quaternion.Euler(instantiationRotation.x, instantiationRotation.y, instantiationRotation.z),
                    spawn.transform.parent
                );
                var pickup = pickupObj.GetComponent<T>();
                pickups.Add(pickup);
            }
        }
    }
}