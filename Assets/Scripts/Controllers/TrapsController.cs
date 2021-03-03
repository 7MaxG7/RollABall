using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

namespace MaxG {
    
    public class TrapsController : IInitializer {
        private StringsKiller _strKiller;

        public TrapsController() {
            _strKiller = new StringsKiller();
        }

        public void Init() {
            GameObject[] trapsGo = GameObject.FindGameObjectsWithTag(_strKiller.tag.trapSpawnPoint);
            foreach (var trapGo in trapsGo) {
                Traps trap = trapGo.AddComponent<Traps>();
                trap.trapType = (TrapTypeEnum)Range(0, (int)TrapTypeEnum.Count);
                
                switch (trap.trapType) {
                    case TrapTypeEnum.Dead:
                        trap.stuffTakenEvent.AddListener(AddDeadEffect);
                        break;
                    case TrapTypeEnum.Speed:
                        trap.stuffTakenEvent.AddListener(obj => obj.AddComponent<SpeedDecreaseEffect>());
                        break;
                    case TrapTypeEnum.Count:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
                trap.stuffTakenEvent.AddListener(Camera.main.GetComponent<CameraController>().ShakeCam);
            }
        }

        private void AddDeadEffect(GameObject gObj) {
            gObj.AddComponent<DeadEffect>();
        }
    }
}