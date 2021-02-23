using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    public abstract class Effect : MonoBehaviour {
        protected Player _player;
        protected float _effectDuration = 3;

        protected virtual void Awake() {
            _player = GetComponent<Player>();
        }

        protected abstract void OnDestroy();
    }
}