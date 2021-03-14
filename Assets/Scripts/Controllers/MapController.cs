using UnityEngine;

namespace MaxG {
    
    public class MapController : IInitializer, IUpdater {
        private readonly GameObject _mapPref;
        private readonly float _controllerSensitivity;
        private Transform _transform;

        public MapController(MapConfig mapConfig) {
            _mapPref = mapConfig.MapPref;
            _controllerSensitivity = mapConfig.InputSensitivity;
        }
        
        public void Init() {
            GameObject mapObj = GameObject.Instantiate(_mapPref);
            _transform = mapObj.transform;
        }

        public void DoUpdate(float deltaTime) {
            RotateMap(0 - Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), deltaTime);
        }
   
        private void RotateMap(float horizontalRotation, float verticalRotation, float deltaTime) {
            if (horizontalRotation != 0) {
                _transform.Rotate(0, 0, horizontalRotation * deltaTime * _controllerSensitivity, Space.Self);
            }
            if (verticalRotation != 0) {
                _transform. Rotate(verticalRotation * deltaTime * _controllerSensitivity, 0, 0, Space.Self);
            }
        }
    }
}