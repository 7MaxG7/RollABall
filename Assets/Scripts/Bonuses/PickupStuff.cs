using System;
using UnityEngine;

namespace MaxG
{
    
    public class PickupStuff : MonoBehaviour {
        public StuffTakenEvent stuffTakenEvent;

        protected virtual void Awake() {
            stuffTakenEvent = new StuffTakenEvent();
        }
        
        protected void OnTriggerEnter(Collider collision) {
            TakeStuff(collision);
        }

        protected void TakeStuff(Collider collision) {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Player")) {
                stuffTakenEvent.InvokeEvent(collision.gameObject);
                Destroy(transform.gameObject);
            }
        }

        private void OnDestroy() {
            stuffTakenEvent.RemoveAllListeners();
        }
    }
}