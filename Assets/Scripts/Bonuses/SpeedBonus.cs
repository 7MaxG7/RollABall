using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    public sealed class SpeedBonus : Bonus {

        protected override void TakeBonus(Collider collision) {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Player")) {
                collision.gameObject.AddComponent<SpeedDecreaseEffect>();
            }
        }
    }
}