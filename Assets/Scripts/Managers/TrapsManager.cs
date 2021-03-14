using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace MaxG {
    
    public class TrapsManager {
        
        private readonly Dictionary<TrapTypeEnum, GoEvent> _trapsEffects;

        public TrapsManager() {
            _trapsEffects = new Dictionary<TrapTypeEnum, GoEvent>() {
                [TrapTypeEnum.Dead] = DeadEffect,
                [TrapTypeEnum.Speed] = SpeedDecreaseEffect,
            };
            
            CheckAllTrapsEffects();
        }

        private void CheckAllTrapsEffects() {
            List<TrapTypeEnum> missedTypes = new List<TrapTypeEnum>();
            foreach (TrapTypeEnum trapType in Enum.GetValues(typeof(TrapTypeEnum))) {
                if (trapType != TrapTypeEnum.Count && !_trapsEffects.ContainsKey(trapType)) {
                    missedTypes.Add(trapType);
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

                throw new Exception($"{this}: traps dictionary doesn't contain {missedTypesStr} effect");
            }
        }

        public GoEvent GetTrapEffect(TrapTypeEnum trapType) {
            if (!_trapsEffects.ContainsKey(trapType)) {
                throw new Exception($"{this}: traps dictionary doesn't contain {trapType.ToString()} effect");
            }

            return _trapsEffects[trapType];
        }

        private void DeadEffect(GameObject gObj) {
            MonoBehaviour.Destroy(gObj);
        }

        private void SpeedDecreaseEffect(GameObject gObj) {
            gObj.AddComponent<SpeedDecreaseEffect>();
        }
    }
}