using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    public sealed class KeyBonus : BonusParent {
        private GameLogic _logic;
        private void Awake() {
            _logic = FindObjectOfType<GameLogic>();
        }
        private void Start() {
            _logic.CountAddedKey();
        }
        protected override void OnCollisionEnter(Collision collision) {
            _logic.CountCollectedKey();
        }
    }
}