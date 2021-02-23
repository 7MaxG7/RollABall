using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    public sealed class SpeedIncreaseEffect : Effect {
        private float _speedMultiplier = 2;
        private float _speedIncrease;

        protected override void Awake() {
            base.Awake();
        }
        private void Start() {
            _speedIncrease = _player.MoveSpeed * (_speedMultiplier - 1);
            _player.MoveSpeed += _speedIncrease;
            Destroy(this, _effectDuration);
        }

        protected override void OnDestroy() {
            _player.MoveSpeed -= _speedIncrease;
        }
    }
}