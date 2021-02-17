using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    public sealed class SpeedTrap : TrapsParent {
        protected override void OnCollisionEnter(Collision collision) {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Player")) {
                collision.gameObject.AddComponent<SpeedDecreaseEffect>();
                Destroy(transform.parent);
            }
        }
    }
}