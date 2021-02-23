using System;
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
            if (_keyBonusPref == null || _speedBonusPref == null || _invulnerabilityBonusPref == null) {
                throw new Exception($"{gameObject.name}: no link to bonus prefab.");
            }
            GameObject currentBonusPref = default;
            BonusTypeEnum currentBonusType = (BonusTypeEnum)Range(0, (int)BonusTypeEnum.Count);
            switch (currentBonusType) {
                case BonusTypeEnum.Key:
                    currentBonusPref = _keyBonusPref;
                    break;
                case BonusTypeEnum.Speed:
                    currentBonusPref = _speedBonusPref;
                    break;
                case BonusTypeEnum.Invul:
                    currentBonusPref = _invulnerabilityBonusPref;
                    break;
                case BonusTypeEnum.Count:
                    break;
                default:
                    break;
            }
            Instantiate(currentBonusPref, transform);
        }
    }
}