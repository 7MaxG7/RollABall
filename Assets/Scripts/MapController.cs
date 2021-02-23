using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Class for controlling ball / labirinth (not shure about game rules)
/// </summary>
public sealed class MapController : MonoBehaviour {
    [SerializeField] private float _controllerSensitivity;
    private Transform _transform;

    private void Awake() {
        if (_controllerSensitivity == 0)
            _controllerSensitivity = 50;
        _transform = transform;
    }
    private void Update() {
        float horizontalInput = Input.GetAxis("Mouse X");
        float verticalInput = Input.GetAxis("Mouse Y");
        RotateMap(0-horizontalInput, verticalInput);
    }

    private void RotateMap(float horizontalRotate, float verticalRotate) {
        if (horizontalRotate != 0) {
            _transform.Rotate(0, 0, horizontalRotate * _controllerSensitivity * Time.deltaTime, Space.Self);
        }
        if (verticalRotate != 0) {
            _transform. Rotate(verticalRotate * _controllerSensitivity * Time.deltaTime, 0, 0, Space.Self);
        }
    }
}
