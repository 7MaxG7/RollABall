using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    /// <summary>
    /// Parent class for all bonuses
    /// </summary>
    public class Bonuses : PickupStuff, IUpdater {

        public BonusTypeEnum bonusType;
        
        // protected override void TakeStuff(Collider collision) {
        //     base.TakeStuff(collision);
        //     TakeBonus(collision);
        // }

        protected virtual void TakeBonus(Collider collision) {}
        public void DoUpdate(float deltaTime) {
            
        }
    }
}