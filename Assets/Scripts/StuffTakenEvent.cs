using System;
using UnityEngine;

namespace MaxG
{
    
    public delegate void NoArgsEvent();
    
    public sealed class StuffTakenEvent : MonoBehaviour {
        private event NoArgsEvent _stuffTaken;

        private void Awake() {
            _stuffTaken += delegate { };
        }

        public void AddListener(NoArgsEvent listener) {
            _stuffTaken += listener;
        }

        public void InvokeEvent() {
            _stuffTaken.Invoke();
        }
    }
}