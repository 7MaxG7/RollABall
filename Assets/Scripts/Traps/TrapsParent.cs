using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    /// <summary>
    /// Parent class for all traps
    /// </summary>
    public abstract class TrapsParent : MonoBehaviour {
        protected abstract void OnCollisionEnter(Collision collision);
    }
}