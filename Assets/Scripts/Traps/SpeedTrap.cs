using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    public sealed class SpeedTrap : Traps {
        protected override void TakeTrap(Collider collision) {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Player")) {
                collision.gameObject.AddComponent<SpeedDecreaseEffect>();
            }
        }
    }
}