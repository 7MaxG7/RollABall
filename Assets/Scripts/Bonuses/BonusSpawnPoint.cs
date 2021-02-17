using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;


namespace MaxG {

    public sealed class BonusSpawnPoint : MonoBehaviour {
        [SerializeField] private GameObject _keyBonusPref;
        [SerializeField] private GameObject _speedBonusPref;
        [SerializeField] private GameObject _invulnerabilityBonusPref;

        void Start() {
            Init();
        }

        private void Init() {
            GameObject currentBonusPref = default;
            BonusType currentBonusType = (BonusType)Range(0, (int)BonusType.Count - 1);
            switch (currentBonusType) {
                case BonusType.Key:
                    currentBonusPref = _keyBonusPref;
                    break;
                case BonusType.Speed:
                    currentBonusPref = _speedBonusPref;
                    break;
                case BonusType.Invul:
                    currentBonusPref = _invulnerabilityBonusPref;
                    break;
                case BonusType.Count:
                    break;
                default:
                    break;
            }
            Instantiate(currentBonusPref, transform);
        }
    }

    public enum BonusType {
        Key = 0,
        Speed = 1,
        Invul = 2,
        Count,
    }
}