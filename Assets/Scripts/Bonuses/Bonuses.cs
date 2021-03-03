using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    /// <summary>
    /// Parent class for all bonuses
    /// </summary>
    public abstract class Bonuses : PickupStuff {
        protected override void TakeStuff(Collider collision) {
            base.TakeStuff(collision);
            TakeBonus(collision);
        }

        protected abstract void TakeBonus(Collider collision);
    }
}