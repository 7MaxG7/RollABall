using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    /// <summary>
    /// Parent class for all traps
    /// </summary>
    public abstract class Traps : PickupStuff {
        
        protected override void TakeStuff(Collider collision) {
            base.TakeStuff(collision);
            TakeTrap(collision);
        }

        protected abstract void TakeTrap(Collider collision);
    }
}