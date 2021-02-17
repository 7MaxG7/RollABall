using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MaxG {

    public sealed class DeadEffect : EffectParent {
        private void Start() {
            Destroy(this);
        }

        protected override void OnDestroy() {
            _player.TakeDamage();
        }
    }
}