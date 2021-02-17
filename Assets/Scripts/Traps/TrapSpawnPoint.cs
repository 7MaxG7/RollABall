using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;


namespace MaxG {

    public class TrapSpawnPoint : MonoBehaviour {
        [SerializeField] private GameObject _deadTrapPref;
        [SerializeField] private GameObject _speedTrapPref;

        void Start() {
            Init();
        }

        private void Init() {
            GameObject currentTrapPref = default;
            TrapType currentTrapType = (TrapType)Range(0, (int)TrapType.Count - 1);
            switch (currentTrapType) {
                case TrapType.Dead:
                    currentTrapPref = _deadTrapPref;
                    break;
                case TrapType.Speed:
                    currentTrapPref = _speedTrapPref;
                    break;
                case TrapType.Count:
                    break;
                default:
                    break;
            }
            Instantiate(currentTrapPref, transform);
        }
    }

    public enum TrapType {
        Dead = 0,
        Speed = 1,
        Count,
    }
}