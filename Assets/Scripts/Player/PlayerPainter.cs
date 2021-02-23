using UnityEngine;

namespace MaxG
{
    
    public class PlayerPainter : MonoBehaviour {
        private Animator _anim;
        private StuffTakenEvent _stuffTakenEvent;
        private readonly int _recolorTrigger = Animator.StringToHash("recolor");
        
        private void Awake() {
            _anim = GetComponent<Animator>();
            _stuffTakenEvent = FindObjectOfType<GameLogic>().StuffTakenEvent;
        }
        private void Start() {
            _stuffTakenEvent.AddListener(AnimateBallColorChanging);
        }
        
        private void AnimateBallColorChanging() {
            _anim.SetTrigger(_recolorTrigger);
        }
    }
}