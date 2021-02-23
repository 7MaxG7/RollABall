using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MaxG {

    public sealed class DeadEffect : Effect {

        protected override void Awake() { 
            base.Awake();
        }
        private void Start() {
            Destroy(this);
        }

        protected override void OnDestroy() {
            _player.InvokeTrap(TrapTypeEnum.Dead);
        }
    }
}