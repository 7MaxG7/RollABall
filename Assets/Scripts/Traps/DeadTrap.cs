using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    public sealed class DeadTrap : Traps {
        protected override void TakeTrap(Collider collision) {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Player")) {
                collision.gameObject.AddComponent<DeadEffect>();
            }
        }
    }
}