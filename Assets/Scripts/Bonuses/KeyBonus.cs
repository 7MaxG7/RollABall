using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    public sealed class KeyBonus : Bonuses {
        private GameLogic _logic;
        
        protected override void Awake() {
            base.Awake();
            _logic = FindObjectOfType<GameLogic>();
        }
        
        private void Start() {
            _logic.CountAddedKey();
        }
        
        protected override void TakeBonus(Collider collision) {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Player")) {
                _logic.CountCollectedKey();
            }
        }
    }
}