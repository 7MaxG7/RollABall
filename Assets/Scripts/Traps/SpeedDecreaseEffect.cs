using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    public sealed class SpeedDecreaseEffect : Effect {
        private float _speedMultiplier = 2;
        private float _speedDecrease;

        void Start() {
            _speedDecrease = _player.MoveSpeed * (1 - 1 / _speedMultiplier);
            _player.MoveSpeed -= _speedDecrease;
            Destroy(this, _effectDuration);
        }

        protected override void OnDestroy() {
            _player.MoveSpeed += _speedDecrease;
        }
    }
}