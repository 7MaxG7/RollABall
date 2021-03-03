using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    /// <summary>
    /// Parent class for all traps
    /// </summary>
    public class Traps : PickupStuff {
        
        public TrapTypeEnum trapType;
        
        protected override void TakeStuff(Collider collision) {
            base.TakeStuff(collision);
            TakeTrap(collision);
        }

        protected virtual void TakeTrap(Collider collision) {
        }
    }
}