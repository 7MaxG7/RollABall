using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    public abstract class EffectParent : MonoBehaviour {
        protected Player _player;
        protected void Awake() {
            _player = GetComponent<Player>();
        }

        protected abstract void OnDestroy();
    }
}