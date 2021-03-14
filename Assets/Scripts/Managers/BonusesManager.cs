using System;
using System.Collections.Generic;
using UnityEngine;

namespace MaxG {
    
    public class BonusesManager {
        
        private GameLogic _gameLogic;
        private readonly Dictionary<BonusTypeEnum, GoEvent> _bonusesEffects;

        public BonusesManager(GameLogic gameLogic) {
            _gameLogic = gameLogic;
            _bonusesEffects = new Dictionary<BonusTypeEnum, GoEvent>() {
                [BonusTypeEnum.Invul] = InvulEffect,
                [BonusTypeEnum.Key] = GetKeyEffect,
                [BonusTypeEnum.Speed] = IncreaseSpeedEffect,
            };
            
            CheckAllBonusesEffects();
        }

        private void CheckAllBonusesEffects() {
            List<BonusTypeEnum> missedTypes = new List<BonusTypeEnum>();
            foreach (BonusTypeEnum bonusType in Enum.GetValues(typeof(BonusTypeEnum))) {
                if (bonusType != BonusTypeEnum.Count && !_bonusesEffects.ContainsKey(bonusType)) {
                    missedTypes.Add(bonusType);
                }
            }

            if (missedTypes.Count > 0) {
                string missedTypesStr = String.Empty;
                for (int i = 0; i < missedTypes.Count; i++) {
                    if (i != 0) {
                        missedTypesStr += ", ";
                    }

                    missedTypesStr += missedTypes[i].ToString();
                }

                throw new Exception($"{this}: bonuses dictionary doesn't contain {missedTypesStr} effect");
            }
        }

        public GoEvent GetBonusEffect(BonusTypeEnum bonusType) {
            if (!_bonusesEffects.ContainsKey(bonusType)) {
                throw new Exception($"{this}: bonuses dictionary doesn't contain {bonusType.ToString()} effect");
            }

            return _bonusesEffects[bonusType];
        }

        private void InvulEffect(GameObject obj) {
            obj.AddComponent<InvulnerabilityEffect>();
        }

        private void GetKeyEffect(GameObject obj) {
            _gameLogic.CountCollectedKey();
        }

        private void IncreaseSpeedEffect(GameObject obj) {
            obj.AddComponent<SpeedIncreaseEffect>();
        }
    }
}