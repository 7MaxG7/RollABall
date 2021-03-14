using System;
using UnityEngine;

namespace MaxG {
    [CreateAssetMenu(fileName = "MapConfig", menuName = "Configs/MapConfig", order = 153)]
    public class MapConfig : ScriptableObject {

        public GameObject MapPref {
            get {
                if (!_mapPref)
                    _mapPref = Resources.Load<GameObject>(_mapPrefPath);

                if (!_mapPref)
                    throw new Exception($"{this}: map prefab hasn't been loaded");
                
                return _mapPref;
            }
        }
        public float InputSensitivity => _inputSensitivity;
        public Vector2 MinMapRotation => _minMapRotation;
        public Vector2 MaxMapRotation => _maxMapRotation;
            
        [SerializeField] private string _mapPrefPath;

        [Header("Map input settings")]
        [SerializeField] private float _inputSensitivity;
        [SerializeField] private Vector2 _minMapRotation;
        [SerializeField] private Vector2 _maxMapRotation;

        private GameObject _mapPref;
    }
}