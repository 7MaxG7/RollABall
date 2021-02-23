using System;
using System.Collections;
using System.Collections.Generic;
using MaxG;
using UnityEngine;

namespace MaxG
{

    /// <summary>
    /// Class for moving camera after the ball
    /// </summary>
    public sealed class CameraController : MonoBehaviour
    {
        private Animator _anim;
        private StuffTakenEvent _stuffTakenEvent;
        private readonly int _shakeTrigger = Animator.StringToHash("shake");

        void Awake() {
            _anim = GetComponent<Animator>();
            _stuffTakenEvent = FindObjectOfType<GameLogic>().StuffTakenEvent;
        }

        private void Start() {
            _stuffTakenEvent.AddListener(ShakeCam);
        }

        private void ShakeCam() {
            _anim.SetTrigger(_shakeTrigger);
        }
    }
}