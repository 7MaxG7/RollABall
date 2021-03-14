using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MaxG {

    /// <summary>
    /// Parent class for all traps
    /// </summary>
    public class Traps : PickupStuff, IUpdater {
        
        public TrapTypeEnum trapType;

        public void DoUpdate(float deltaTime) {
            
        }
    }
}