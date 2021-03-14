using System;
using UnityEngine;

namespace MaxG {
    [CreateAssetMenu(fileName = "UIConfig", menuName = "Configs/UIConfig", order = 155)]
    
    public class UIConfig : ScriptableObject {

        public Vector2 ReferenceResolution => _referenceResolution;

        public GameObject ReloadButton {
            get {
                if (!_reloadButton)
                    _reloadButton = Resources.Load<GameObject>(_reloadButtonPath);
                if (!_reloadButton)
                    throw new Exception($"{this}: reload button prefab hasn't been loaded");

                return _reloadButton;
            }
        }
        
        [Header("Canvas settings")]
        [SerializeField] private Vector2 _referenceResolution;

        [Space(15)]
        [SerializeField] private string _reloadButtonPath;

        private GameObject _reloadButton;
    }
}