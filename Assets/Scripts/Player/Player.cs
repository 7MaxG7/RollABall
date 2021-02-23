using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;


namespace MaxG {
    
    public sealed class Player : MonoBehaviour {
        [SerializeField] private float _moveSpeed;
        
        private Dictionary<TrapTypeEnum, Action> _trapActions;
        private GameLogic _logic;

        public float MoveSpeed { get => _moveSpeed; set => _moveSpeed = value; }
        // public bool IsInvulnerable = false;

        private void Awake() {
            _logic = FindObjectOfType<GameLogic>();
            _trapActions = new Dictionary<TrapTypeEnum, Action>() {
                {TrapTypeEnum.Dead, TakeDamage}
            };
                
            if (_moveSpeed == 0) _moveSpeed = 5;
        }

        public void InvokeTrap(TrapTypeEnum trapType) {
            if (_trapActions.ContainsKey(trapType)) {
                _trapActions[trapType].Invoke();
            } else {
                throw new Exception($"{gameObject.name}: no trap of type {trapType.ToString()} in dictionary.");
            }
        }

        private void TakeDamage() {
            // if (!IsInvulnerable) {
                Destroy(gameObject);
                _logic.GameOver();
            // }
        }

        public void TogglePlayerInvulnerability(bool isInvulnerable) {
            if (isInvulnerable) {
                _trapActions[TrapTypeEnum.Dead] = delegate {  };
            } else {
                _trapActions[TrapTypeEnum.Dead] = TakeDamage;
            }
        }
    }
}