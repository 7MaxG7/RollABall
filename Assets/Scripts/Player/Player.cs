using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;


namespace MaxG {

    public sealed class Player : MonoBehaviour {
        [SerializeField] private float _moveSpeed;

        GameLogic _logic;

        public float MoveSpeed { get => _moveSpeed; set => _moveSpeed = value; }
        public bool IsInvulnerable = false;

        void Awake() {
            _logic = FindObjectOfType<GameLogic>();
            if (_moveSpeed == 0) _moveSpeed = 5;
        }

        public void TakeDamage() {
            if (!IsInvulnerable) {
                _logic.GameOver();
                Destroy(gameObject);
            }
        }
    }
}