using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    public sealed class SpeedIncreaseEffect : EffectParent {
        private float _speedMultiplier = 2;
        private float _speedIncrease;

        private void Start() {
            _speedIncrease = _player.MoveSpeed * (_speedMultiplier - 1);
            _player.MoveSpeed += _speedIncrease;
            Destroy(this, 3);
        }

        protected override void OnDestroy() {
            _player.MoveSpeed -= _speedIncrease;
        }
    }
}