using System;
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
            if (_deadTrapPref == null || _speedTrapPref == null) {
                throw new Exception($"{gameObject.name}: no link to trap prefab.");
            }
            GameObject currentTrapPref = default;
            TrapTypeEnum currentTrapType = (TrapTypeEnum)Range(0, (int)TrapTypeEnum.Count);
            switch (currentTrapType) {
                case TrapTypeEnum.Dead:
                    currentTrapPref = _deadTrapPref;
                    break;
                case TrapTypeEnum.Speed:
                    currentTrapPref = _speedTrapPref;
                    break;
                case TrapTypeEnum.Count:
                    break;
                default:
                    break;
            }
            Instantiate(currentTrapPref, transform);
        }
    }
}