using System.Collections;
using System.Collections.Generic;
using MaxG;
using UnityEngine;

/// <summary>
/// Class for controlling labirinth
/// </summary>
public sealed class MapController : IUpdater {
    private readonly float _controllerSensitivity;
    private readonly Transform _transform;

    private MapController(MapConfig mapConfig, GameObject mapObj) {
        _controllerSensitivity = mapConfig.InputSensitivity;
        _transform = mapObj.transform;
    }

    public void DoUpdate(float deltaTime) {
        RotateMap(0 - Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), deltaTime);
    }

    private void RotateMap(float horizontalRotate, float verticalRotate, float deltaTime) {
        if (horizontalRotate != 0) {
            _transform.Rotate(0, 0, horizontalRotate * deltaTime * _controllerSensitivity, Space.Self);
        }
        if (verticalRotate != 0) {
            _transform. Rotate(verticalRotate * deltaTime * _controllerSensitivity, 0, 0, Space.Self);
        }
    }
}
