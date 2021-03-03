using System;
using UnityEngine;

namespace MaxG
{
    
    public class PickupStuff : MonoBehaviour {
        public StuffTakenEvent stuffTakenEvent;

        protected virtual void Awake() {
            // stuffTakenEvent = FindObjectOfType<GameLogic>().StuffTakenEvent;
            stuffTakenEvent = new StuffTakenEvent();
        }
        
        protected void OnTriggerEnter(Collider collision) {
            TakeStuff(collision);
        }

        protected virtual void TakeStuff(Collider collision) {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Player")) {
                stuffTakenEvent.InvokeEvent(collision.gameObject);
                Destroy(transform.gameObject);
                // Destroy(transform.parent.gameObject);
            }
        }

        private void OnDestroy() {
            stuffTakenEvent.RemoveAllListeners();
        }
    }
}