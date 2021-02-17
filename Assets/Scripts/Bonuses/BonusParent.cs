using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    /// <summary>
    /// Parent class for all bonuses
    /// </summary>
    public abstract class BonusParent : MonoBehaviour {
        protected abstract void OnCollisionEnter(Collision collision);
    }
}