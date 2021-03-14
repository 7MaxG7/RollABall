using System;
using UnityEngine;

namespace MaxG {
    [CreateAssetMenu(fileName = "LogicConfig", menuName = "Configs/LogicConfig", order = 152)]
    public class LogicConfig : ScriptableObject {
        
        public GameObject WinScreenPref {
            get {
                if (!_winScreenPref)
                    _winScreenPref = Resources.Load<GameObject>(_winScreenPrefPath);
                if (!_winScreenPref)
                    throw new Exception($"{this}: logic config hasn't been loaded");

                return _winScreenPref;
            }
        }
        
        [SerializeField] private string _winScreenPrefPath;
        private GameObject _winScreenPref;
    }
}