using System;
using System.Collections.Generic;
using UnityEngine;

namespace MaxG
{
    
    public delegate void NoArgsEvent();

    public delegate void GoEvent(GameObject gObj);
    
    public sealed class StuffTakenEvent {
        private event GoEvent _stuffTaken;
        private List<GoEvent> listeners;

        public StuffTakenEvent() {
            _stuffTaken += delegate { };
            listeners = new List<GoEvent>();
        }

        public void AddListener(GoEvent listener) {
            _stuffTaken += listener;
            listeners.Add(listener);
        }

        public void RemoveListener(GoEvent listener) {
            _stuffTaken -= listener;
        }

        public void RemoveAllListeners() {
            foreach (var listener in listeners) {
                _stuffTaken -= listener;
            }
        }
        
        public void InvokeEvent(GameObject gObj) {
            _stuffTaken.Invoke(gObj);
        }
    }
}