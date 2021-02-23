using UnityEngine;

namespace MaxG
{
    
    public class PickupStuff : MonoBehaviour {
        private StuffTakenEvent _stuffTakenEvent;

        protected virtual void Awake() {
            _stuffTakenEvent = FindObjectOfType<GameLogic>().StuffTakenEvent;
        }
        
        private void OnTriggerEnter(Collider collision) {
            TakeStuff(collision);
        }

        protected virtual void TakeStuff(Collider collision) {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Player")) {
                _stuffTakenEvent.InvokeEvent();
                Destroy(transform.parent.gameObject);
            }
        }
    }
}