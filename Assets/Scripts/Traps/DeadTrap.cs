using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    public sealed class DeadTrap : TrapsParent {
        protected override void OnCollisionEnter(Collision collision) {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Player")) {
                collision.gameObject.AddComponent<DeadEffect>();
                Destroy(transform.parent);
            }
        }
    }
}